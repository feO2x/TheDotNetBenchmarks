``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1889 (21H2)
AMD Ryzen 9 5950X, 1 CPU, 32 logical and 16 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  Job-WIZQOY : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Runtime=.NET 6.0  

```
|                       Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|----------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
| WriteToStaticallyTypedObject |  1.246 ns | 0.0044 ns | 0.0037 ns |  1.00 |    0.00 |         - |
|         WriteToDynamicObject |  7.766 ns | 0.0615 ns | 0.0575 ns |  6.24 |    0.04 |         - |
|         WriteToExpandoObject | 57.105 ns | 0.4331 ns | 0.3616 ns | 45.84 |    0.34 |         - |
