
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.441 (1803/April2018Update/Redstone4)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=2.2.401
  [Host] : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


        Method | Mean | Error |
-------------- |-----:|------:|
        ToJson |   NA |    NA |
        ToBtye |   NA |    NA |
 ToMessagePack |   NA |    NA |

Benchmarks with issues:
  SerializersBenchmark.ToJson: DefaultJob
  SerializersBenchmark.ToBtye: DefaultJob
  SerializersBenchmark.ToMessagePack: DefaultJob
