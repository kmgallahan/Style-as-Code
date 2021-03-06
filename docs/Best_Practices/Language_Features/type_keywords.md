---
grand_parent: Best Practices
parent: Language Features
title: Type Keywords
---

[Microsoft Docs / Types Keywords](https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/built-in-types-table)

## Recommendation

For locals, parameters and type members, prefer types that have a language keyword to represent them (`int, double, string`, etc.) to use that keyword instead of the type name (`Int32, Int64`, etc.).

Prefer the keyword whenever a member-access expression is used on a type with a keyword representation (`int, double, string`, etc.).

## Justification

Both the Roslyn and .NET Core runtime teams agree that using this language feature is desirable.

The [.NET Runtime Coding Style](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) guidelines state:

> We use language keywords instead of BCL types (e.g. `int, string, float` instead of `Int32, String, Single`, etc) for both type references as well as method calls (e.g. `int.Parse` instead of `Int32.Parse`).

### Arguments

See [this discussion](https://github.com/dotnet/runtime/issues/13976) between members of the .NET team for reference.

✔ Promotes consistency in coding style.

### Performance

|         Method |     Mean |   Error |  StdDev |
|--------------- |---------:|--------:|--------:|
| NoTypeKeywords | 205.3 ns | 1.38 ns | 1.16 ns |
|   TypeKeywords | 207.8 ns | 4.04 ns | 3.96 ns |

[Benchmark code](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/type_keywords_benchmark.cs)

[Benchmark IL](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/type_keywords_benchmark_IL)

## Exceptions

Using type names in classes that deal with interop is acceptable.

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0001 | "Simplify names"<br>dotnet_diagnostic.IDE0001.severity | |
| [IDE0049][1] | dotnet_style_predefined_type_for_locals_parameters_members | true:suggestion |
| [IDE0049][2] | dotnet_style_predefined_type_for_member_access | true:suggestion |

[1]: https://docs.microsoft.com/visualstudio/ide/editorconfig-language-conventions?#dotnet_style_predefined_type_for_locals_parameters_members
[2]: https://docs.microsoft.com/visualstudio/ide/editorconfig-language-conventions?#dotnet_style_predefined_type_for_member_access

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/8){: .btn .btn-purple }