using System.IO;
using benchmark_serilizer.Extension;
using benchmark_serilizer.Serilizer;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using MessagePack;
using ProtoBuf;

namespace benchmark_serilizer
{
    [SimpleJob(RunStrategy.Monitoring, targetCount: 100)]
    [MemoryDiagnoser, MinColumn, Q1Column, Q3Column, MaxColumn, MedianColumn]
    public class SerializersBenchmark
    {
        private SportProgram _program;
        [GlobalSetup]
        public void LoadDataset()
        {
            string jsondata = File.ReadAllText("data.json");
            _program = JsonSerilizer.Deserilize<SportProgram>(jsondata);

        }

        [Benchmark]
        public void ToJson()
        {
            var json = JsonSerilizer.Serilizer(_program);
            var result1 = JsonSerilizer.Deserilize(json);
        }

        [Benchmark]
        public void ToBtye()
        {
            var byt = _program.ToByte();
            var result2 = byt.ToObject<SportProgram>();
        }

        [Benchmark]
        public void ToMessagePack()
        {
            var msg = MessagePackSerializer.Serialize(_program);
            var result3 = MessagePackSerializer.Deserialize<SportProgram>(msg);
        }

        [Benchmark]
        public void ToProtobuf()
        {
            using (var file = File.Create("person.bin"))
            {
                Serializer.Serialize(file, _program);
            }

            SportProgram newPerson;
            using (var file = File.OpenRead("person.bin"))
            {
                newPerson = Serializer.Deserialize<SportProgram>(file);
            }
        }
    }
}