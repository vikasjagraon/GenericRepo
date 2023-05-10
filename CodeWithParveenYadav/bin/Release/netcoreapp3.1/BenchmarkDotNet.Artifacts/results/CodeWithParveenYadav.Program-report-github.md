``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.102
  [Host]     : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT AVX2


```
|                     Method |        Mean |     Error |    StdDev |       Gen0 |      Gen1 |    Allocated |
|--------------------------- |------------:|----------:|----------:|-----------:|----------:|-------------:|
|        PerformanceOfString | 28,788.2 μs | 570.52 μs | 721.53 μs | 60156.2500 | 8968.7500 | 370712.35 KB |
| PerformanceOfStringBuilder |    430.1 μs |   7.31 μs |   6.48 μs |   163.0859 |    0.9766 |   1000.98 KB |
