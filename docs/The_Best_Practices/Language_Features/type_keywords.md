---
grand_parent: The Best Practices
parent: Language Features
title: Type Keywords
---

[Microsoft Docs > Types Keywords])(https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/built-in-types-table)

## Recommendation

For locals, parameters and type members, prefer types that have a language keyword to represent them (`int, double, string`, etc.) to use that keyword instead of the type name (`Int32, Int64`, etc.).

Prefer the keyword whenever a member-access expression is used on a type with a keyword representation (`int, double, string`, etc.).

## Justification

The [.NET Runtime Coding Style](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) guidelines state:

> We use language keywords instead of BCL types (e.g. `int, string, float` instead of `Int32, String, Single`, etc) for both type references as well as method calls (e.g. `int.Parse` instead of `Int32.Parse`).

## Arguments

## Exceptions

## Performance

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0001 | "Simplify names"<br>dotnet_diagnostic.IDE0001.severity | |
| [IDE0049][1] | dotnet_style_predefined_type_for_locals_parameters_members | true:suggestion |
| [IDE0049][2] | dotnet_style_predefined_type_for_member_access | true:suggestion |

[1]: https://docs.microsoft.com/visualstudio/ide/editorconfig-language-conventions?#dotnet_style_predefined_type_for_locals_parameters_members
[2]: https://docs.microsoft.com/visualstudio/ide/editorconfig-language-conventions?#dotnet_style_predefined_type_for_member_access

## Discussion

[GitHub Discussion](){: .btn .btn-purple }