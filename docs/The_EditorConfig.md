---
layout: default
title: The EditorConfig
nav_order: 2
---

The [Microsoft Docs](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options) provide a great starting point to learn about EditorConfig files.

Here are 3 options to help avoid starting from scratch:

1. Visual Studio [can generate](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files) a `.editorconfig` file populated with the default settings. [This is what it looks like](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig_VisualStudioDefaults.md).

2. The .NET Runtime project relies on these default settings as a baseline. They proceeded to create [a modified `.editorconfig` file](https://github.com/dotnet/runtime/blob/master/.editorconfig) to enforce their specific [Coding Style guidelines](https://github.com/dotnet/runtime/blob/master/docs/coding-guidelines/coding-style.md).

3. The .NET Runtime .editorconfig file is the baseline for for [the one provided by Style as Code](https://github.com/kmgallahan/Style-as-Code/blob/master/editorconfig/.editorconfig). Modifications have been made to:

* Help developers get to zero IDE suggestions
* Provide blocks of settings than can be toggled when desired
* Cover settings for Roslyn Analyzers beyond those included in Visual Studio
