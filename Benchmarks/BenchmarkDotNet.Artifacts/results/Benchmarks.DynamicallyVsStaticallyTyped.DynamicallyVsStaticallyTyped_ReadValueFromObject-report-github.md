``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1889 (21H2)
AMD Ryzen 9 5950X, 1 CPU, 32 logical and 16 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  Job-WIZQOY : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Runtime=.NET 6.0  

```
|                        Method |      Mean |     Error |    StdDev |  Ratio | RatioSD | Allocated |
|------------------------------ |----------:|----------:|----------:|-------:|--------:|----------:|
| ReadFromStaticallyTypedObject | 0.0155 ns | 0.0094 ns | 0.0088 ns |   1.00 |    0.00 |         - |
|         ReadFromDynamicObject | 3.2258 ns | 0.0274 ns | 0.0256 ns | 319.44 |  229.01 |         - |
|         ReadFromExpandoObject | 4.3259 ns | 0.0246 ns | 0.0231 ns | 427.93 |  307.05 |         - |
