---
title: Use of `this.`
parent: The Best Practices
---

## Recommendation

`this.` should only be used when absolutely necessary.

## Justification

The [.NET Runtime Coding Style](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) states:

> We avoid `this.` unless absolutely necessary.

Where absolutely necessary means without using `this.` the code would behave differently.

## Arguments

For omitting `this.`:

* If exceptions were made the to 'absolutely necessary' rule, then that logic should apply to the entire codebase. However, without an analyzer to enforce the rule there would always be leftover suggestions and inconsistency.

Against omitting `this.`:

* `this.` explicitly indicates which references belong to the enclosing class.

## Exceptions

## Performance

None.

`this.` is removed by the compiler.

## Analyzers

Visual Studio .NET code style:

| Rule ID | Rule name | Value
|:-|:-|:-|
| IDE0003 | dotnet_style_qualification_for_field | false:suggestion |
| IDE0003 | dotnet_style_qualification_for_property | false:suggestion |
| IDE0003 | dotnet_style_qualification_for_method | false:suggestion |
| IDE0003 | dotnet_style_qualification_for_event | false:suggestion |

## Discussion

[Code as Style GitHub issue](https://github.com/kmgallahan/Style-as-Code/issues/1)