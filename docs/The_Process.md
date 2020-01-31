---
layout: default
title: The Process
nav_order: 3
---

# The Process

Any developer looking to adopt an EditorConfig likely falls into one of these roles:

* Owner of a new project
* Contributor to a new project
* Owner of an existing project
* Contributor to an existing project

All of these can follow some common steps.

## Common Steps

1. Make or help with the decision to adopt the `.editorconfig` file provided here, use the [.NET Runtime version](https://github.com/dotnet/runtime/blob/master/.editorconfig), or [create your own from Visual Studio](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files)
2. Include the file in your codebase ([instructions](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019#add-and-remove-editorconfig-files))
3. Don't ignore IDE warnings & suggestions

Afterwards:

* If you want to know why the EditorConfig is suggesting a certain code style, refer to the information on that subject
* If you strongly disagree with a setting and/or want to provide feedback, use the discussion link for that setting
* If you'd like to contribute to any of the documentation, pull requests are welcome!

## Owner of a new project

1. It's your call, start with step 1 of the common steps above

## Contributor to a new project

1. Send a proposal to the project owner to adopt EditorConfig file usage from the start
2. Provide links to [Code as Style](https://kmgallahan.github.io/Style-as-Code/) and the [Microsoft Docs](https://docs.microsoft.com/visualstudio/ide/create-portable-custom-editor-options) on EditorConfig
3. Be sure to mention that adopting an EditorConfig from the beginning is easier than implementing one later
4. Follow the common steps above and be sure to share them with your teammates

## Owner of an existing project

Start with the common steps for implementation.

Next, since you're in control you have 2 paths to adoption: incremental change or all-at-once.

This decision should be influenced by:

* How many active forks exist
* How closely you want to monitor individual changes
* If you want to rely on automated code style application

If implementing global code style changes isn't a concern, then you can simply use Visual Studio's [code cleanup function](https://docs.microsoft.com/visualstudio/ide/code-styles-and-code-cleanup?#apply-code-styles) on the solution.

Otherwise, if you'd like to implement incremental changes:

1. Use Visual Studio's Error List to navigate to multiple instances of a single rule violation in the codebase
2. Observe how the recommended fixes will impact the code
3. If the changes are agreeable to you, resolve all instances of the rule violation across the codebase
4. Create a commit to capture this rule-specific set of changes
5. Repeat for other rules, optionally using a single or multiple pull requests to merge the code changes

## Contributor to an existing project

**Note:** A pilot application of this process is being applied to the [XAML Controls Gallery](https://github.com/microsoft/Xaml-Controls-Gallery). Lessons learned during that process will shape the process found here.

1. Use Visual Studio's Error List to navigate to multiple instances of a single rule violation in the codebase
2. Observe how the recommended fixes will impact the code
3. Make note of any situations where changing the code might not be desirable by everyone involved
4. Resolve all instances of the rule violation across the codebase
5. Create a commit to capture this rule-specific set of changes
6. Create a pull request whenever the number of changes is non-trivial (e.g. more than ~5 instances of rule violations were resolved)
7. Be sure to link the relevant Style as Code best practice documentation as reference material

// Todo: How many rule violation resolution instances should have a dedicated PR?

// Todo: Should changes be discussed before or after PRs are created?
