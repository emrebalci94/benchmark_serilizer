``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.441 (1803/April2018Update/Redstone4)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  Job-KFTKWV : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT

IterationCount=100  RunStrategy=Monitoring  

```
|        Method |      Mean |     Error |    StdDev |       Min |        Q1 |        Q3 |       Max |    Median |      Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|-------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|-----------:|----------:|----------:|----------:|
|        ToJson | 465.59 ms | 2.1988 ms |  6.483 ms | 452.50 ms | 461.06 ms | 470.43 ms | 485.14 ms | 464.98 ms | 20000.0000 | 8000.0000 | 2000.0000 | 115.71 MB |
|        ToBtye | 370.81 ms | 6.0070 ms | 17.712 ms | 344.71 ms | 358.26 ms | 379.15 ms | 426.09 ms | 367.40 ms | 15000.0000 | 5000.0000 | 2000.0000 |  83.65 MB |
| ToMessagePack |  22.34 ms | 0.6666 ms |  1.965 ms |  19.82 ms |  20.79 ms |  23.36 ms |  27.88 ms |  22.08 ms |  2000.0000 | 1000.0000 | 1000.0000 |   9.45 MB |
|    ToProtobuf |  34.98 ms | 0.5715 ms |  1.685 ms |  32.34 ms |  33.82 ms |  35.75 ms |  42.61 ms |  34.87 ms |  1000.0000 |         - |         - |   5.15 MB |
