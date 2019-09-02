``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.950 (1803/April2018Update/Redstone4)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  Job-KIPIKC : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT

IterationCount=250  RunStrategy=Monitoring  

```
|        Method |        Mean |       Error |     StdDev |      Median |        Min |          Q1 |          Q3 |          Max |     Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------- |------------:|------------:|-----------:|------------:|-----------:|------------:|------------:|-------------:|----------:|------:|------:|-----------:|
|        ToJson |  9,988.0 us |   222.65 us | 1,057.2 us |  9,788.2 us | 8,080.3 us |  9,141.8 us | 10,684.0 us |  13,513.2 us | 1000.0000 |     - |     - | 3239.27 KB |
|        ToBtye | 11,237.0 us |   243.34 us | 1,155.4 us | 10,893.6 us | 9,648.3 us | 10,378.2 us | 11,786.7 us |  16,754.6 us | 1000.0000 |     - |     - | 3156.36 KB |
| ToMessagePack |    695.3 us |    21.59 us |   102.5 us |    672.0 us |   578.2 us |    651.6 us |    695.5 us |   1,292.1 us |         - |     - |     - |  292.19 KB |
|    ToProtobuf |  7,696.8 us | 2,005.38 us | 9,521.8 us |  6,563.4 us | 5,403.8 us |  6,104.0 us |  7,152.7 us | 152,445.6 us |         - |     - |     - |  365.26 KB |
