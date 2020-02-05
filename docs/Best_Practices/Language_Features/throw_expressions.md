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

Both the Roslyn and .NET Core runtime teams agree that using this language feature is desirable.

## Arguments

**Against using throw expressions for null checks**

* Only available in C# 7+

## Exceptions

## Performance

Sample IL:

* [without throw expression](..../../IL_Samples/throw_expression_false)
* [with throw expression](..../../IL_Samples/throw_expression_true)

## Readability

* Typically reduces 3-5 lines of code down to 1
* Line length does increase with a chance of exceeding 80-120 characters

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0016 | csharp_style_throw_expression | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/4){: .btn .btn-purple }
