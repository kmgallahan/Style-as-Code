---
title: The EditorConfig
has_children: true
has_toc: false
nav_order: 2
---

The [Microsoft Docs](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options) provide a great starting point to learn about EditorConfig files.

Here are 3 options to avoid starting from scratch:

## Visual Studio Defaults

Visual Studio [can generate](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files) a `.editorconfig` file populated with the default settings.

[Visual Studio Defaults EditorConfig](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig_VisualStudioDefaults)

## .NET Runtime EditorConfig

The .NET Runtime project relies on the Visual Studio defaults as a baseline.

Then using their [Coding Style guidelines](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md) a modified EditorConfig file was created.

[.NET Runtime Editorconfig](https://github.com/dotnet/runtime/blob/master/.editorconfig)

## Style as Code EditorConfig

Style as Code relies on the .NET Runtime EditorConfig as its baseline. Modifications have been made to:

* Help developers get to zero IDE suggestions
* Highlight groups of settings than can be toggled when desired
* Cover settings for Roslyn Analyzers beyond those included in Visual Studio

The file is versioned and iterated upon as more information is added to the best practices documentation.

[Style as Code EditorConfig](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig)
