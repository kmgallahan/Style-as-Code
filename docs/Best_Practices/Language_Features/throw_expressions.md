---
grand_parent: Best Practices
parent: Language Features
title: Throw Expressions
---

[Microsoft Docs / Throw Expressions](https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/throw#the-throw-expression)

## Recommendation

use:

```cs
_execute = execute ?? throw new ArgumentNullException(nameof(execute));
```

not:

```cs
if (execute == null)
    throw new ArgumentNullException(nameof(execute));

_execute = execute;
```

## Justification

## Arguments

## Exceptions

## Performance

## Readability

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0016 | csharp_style_throw_expression | |

## Discussion

[GitHub Discussion](){: .btn .btn-purple }
