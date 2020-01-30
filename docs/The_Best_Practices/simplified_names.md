---
title: Simplified Names
parent: The Best Practices
---

# Simplified Names

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

| Rule ID | Rule Name | Value
|:-|:-|:-|
| IDE0049 | dotnet_style_predefined_type_for_locals_parameters_members | true:suggestion |
| IDE0049 | dotnet_style_predefined_type_for_member_access | true:suggestion |

## Discussion

[Code as Style GitHub issue](){: .btn .btn-purple }