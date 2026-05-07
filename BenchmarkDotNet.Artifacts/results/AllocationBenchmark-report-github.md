```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.1 (24G231) [Darwin 24.6.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a


```
| Method              | Mean         | Error      | StdDev     | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------- |-------------:|-----------:|-----------:|--------:|--------:|--------:|----------:|
| NewByteArray        | 3,813.313 ns | 30.0032 ns | 26.5970 ns | 32.2571 | 32.2571 | 32.2571 |  102446 B |
| ArrayPoolRentReturn |     6.443 ns |  0.0882 ns |  0.0736 ns |       - |       - |       - |         - |
