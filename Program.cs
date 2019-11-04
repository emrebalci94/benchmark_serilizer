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
            var summary = BenchmarkRunner.Run<BigDataSerializersBenchmark>();

            Console.ReadKey();

        }
    }
}
