using System;
using System.Collections.Generic;
using MessagePack;
using Newtonsoft.Json;
using ProtoBuf;

namespace benchmark_serilizer
{
    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class SportProgramResponse
    {
        [Key(0)]
        [ProtoMember(1)]
        public int SportId { get; set; }

        private List<EventResponse> _events;
        [Key(1)]
        [ProtoMember(2)]
        public List<EventResponse> Events
        {
            get => _events ?? (_events = new List<EventResponse>());
            set => _events = value;
        }
    }

    [Serializable]
    [ProtoContract]
    [MessagePackObject]
    public class EventResponse
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sid")]
        [ProtoMember(1)]
        [Key(0)]
        public int? SportId { get; set; }

        [ProtoMember(2)]
        [Key(1)]
        [JsonProperty("eid")]
        public int EventId { get; set; }

        [ProtoMember(3)]
        [Key(2)]
        [JsonProperty("ev")]
        public int EventVersion { get; set; }
        [ProtoMember(4)]
        [Key(3)]
        [JsonProperty("cn")]
        public string CompetitionName { get; set; }
        [ProtoMember(5)]
        [Key(4)]
        [JsonProperty("ca")]
        public string CompetitionAcronym { get; set; }
        [ProtoMember(6)]
        [Key(5)]
        [JsonProperty("cid")]
        public int CompetitionId { get; set; }
        [ProtoMember(7)]
        [Key(6)]
        [JsonProperty("e")]
        public DateTime EventDate { get; set; }
        [ProtoMember(8)]
        [Key(7)]
        [JsonProperty("ed")]
        public long EventDateEpoch { get; set; }
        [ProtoMember(9)]
        [Key(8)]
        [JsonProperty("ede")]
        public string EventDateExplain { get; set; }
        [ProtoMember(10)]
        [Key(9)]
        [JsonProperty("edh")]
        public string EventDateHour { get; set; }
        [ProtoMember(11)]
        [Key(10)]
        [JsonProperty("en")]
        public string EventName { get; set; }
        [ProtoMember(12)]
        [Key(11)]
        [JsonProperty("mb")]
        public int MainMbs { get; set; }
        [ProtoMember(13)]
        [Key(12)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sc")]
        public string Score { get; set; }
        [ProtoMember(14)]
        [Key(13)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "min")]
        public string Minute { get; set; }
        [ProtoMember(15)]
        [Key(14)]
        [JsonIgnore]
        public BettingStatus BettingStatus { get; set; }
        [ProtoMember(16)]
        [Key(15)]
        [JsonIgnore]
        public bool IsLive { get; set; }
        [ProtoMember(17)]
        [Key(16)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mc")]
        public int? OtherMarketCount { get; set; }
        [ProtoMember(18)]
        [Key(17)]
        [JsonProperty("m")]
        public List<MarketResponse> Markets { get; set; }
    }

    [Serializable]
    [ProtoContract]
    [MessagePackObject]
    public class MarketResponse
    {
        [JsonProperty("mid")]
        [ProtoMember(1)]
        [Key(0)]
        public int MarketId { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        [JsonProperty("mv")]
        public int MarketVersion { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        [JsonProperty("mn")]
        public string MarketName { get; set; }
        [ProtoMember(4)]
        [Key(3)]
        [JsonProperty("muk")]
        public string MarketUniqueKey { get; set; }
        [ProtoMember(5)]
        [Key(4)]
        [JsonProperty("mbs")]
        public int MinimumBetCount { get; set; }
        [ProtoMember(6)]
        [Key(5)]
        [JsonProperty("ms")]
        public int MarketStatus { get; set; }
        [ProtoMember(7)]
        [Key(6)]
        [JsonProperty("o")]
        public List<MarketOutcomeResponse> Outcomes { get; set; }
    }

    [Serializable]
    [ProtoContract]
    [MessagePackObject]
    public class MarketOutcomeResponse
    {
        [JsonProperty("ou")]
        [ProtoMember(1)]
        [Key(0)]
        public string OutcomeUniqueId { get; set; }
        [ProtoMember(2)]
        [Key(1)]
        [JsonProperty("ono")]
        public int OutcomeNo { get; set; }
        [ProtoMember(3)]
        [Key(2)]
        [JsonProperty("odd")]
        public double Odd { get; set; }
        [ProtoMember(4)]
        [Key(3)]
        [JsonProperty("sodd")]
        public string ShowOdd { get; set; }//=> Odd.ToString();
        [ProtoMember(5)]
        [Key(4)]
        [JsonProperty("ona")]
        public string OutcomeName { get; set; }
        [ProtoMember(6)]
        [Key(5)]
        [JsonProperty("ov")]
        public int OddsVersion { get; set; }
        [ProtoMember(7)]
        [Key(6)]
        [JsonProperty("cs")]
        public string ChangeStatus { get; set; }
    }

    public enum BettingStatus
    {
        Paused = -1,
        Closed = 0,
        Open = 1
    }
}