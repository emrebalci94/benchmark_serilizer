using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using benchmark_serilizer.Extension;
using benchmark_serilizer.Serilizer;
using BenchmarkDotNet.Running;
using MessagePack;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProtoBuf;

namespace benchmark_serilizer
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var cultureInfoTurkish = new CultureInfo("tr-TR");

            CultureInfo.DefaultThreadCurrentCulture = cultureInfoTurkish;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfoTurkish;
            CultureInfo.CurrentCulture = cultureInfoTurkish;
            CultureInfo.CurrentUICulture = cultureInfoTurkish;
            RedisCacheServiceMsgPack service = new RedisCacheServiceMsgPack();
            string jsondata = File.ReadAllText("data2.json");
            var data = JsonSerilizer.Deserilize<SportProgramResponse>(jsondata);
            Stopwatch sw = new Stopwatch();

            // sw.Start();
            // System.Console.WriteLine("Json Serialize işlemi başlatıldı.");
            // var json = JsonSerilizer.Serilizer(data);
            // System.Console.WriteLine("Json Deserialize işlemi başlatıldı.");
            // var result1 = JsonSerilizer.Deserilize(json);
            // sw.Stop();
            // System.Console.WriteLine($"Toplam:{sw.ElapsedMilliseconds} ms.");

            // sw.Reset();

            // sw.Start();
            // System.Console.WriteLine("Byte Serialize işlemi başlatıldı.");
            // var byt = data.ToMsgPackSerialize();
            // System.Console.WriteLine("Byte Deserialize işlemi başlatıldı.");
            // var result2 = byt.ToMsgPackDeserialize<SportProgram>();
            // sw.Stop();
            // System.Console.WriteLine($"Toplam:{sw.ElapsedMilliseconds} ms.");

            // sw.Reset();

            // sw.Start();
            // System.Console.WriteLine("MessagePack Serialize işlemi başlatıldı.");
            // var msg = MessagePackSerializer.Serialize(data);
            // System.Console.WriteLine("MessagePack Deserialize işlemi başlatıldı.");
            // var result3 = MessagePackSerializer.Deserialize<SportProgram>(msg);
            // sw.Stop();
            // System.Console.WriteLine($"Toplam:{sw.ElapsedMilliseconds} ms.");
            // var summary = BenchmarkRunner.Run<SerializersBenchmark>();

            // var msg = MessagePackSerializer.Serialize(data);
            // var result3 = MessagePackSerializer.Deserialize<SportProgramResponse>(msg);

            // using (var file = File.Create("person2.bin"))
            // {
            //     Serializer.Serialize(file, data);
            // }

            SportProgramResponse newPerson;
            using (var file = File.OpenRead("person2.bin"))
            {
                newPerson = Serializer.Deserialize<SportProgramResponse>(file);
            }

            var summary = BenchmarkRunner.Run<SportProgramResponseSerializer>();

            // double count = 0;
            // try
            // {
            //     while (true)
            //     {
            //         count++;
            //         Console.Clear();
            //         sw.Start();
            //         service.Set("msgpack_test", data);
            //         sw.Stop();
            //         System.Console.WriteLine($"{count}. MsgPack Seriliaze edip redise atma süresi:{sw.ElapsedMilliseconds} ms. ( {DateTime.Now.ToString("dd.MM.yyyy HH:mm")} )");
            //         using (var swf = File.AppendText("log.txt"))
            //         {
            //             swf.WriteLine($"{count}. MsgPack Seriliaze edip redise atma süresi:{sw.ElapsedMilliseconds} ms. ( {DateTime.Now.ToString("dd.MM.yyyy HH:mm")} )");
            //         }
            //         sw.Reset();
            //         sw.Start();
            //         var res = service.Get<SportProgramResponse>("msgpack_test");
            //         if (res == null)
            //         {
            //             count--;
            //         }
            //         sw.Stop();
            //         System.Console.WriteLine($"{count}. MsgPack Deseriliaze edip redisden alma süresi:{sw.ElapsedMilliseconds} ms. ( {DateTime.Now.ToString("dd.MM.yyyy HH:mm")} )");
            //         using (var swf = File.AppendText("log.txt"))
            //         {
            //             swf.WriteLine($"{count}. MsgPack Deseriliaze edip redisden alma süresi:{sw.ElapsedMilliseconds} ms. ( {DateTime.Now.ToString("dd.MM.yyyy HH:mm")} )");
            //         }
            //     }
            // }
            // catch (System.Exception ex)
            // {
            //     // Console.Clear();
            //     System.Console.WriteLine($"Exception:{ex} -> {ex.StackTrace}");
            //     System.Console.WriteLine($"{count}. denemede patladı.");
            //     using (var swf = File.AppendText("log.txt"))
            //     {
            //         swf.WriteLine($"{count}. denemede patladı. Exception:{ex} -> {ex.StackTrace}");
            //     }
            // }


            // File.WriteAllText("response.json", res.ToJson());

            Console.ReadKey();

        }
    }
}
