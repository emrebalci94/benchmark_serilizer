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
    public class MarketOutcome
    {
        [Key(0)]
        [ProtoMember(1)]
        public int MarketId { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public int OutcomeNo { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public string OutcomeName { get; set; }
        [Key(3)]
        [ProtoMember(4)]
        public int OutcomeResult { get; set; }
        [Key(4)]
        [ProtoMember(5)]
        public double? FixedOdds { get; set; }
        [Key(5)]
        [ProtoMember(6)]
        public double? FixedOddsWeb { get; set; }
        [Key(6)]
        [ProtoMember(7)]
        public int OddsVersion { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class Market
    {
        [Key(0)]
        [ProtoMember(1)]
        public int EventId { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public int GameNo { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public int MarketId { get; set; }
        [Key(3)]
        [ProtoMember(4)]
        public int MarketNo { get; set; }
        [Key(4)]
        [ProtoMember(5)]
        public int MarketVersion { get; set; }
        [Key(5)]
        [ProtoMember(6)]
        public DateTime SellBeginDate { get; set; }
        [Key(6)]
        [ProtoMember(7)]
        public DateTime SellEndDate { get; set; }
        [Key(7)]
        [ProtoMember(8)]
        public DateTime? ResultExpectedDate { get; set; }
        [Key(8)]
        [ProtoMember(9)]
        public DateTime? ResultSettledDate { get; set; }
        [Key(9)]
        [ProtoMember(10)]
        public string MarketName { get; set; }
        [Key(10)]
        [ProtoMember(11)]
        public int MarketType { get; set; }
        [Key(11)]
        [ProtoMember(12)]
        public int? MainMarket { get; set; }
        [Key(12)]
        [ProtoMember(13)]
        public int MarketStatus { get; set; }
        [Key(13)]
        [ProtoMember(14)]
        public int ChannelWeb { get; set; }
        [Key(14)]
        [ProtoMember(15)]
        public int ChannelRetailer { get; set; }
        [Key(15)]
        [ProtoMember(16)]
        public int MarketSubType { get; set; }
        [Key(16)]
        [ProtoMember(17)]
        public int MarketTypePriority { get; set; }
        [Key(17)]
        [ProtoMember(18)]
        public List<int> CcGroupIds { get; set; }
        [Key(18)]
        [ProtoMember(19)]
        public string SpecialOddsValue { get; set; }
        [Key(19)]
        [ProtoMember(20)]
        public int MinCombiCount { get; set; }
        [Key(20)]
        [ProtoMember(21)]
        public int MaxCombiCount { get; set; }
        [Key(21)]
        [ProtoMember(22)]
        public List<int> MarketClosedCombinations { get; set; }
        [Key(22)]
        [ProtoMember(23)]
        public List<MarketOutcome> MarketOutcomes { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class CompetitionClosedCombination
    {
        [Key(0)]
        [ProtoMember(1)]
        public int CompetitionId { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public List<int> CcGroupIds { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class EventClosedCombination
    {
        [Key(0)]
        [ProtoMember(1)]
        public int EventId { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public List<int> CcGroupIds { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class EventParticipant
    {
        [Key(0)]
        [ProtoMember(1)]
        public int Id { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public int EventItemNo { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public string Acronym { get; set; }
        [Key(3)]
        [ProtoMember(4)]
        public string Name { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class Competition
    {
        [Key(0)]
        [ProtoMember(1)]
        public int Id { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public string Acronym { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public string Name { get; set; }
        [Key(3)]
        [ProtoMember(4)]
        public int Priority { get; set; }
        [Key(4)]
        [ProtoMember(5)]
        public int? IsTopCompetition { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class CompetitionGroup
    {
        [Key(0)]
        [ProtoMember(1)]
        public int Id { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public string Acronym { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public string Name { get; set; }
        [Key(3)]
        [ProtoMember(4)]
        public int Priority { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class SportProgram
    {
        [Key(0)]
        [ProtoMember(1)]
        public int FromVersion { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public int ToVersion { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public List<SportEvent> SportEvents { get; set; }
    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class EventData
    {
        [Key(0)]
        [ProtoMember(1)]
        public int EventVersion { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public int BettingStatus { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public int? BetRadarId { get; set; }
        [Key(3)]
        [ProtoMember(4)]
        public string EventName { get; set; }
        [Key(4)]
        [ProtoMember(5)]
        public DateTime EventDate { get; set; }
        [Key(5)]
        [ProtoMember(6)]
        public int? IsTopEvent { get; set; }
        [Key(6)]
        [ProtoMember(7)]
        public int SportId { get; set; }
        [Key(7)]
        [ProtoMember(8)]
        public string SportName { get; set; }
        [Key(8)]
        [ProtoMember(9)]
        public int SportPriority { get; set; }
        [Key(9)]
        [ProtoMember(10)]
        public Competition Competition { get; set; }
        [Key(10)]
        [ProtoMember(11)]
        public CompetitionGroup CompetitionGroup { get; set; }
        [Key(11)]
        [ProtoMember(12)]
        public string CountryId { get; set; }
        [Key(12)]
        [ProtoMember(13)]
        public string CountryName { get; set; }
        [Key(13)]
        [ProtoMember(14)]
        public int EventType { get; set; }
        [Key(14)]
        [ProtoMember(15)]
        public DateTime? OddsSettingDate { get; set; }
        [Key(15)]
        [ProtoMember(16)]
        public int? IsLiveEvent { get; set; }
        [Key(16)]
        [ProtoMember(17)]
        public int BettingPhase { get; set; }
        [Key(17)]
        [ProtoMember(18)]
        public int LiveStreamAvailable { get; set; }
        [Key(18)]
        [ProtoMember(19)]
        public int LiveStreamEventId { get; set; }
        [Key(19)]
        [ProtoMember(20)]
        public string MatchStatus { get; set; }
        [Key(20)]
        [ProtoMember(21)]
        public List<EventParticipant> Participants { get; set; }
        [Key(21)]
        [ProtoMember(22)]
        public List<EventClosedCombination> ClosedCombinations { get; set; }
        [Key(22)]
        [ProtoMember(23)]
        public List<CompetitionClosedCombination> ClosedCompetitionCombinations { get; set; }


    }

    [Serializable]
    [MessagePackObject]
    [ProtoContract]
    public class SportEvent
    {
        [Key(0)]
        [ProtoMember(1)]
        public int EventId { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        public EventData EventData { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        public List<Market> Markets { get; set; }
    }


}