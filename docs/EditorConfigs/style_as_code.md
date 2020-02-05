---
parent: EditorConfigs
title: Style as Code
nav_order: 2
---

Style as Code provides 4 EditorConfigs that all follow the [best practices](../Best_Practices/index.md) discussed here. The options include:

* [Minimal](#minimal)
* [Built-in](#built-in)
* [Built-in with FxCop](#built-in-with-fxcop)
* [Built-in with FxCop & Beyond](#built-in-with-fxcop--beyond)

All rules that can have their violations appear in the Visual Studio Error List will have a comment including their ID and description. Example:

```
# IDE0028: Collection initialization can be simplified
dotnet_style_collection_initializer = true:suggestion
```

Sections divide the rules into groups that correspond with the best practices areas here. Example:

```
########################
# Language Features
########################
```

Some rules are marked "togglable", as leaving them on would require suppressions to achieve 0 violations. Toggling them should be done during focused code refactoring sessions. An example would be all of the rules referring to unused code. Example: 

```
########################
# Unused member toggles
########################

# Toggle (comment/uncomment) these rules during focused refactoring sessions

# IDE0051: Remove unused private members
dotnet_diagnostic.IDE0051.severity = none
# dotnet_diagnostic.IDE0051.severity = warning
```

## Minimal

This EditorConfig only includes the rules where both the Roslyn compiler and .NET Core runtime teams agree on how they should be configured.

It is meant to include little to no controversial rules so as to make getting started as painless as possible.

[Style as Code Minimal EditorConfig](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig_minimal)

## Built-in

This EditorConfig covers all of the built-in rules.

Rules are configured based on rationale that is documented here under the best practices section.

[Style as Code EditorConfig](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig)

## Built-in with FxCop

This EditorConfig will include all of the built-in rules, as well as the rules covered by the [FxCop analyzers](https://docs.microsoft.com/visualstudio/code-quality/configure-fxcop-analyzers).

## Built-in with FxCop & Beyond

This EditorConfig will eventually include sections dedicated to 3rd party analyzers, such as StyleCop, Roslynator, etc.
