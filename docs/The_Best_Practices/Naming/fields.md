---
grand_parent: The Best Practices
parent: Naming
title: Naming Fields
---

## Recommendation

Use PascalCasing for `const` and `public` fields.

Use `_camelCase` for `internal` and `private` fields.

Prefix `static` fields with `s_`.

Prefix `[ThreadStatic]` fields with `t_`.

## Justification

The .NET Runtime Coding Style guidelines state:

> We use `_camelCase` for internal and private fields and use `readonly` where possible. Prefix internal and private instance fields with `_`, static fields with `s_` and thread static fields with `t_`.

> Public fields should be used sparingly and should use PascalCasing with no prefix when used.

> We use PascalCasing to name all our constant local variables and fields.

## Arguments

## Exceptions

The .NET Runtime Coding Style guidelines state:

> The only exception is for interop code where the constant value should exactly match the name and value of the code you are calling via interop.

## Performance

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE1006 | "name all constant fields using PascalCase"<br>dotnet_naming_rule.constant_fields_should_be_pascal_case.severity | suggestion |

## Discussion

[GitHub Discussion](){: .btn .btn-purple }
