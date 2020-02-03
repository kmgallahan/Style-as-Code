---
title: The Process
has_children: true
nav_order: 3
has_toc: false
---

Getting started with EditorConfig files involves these steps:

1. [EditorConfig selection](editorconfig_selection.md)
2. [Resolving violations](resolving_violations.md)
3. [Adding analyzers](adding_analyzers.md)

If you're already using an EditorConfig and want to stick with it, then start on step 2.

If you're already at 0 warnings and suggestions, then decide on if you:

* are content with you current configuration
* want to tweak some existing rules > explore the [best practices](../The_Best_Practices/index.md)
* want to use more analyzers > step 3

## New vs. existing projects

Any developer looking to adopt an EditorConfig likely falls into one of these roles:

* Owner of a new project
* Owner of an existing project
* Contributor to a new project
* Contributor to an existing project

Project owners will always have an easier time executing code style change processes than contributors.

In either case though, getting a new project to adopt an EditorConfig file will have the obvious benefit of all contributors pushing code with consistent style from start.

## Contributing to existing projects

Making code style related changes to existing projects can be challenging if you don't own the code.

As a contributor, a good approach would be to:

* Make your intentions known
* Get buy-in on a minimal EditorConfig file
* Follow the recommended process for resolving violations for all configured rules
* Use issues and/or pull requests to begin introducing more rules to the EditorConfig, getting buy-in on them, and then pushing the code changes
