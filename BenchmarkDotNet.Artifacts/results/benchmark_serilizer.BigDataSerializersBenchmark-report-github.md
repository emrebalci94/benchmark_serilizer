``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.720 (1809/October2018Update/Redstone5)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  Job-TNZUOS : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT

IterationCount=100  RunStrategy=Monitoring  

```
|        Method |      Mean |     Error |    StdDev |    Median |       Min |        Q1 |        Q3 |       Max |     Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|-------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|
|        ToJson | 22.114 ms | 1.3648 ms | 4.0242 ms | 21.148 ms | 18.398 ms | 20.244 ms | 22.450 ms | 45.066 ms | 1000.0000 |         - |         - |   9.81 MB |
|        ToBtye | 34.645 ms | 2.0632 ms | 6.0835 ms | 32.885 ms | 27.050 ms | 31.425 ms | 34.896 ms | 59.580 ms | 2000.0000 | 1000.0000 | 1000.0000 |  10.35 MB |
| ToMessagePack |  3.214 ms | 0.2713 ms | 0.7998 ms |  3.043 ms |  2.251 ms |  2.668 ms |  3.421 ms |  6.452 ms |         - |         - |         - |   1.63 MB |
|    ToProtobuf | 11.081 ms | 0.6171 ms | 1.8195 ms | 11.171 ms |  8.468 ms |  9.384 ms | 11.999 ms | 17.241 ms |         - |         - |         - |   1.61 MB |
