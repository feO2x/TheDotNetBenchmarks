using System.Dynamic;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.DynamicallyVsStaticallyTyped;

// ReSharper disable once InconsistentNaming
public class DynamicallyVsStaticallyTyped_ReadValueFromObject
{
    public readonly dynamic DynamicObject = new StaticallyTypedObject();
    public readonly dynamic ExpandoObject;
    public readonly StaticallyTypedObject StaticallyTypedObject = new ();

    public DynamicallyVsStaticallyTyped_ReadValueFromObject()
    {
        ExpandoObject = new ExpandoObject();
        ExpandoObject.Value = StaticallyTypedObject.Value;
    }

    [Benchmark(Baseline = true)]
    public string ReadFromStaticallyTypedObject() => StaticallyTypedObject.Value;

    [Benchmark]
    public string ReadFromDynamicObject() => DynamicObject.Value;

    [Benchmark]
    public string ReadFromExpandoObject() => ExpandoObject.Value;
}