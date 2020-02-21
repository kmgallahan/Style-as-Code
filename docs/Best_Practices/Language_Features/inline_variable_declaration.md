---
grand_parent: Best Practices
parent: Language Features
title: Inline Variable Declaration
nav_exclude: true
---

[Microsoft Docs / out Variables](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7#out-variables)

## Recommendation

`out` variables should be declared inline when possible.

Use:

```cs
dictionaryWithEntry.TryGetValue(1, out string entry);
```

Not:

```cs
string entry;

dictionaryWithEntry.TryGetValue(1, out entry);
```

## Justification

Both the Roslyn and .Net Core runtime teams agree that this language feature should be used.

### Arguments

For using inlined `out` variable declarations

- The code is easier to read; you declare the out variable where you use it, not on another line above.
- No need to assign an initial value; by declaring the `out` variable where it's used in a method call, you can't accidentally use it before it is assigned.

### Performance

The same IL is generated, regardless of if the out variable is declared inline or not.

|                          Method |     Mean |     Error |    StdDev |
|-------------------------------- |---------:|----------:|----------:|
| NoOutVariableNonEmptyDictionary | 6.383 ns | 0.1909 ns | 0.1785 ns |
|    NoOutVariableEmptyDictionary | 2.918 ns | 0.1185 ns | 0.1108 ns |
|   OutVariableNonEmptyDictionary | 6.308 ns | 0.0890 ns | 0.0789 ns |
|      OutVariableEmptyDictionary | 2.932 ns | 0.0843 ns | 0.0747 ns |

Note: there are no managed memory allocations, so this stat is omitted.

[Benchmark code](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/inline_out_variable_benchmark.cs)

[Benchmark IL](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/inline_out_variable_benchmark_IL)

### Readability

Typically eliminates one line of code used to declare the variable elsewhere, and one blank line.

## Exceptions

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0018 | csharp_style_inlined_variable_declaration | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/5){: .btn .btn-purple }
