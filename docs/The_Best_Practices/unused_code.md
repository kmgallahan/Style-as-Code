---
title: Unused Code
parent: The Best Practices
---

## Recommendation

All rules related to unused code should be set to refactoring only, or otherwise severity:none.

## Justification

Writing new code requires concentration. An IDE suggesting that code be removed immediately after it is creates unnecessary distraction.

Regarding **IDE0060: Remove unused parameters**: event handlers attached through XAML will always be flagged as having unused parameters.

## Arguments



## Exceptions



## Performance



## Analyzers

| Rule ID | Rule Name | Value
|:-|:-|:-|
| IDE0051 | "Remove unused private members"<br>dotnet_diagnostic.IDE0051.severity | none
| IDE0052 | "Remove unread private members"<br>dotnet_diagnostic.IDE0052.severity | none
| IDE0059 | "Unnecessary assignment of a value"<br>csharp_style_unused_value_assignment_preference | unused_local_variable:refactoring
| [IDE0060][1] | "Remove unused parameters"<br>dotnet_code_quality_unused_parameters | all:refactoring |

[1]: https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-language-conventions?#net-code-quality-settings

## Discussion

[Code as Style GitHub issue]()