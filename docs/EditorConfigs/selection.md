---
parent: EditorConfigs
title: Selection
nav_order: 1
---

Assuming you do not already have one, your options for selecting an EditorConfig are to:

* [Start from scratch](#start-from-scratch)
* [Create from your Visual Studio settings](#create-from-your-visual-studio-settings)
* [Use the default Visual Studio settings](#use-the-default-visual-studio-settings)
* [Use the .NET Core Runtime or Rosyln Compiler EditorConfigs](#use-the-net-core-runtime-or-rosyln-compiler-editorconfigs)
* [Use the Minimal Style as Code EditorConfig](#use-the-minimal-style-as-code-editorconfig)
* [Use the Style as Code EditorConfig](#use-the-style-as-code-editorconfig)

The advantages of each option are presented below.

## Start from scratch

[Instructions](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files)

Pros:

* Existing Visual Studio setting will be honored
* You have control over how rules are configured
* You'll likely learn more about the individual rules than would otherwise be the case

Cons:

* More time spent creating the EditorConfig
* Any missing rules will instead be configured by whatever IDE instance the project is opened with (so different settings for IDEs, devices, and contributors)

## Create from your Visual Studio settings

[Instructions](https://docs.microsoft.com/visualstudio/ide/code-styles-and-code-cleanup?view=vs-2019#code-styles-in-editorconfig-files)

Pros:

* You have control over how rules are configured

Cons:

* You may not have spent time deciding on if the defaults are best, or if your changes follow best practices

## Use the default Visual Studio settings

[Instructions](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files)

Pros:

* The defaults are a fairly good starting point

Cons:

* You'll need or want to invest time reviewing the best practices to make changes to rule configurations

## Use the .NET Core Runtime or Rosyln Compiler EditorConfigs

[.NET Core Runtime EditorConfig](https://github.com/dotnet/runtime/blob/master/.editorconfig)

[Roslyn Compiler EditorConfig](https://github.com/dotnet/roslyn/blob/master/.editorconfig)

Pros:

* You'll be adopting a set of rules that are used by one of the largest C# projects with many contributors

Cons:

* You won't get as much control over rule choices
* You'll need to decide on which one to adopt, and that isn't straightforward

As to why picking one isn't straightforward, as of February 2020 between the files there are:

* 148 C# rules defined
* 58 are equal
* 25 are **not equal**
* 74 are only defined in one EditorConfig

You can read more about the differences [here](disagreements.md).

## Use the Minimal Style as Code EditorConfig

Pros:

* Only includes rules that appear and are equal in both the .NET Core runtime and Roslyn Compiler EditorConfigs
* You get to decide which rules to add and how to configure them

Cons:

* You'll have to invest more time learning about the rules, configuring them, and modifying the EditorConfig
* With many rules missing, contributors will still be relying on some rules as configured in their IDE installations

[Style as Code Minimal EditorConfig](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig_minimal)

## Use the Style as Code EditorConfig

Pros:

* The rationale for all rule decisions should be available here
* It should be easier for you to reach 0 warnings and suggestions
* The file is divided into sections of related rules
* The file has comments that pair rule IDs and descriptions with configuration lines
* Some rules are grouped and noted as being those which should be toggled on and off during refactoring
* It will eventually cover settings for Roslyn Analyzers beyond the built-in ones
* The file is versioned and iterated upon as more information is added to the [best practices](../Best_Practices/index.md) documentation

Cons:

* You might disagree with some rule configurations
* The file will be updated over time, so you may fall behind on the best practices being recommended

[Style as Code EditorConfig](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig)
