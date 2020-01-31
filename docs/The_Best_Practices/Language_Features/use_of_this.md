---
grand_parent: The Best Practices
parent: Language Features
title: Use of this.
---

These code style settings relate to when `this.` should and should not be used.

## Recommendation

`this.` should only be used when absolutely necessary.

## Justification

The [.NET Runtime Coding Style](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) guidelines state:

> We avoid `this.` unless absolutely necessary:

Where absolutely necessary means the code would behave differently without the use of `this.`

Examples of where using `this.` is necessary[^1]:

 1. [To qualify members hidden by similar name][2]
 2. [To have an object pass itself as a parameter to other methods][3]
 3. To have an object return itself from a method
 4. [To declare indexers][4]
 5. [To declare extension methods][5]
 6. [To pass parameters between constructors][6]
 7. [To internally reassign value type (struct) value][7].
 8. To invoke an extension method on the current instance
 9. To cast itself to another type
 10. [To chain constructors defined in the same class][8]

  [2]: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
  [3]: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
  [4]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/index
  [5]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
  [6]: http://www.codeproject.com/Articles/7011/An-Intro-to-Constructors-in-C%29
  [7]: https://stackoverflow.com/questions/194484/whats-the-strangest-corner-case-youve-seen-in-c-or-net/1800162#1800162
  [8]: https://stackoverflow.com/questions/1814953/c-sharp-constructor-chaining-how-to-do-it

## Arguments

### For omitting `this.`

* If exceptions were made the to 'absolutely necessary' rule, then that logic should apply to the entire codebase. However, without an analyzer to enforce the rule there would always be leftover suggestions and inconsistency.

### Against omitting `this.`

* `this.` explicitly indicates which references belong to the enclosing class.

## Exceptions

## Performance

There is no difference in performance when using `this.`, as it is removed by the compiler.

## Analyzers

[Visual Studio .NET code style](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-language-conventions?#this-and-me)

| ID | Name | Value
|:-|:-|:-|
| [IDE0003][1] | dotnet_style_qualification_for_field | false:suggestion |
| [IDE0003][1] | dotnet_style_qualification_for_property | false:suggestion |
| [IDE0003][1] | dotnet_style_qualification_for_method | false:suggestion |
| [IDE0003][1] | dotnet_style_qualification_for_event | false:suggestion |

[1]: https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-language-conventions?#this-and-me

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/1){: .btn .btn-purple }

---

[^1]: https://stackoverflow.com/a/23502/644186
