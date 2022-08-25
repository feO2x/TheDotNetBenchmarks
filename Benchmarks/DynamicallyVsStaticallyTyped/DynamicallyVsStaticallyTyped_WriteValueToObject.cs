using System.Dynamic;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.DynamicallyVsStaticallyTyped;

// ReSharper disable once InconsistentNaming
public class DynamicallyVsStaticallyTyped_WriteValueToObject
{
    private const string SomeOtherValue = "Some other value";
    public readonly dynamic DynamicObject = new StaticallyTypedObject();
    public readonly dynamic ExpandoObject = new ExpandoObject();
    public readonly StaticallyTypedObject StaticallyTypedObject = new ();

    [Benchmark(Baseline = true)]
    public string WriteToStaticallyTypedObject() => StaticallyTypedObject.Value = SomeOtherValue;

    [Benchmark]
    public string WriteToDynamicObject() => DynamicObject.Value = SomeOtherValue;

    [Benchmark]
    public string WriteToExpandoObject() => ExpandoObject.Value = SomeOtherValue;
}