``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.720 (1809/October2018Update/Redstone5)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  Job-CLMDOJ : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT

IterationCount=100  RunStrategy=Monitoring  

```
|        Method |      Mean |     Error |    StdDev |    Median |       Min |        Q1 |        Q3 |       Max |     Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|-------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|
|        ToJson | 29.081 ms | 1.2670 ms | 3.7359 ms | 28.491 ms | 23.081 ms | 26.516 ms | 30.722 ms | 43.168 ms | 1000.0000 |         - |         - |   9.81 MB |
|        ToBtye | 40.842 ms | 2.3737 ms | 6.9988 ms | 39.435 ms | 30.132 ms | 34.978 ms | 44.200 ms | 68.403 ms | 2000.0000 | 1000.0000 | 1000.0000 |  10.35 MB |
| ToMessagePack |  3.107 ms | 0.3143 ms | 0.9268 ms |  2.735 ms |  2.218 ms |  2.535 ms |  3.302 ms |  6.962 ms |         - |         - |         - |   1.63 MB |
|    ToProtobuf | 11.493 ms | 1.9618 ms | 5.7843 ms | 10.621 ms |  8.445 ms |  9.267 ms | 12.338 ms | 60.739 ms |         - |         - |         - |   1.61 MB |
