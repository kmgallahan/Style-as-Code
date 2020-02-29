---
grand_parent: Best Practices
parent: Language Features
title: Pattern Matching | Over as with null check
---

[Microsoft Docs / The `is` type pattern expression](https://docs.microsoft.com/dotnet/csharp/pattern-matching#the-is-type-pattern-expression)

## Recommendation

Use pattern matching with the *is expression* over the `as` operator with a null check.

Use:

```cs
if (sender is Button b)
```

Not:

```cs
Button b = sender as Button;

if (b != null)
```

## Justification

Both the Roslyn and .NET Core runtime teams agree that using this language feature is desirable.

### Arguments

✔ Tends to eliminate a line dedicated to using the as operator with a variable assignment.

✔ Potential 5-10% speed improvement.

❌ Require an understanding variable scoping rules for if statements and how the *is expression* works.

❌ Only available in C# 7.0+.

### Performance

|         Method |     Mean |   Error |  StdDev |
|--------------- |---------:|--------:|--------:|
| NoIsExpression | 136.8 ns | 2.16 ns | 2.02 ns |
|   IsExpression | 126.0 ns | 0.38 ns | 0.32 ns |

[Benchmark code](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/pattern_matching_over_as_with_null_check_benchmark.cs)

[Benchmark IL](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/pattern_matching_over_as_with_null_check_benchmark_IL)


## Exceptions

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0019 | csharp_style_pattern_matching_over_as_with_null_check | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/7){: .btn .btn-purple }
