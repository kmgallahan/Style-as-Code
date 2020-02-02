---
parent: The Process
title: EditorConfig Selection
nav_order: 1
---

Assuming you do not have one already, here are your options for selecting an initial EditorConfig file:

* Start from scratch
* Export your Visual Studio settings
* Use the Visual Studio defaults
* Use the .NET Core Runtime or Rosyln Compiler EditorConfig
* Use the Style as Code EditorConfig

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

## Export your Visual Studio settings

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

## Use the .NET Core Runtime or Rosyln Compiler EditorConfig

[.NET Core Runtime EditorConfig](https://raw.githubusercontent.com/dotnet/runtime/master/.editorconfig)

[Roslyn Compiler EditorConfig](https://raw.githubusercontent.com/dotnet/roslyn/master/.editorconfig)

Pros:

* You'll be adopting a widely used and accepted set of best practices

Cons:

* You won't get as much control over rule choices

## Use the Style as Code EditorConfig

Pros:

* You'll get the same benefits of using the .NET Core Runtime rules
* It should be easier for you to reach 0 warnings and suggestions
* The file is divided into useful sections
* The file has comments with links to relevant best practices documentation

Cons:

* You might disagree with some rule configurations
* Your EditorConfig will have references to styleascode.net