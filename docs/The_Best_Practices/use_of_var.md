---
title: Use of var
parent: The Best Practices
---

## Recommendation

Prefer `var` when the type is already mentioned on the right-hand side of a declaration expression.

## Justification

The [.NET Runtime Coding Style](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) guidelines state:

> We only use `var` when it's obvious what the variable type is (e.g. `var stream = new FileStream(...)` not `var stream = OpenStandardInput()`).

## Arguments

## Exceptions

## Performance

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0007 | "Use implicit type"<br>csharp_style_var_when_type_is_apparent | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/3){: .btn .btn-purple }
