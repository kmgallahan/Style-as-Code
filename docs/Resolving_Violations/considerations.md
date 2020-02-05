---
parent: Resolving Violations
title: Considerations
nav_order: 1
---

## Proceed with caution

Any developer looking to adopt an EditorConfig falls into one of these roles:

* Owner of a new project
* Owner of an existing project
* Contributor to a new project
* Contributor to an existing project

Project owners will always have an easier time implementing code style related changes than contributors.

If you own a new project, then there is little reason not adopt an EditorConfig, as it is a small time investment that provides some great benefits.

Contributors, even to projects just getting started, should proceed with caution.

## Contributing to existing projects

Making code style related changes to existing projects can be challenging if you don't own the code.

As a contributor, a good approach would be to:

* Make your intentions known
* Get buy-in on a minimal or well-established EditorConfig file
* Follow the recommended process for resolving violations
* For potentially controversial rules it may be beneficial to open an issue/discussion before introducing the rule and making changes
* Only after resolving the build-in analyzers should additional analyzer packages be considered

These articles emphasize the importance of a slow and thoughtful approach to making code style related changes:

* [Open Source Contribution Etiquette](https://tirania.org/blog/archive/2010/Dec-31.html), by Miguel de Icaza
* [Don't "Push Your Pull Requests](https://www.igvita.com/2011/12/19/dont-push-your-pull-requests/), by Ilya Grigorik