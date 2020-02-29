---
grand_parent: Best Practices
parent: Language Features
title: Null-conditional Operator | Simplify Delegate Invocation
nav_exclude: true
---

[Microsoft Docs / Null-conditional operator](https://docs.microsoft.com/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-)

## Recommendation

The null-conditional operator should be used to simplify delegate invocation when possible.

Use:

```cs
this.LoadState?.Invoke(this, new LoadStateEventArgs(e.Parameter, null));
```

Not:

```cs
if (this.LoadState != null)
{
    this.LoadState(this, new LoadStateEventArgs(e.Parameter, null));
}
```

When there is no addition branch logic to handle null cases.

## Justification

Both the Roslyn and .Net Core runtime teams agree that the null-conditional operator should be used to simplify delegate invocation.

### Arguments

✔ Tends to eliminate a line dedicated to the null check, two lines for braces, and a level of indentation.

✔ Can introduce a significant performance improvement.

❌ Introduces a call to the `Invoke` method.

### Performance

|                    Method |      Mean |     Error |    StdDev |    Median |
|-------------------------- |----------:|----------:|----------:|----------:|
| NoNullConditionalOperator | 0.4456 ns | 0.0353 ns | 0.0313 ns | 0.4311 ns |
|   NullConditionalOperator | 0.0118 ns | 0.0182 ns | 0.0161 ns | 0.0031 ns |

Note: there are no managed memory allocations, so this stat is omitted.

[Benchmark code](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/null-conditional_operator_delegate_invocation_benchmark.cs)

[Benchmark IL](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/null-conditional_operator_delegate_invocation_benchmark_IL)

## Exceptions

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE1005 | "Delegate invocation can be simplified"<br>csharp_style_conditional_delegate_call | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/6){: .btn .btn-purple }
