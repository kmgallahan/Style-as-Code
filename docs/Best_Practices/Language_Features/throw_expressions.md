---
grand_parent: Best Practices
parent: Language Features
title: Throw Expressions
nav_exclude: true
---

[Microsoft Docs / Throw Expressions](https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/throw#the-throw-expression)

## Recommendation

Use throw expressions to simplify null checks when possible.

Use:

```cs
_execute = execute ?? throw new ArgumentNullException(nameof(execute));
```

Not:

```cs
if (execute == null)
    throw new ArgumentNullException(nameof(execute));

_execute = execute;
```

## Justification

Both the Roslyn and .NET Core runtime teams agree that using this language feature is desirable.

### Arguments

#### Against using throw expressions for null checks

* Only available in C# 7+

### Performance

|            Method |     Mean |     Error |    StdDev |
|------------------ |---------:|----------:|----------:|
| NoThrowExpression | 2.201 ns | 0.0307 ns | 0.0272 ns |
|   ThrowExpression | 2.184 ns | 0.0032 ns | 0.0027 ns |

Note: there are no managed memory allocations, so this stat is omitted.

[Benchmark program](https://github.com/kmgallahan/Style-as-Code/blob/master/IL_Samples/throw_expression_benchmark.cs)

[Benchmark IL](https://github.com/kmgallahan/Style-as-Code/blob/master/IL_Samples/throw_expression_IL)

### Readability

* Typically reduces 3-5 lines of code down to 1
* Line length does increase with a chance of exceeding 80-120 characters

## Exceptions

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0016 | csharp_style_throw_expression | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/4){: .btn .btn-purple }
