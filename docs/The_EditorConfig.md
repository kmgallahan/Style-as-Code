---
layout: default
title: The EditorConfig
nav_order: 2
---

The [Microsoft Docs](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options) provide a great starting point to learn about EditorConfig files.

Here are 3 options to help avoid starting from scratch:

### Visual Studio Defaults

Visual Studio [can generate](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files) a `.editorconfig` file populated with the default settings. [This is what it looks like](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig_VisualStudioDefaults.md).

### .NET Runtime EditorConfig

The .NET Runtime project relies on the Visual Studio defaults as a baseline. They proceeded to create [a modified EditorConfig](https://github.com/dotnet/runtime/blob/master/.editorconfig) to enforce their specific [Coding Style guidelines](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md).

### Style as Code EditorConfig

Style as Code relies on the .NET Runtime EditorConfig as its baseline. Modifications have been made to:

* Help developers get to zero IDE suggestions
* Provide blocks of settings than can be toggled when desired
* Cover settings for Roslyn Analyzers beyond those included in Visual Studio

[This is the current iteration](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig).
