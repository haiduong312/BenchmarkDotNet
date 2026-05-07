using BenchmarkDotNet.Attributes;
using System.Buffers;

[MemoryDiagnoser]
public class AllocationBenchmark
{
    private const int Size = 1024 * 100;

    [Benchmark]
    public byte[] NewByteArray()
    {
        return new byte[Size];
    }

    [Benchmark]
    public void ArrayPoolRentReturn()
    {
        var pool = ArrayPool<byte>.Shared;

        byte[] buffer = pool.Rent(Size);

        // giả lập dùng buffer
        buffer[0] = 1;

        pool.Return(buffer);
    }
}