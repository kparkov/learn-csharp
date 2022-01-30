using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace KVP.LearnCSharp.BasicFunctions;

public static class UnitTesting
{
    public record MethodShape(string ExpectedName, Type ExpectedReturnType, int ExpectedParamLength, Type[] ExpectedParamTypes)
    {
        public Type ContainingType => typeof(Calculator);
        public MethodInfo Method => ContainingType.GetMethod(ExpectedName);
        public bool MethodExists => Method is not null;
        public bool MethodIsPublic => Method.IsPublic;
        public bool MethodIsStatic => Method.IsStatic;

        public Type ActualReturnType => Method.ReturnType;
        public bool HasExpectedReturnType => ActualReturnType == ExpectedReturnType;

        public int ActualParamLength => Method?.GetParameters().Length ?? 0;
        public bool HasExpectedParamLength => Method.GetParameters().Length == ExpectedParamLength;

        public IEnumerable<Type> ActualParameterTypes => Method.GetParameters().Select(p => p.ParameterType);
        public bool HasExpectedParamTypes => Enumerable.SequenceEqual(ActualParameterTypes.OrderBy(t => t.Name), ExpectedParamTypes.OrderBy(t => t.Name));
    }

    public static void AssertShape(MethodShape shape)
    {
        Assert.True(shape.MethodExists, $"Expected method '{shape.ExpectedName}' in the class '{shape.ContainingType.Name}', but did not find it.");
        Assert.True(shape.MethodIsPublic, $"Method '{shape.ExpectedName}' was expected to be public, but it was not.");
        Assert.True(shape.MethodIsStatic, $"Method '{shape.ExpectedName}' was expected to be static, but it was not.");
        Assert.True(shape.HasExpectedReturnType, $"Method '{shape.ExpectedName}' was expected to return type '{shape.ExpectedReturnType.Name}', but did in fact return '{shape.ActualReturnType.Name}'.");
        Assert.True(shape.HasExpectedParamLength, $"Method '{shape.ExpectedName}' was expected to take {shape.ExpectedParamLength} parameters, but did actually take {shape.ActualParamLength}.");
        Assert.True(shape.HasExpectedParamTypes, $"Method '{shape.ExpectedName}' was expected to take parameters of types ({shape.ExpectedParamTypes.NameList()}), but did actually take parameters of types ({shape.ActualParameterTypes.NameList()}).");
    }

    public static string NameList(this IEnumerable<Type> types) => string.Join(", ", types.Select(t => t.Name));
    
}