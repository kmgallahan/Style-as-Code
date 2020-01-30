---
title: Use of `this.`
parent: The Best Practices
---

## Recommendation

`this.` should only be used when absolutely necessary.

## Justification

The [.NET Runtime Coding Style](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) states:

> We avoid `this.` unless absolutely necessary[^1]:

Where absolutely necessary means the code would behave differently without the use of `this.`.

Examples of where using `this.` is necessary:

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

  [1]: http://msdn.microsoft.com/en-us/library/dk1507sz.aspx
  [2]: http://msdn.microsoft.com/en-us/library/vstudio/dk1507sz%28v=vs.100%29.aspx
  [3]: http://msdn.microsoft.com/en-us/library/vstudio/dk1507sz%28v=vs.100%29.aspx
  [4]: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
  [5]: http://msdn.microsoft.com/en-us/library/bb383977.aspx
  [6]: http://www.codeproject.com/Articles/7011/An-Intro-to-Constructors-in-C%29
  [7]: https://stackoverflow.com/questions/194484/whats-the-strangest-corner-case-youve-seen-in-c-or-net/1800162#1800162
  [8]: https://stackoverflow.com/questions/1814953/c-sharp-constructor-chaining-how-to-do-it

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

[^1]: https://stackoverflow.com/a/23502/644186