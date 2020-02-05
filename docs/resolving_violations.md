---
title: Resolving Violations
nav_order: 3
---

* [Proceed with caution](#proceed-with-caution)
* [Contributing to existing projects](#contributing-to-existing-projects)
* [The recommended process](#the-recommended-process)
* [Templates](#templates)

## Proceed with caution

Any developer looking to adopt an EditorConfig falls into one of these roles:

* Owner of a new project
* Owner of an existing project
* Contributor to a new project
* Contributor to an existing project

Project owners will always have an easier time implementing code style related changes than contributors.

If you own a new project, then there is little reason not adopt an EditorConfig, as it is a small amount of time to invest for some great benefits.

Contributors, even to projects just getting started, should proceed with caution.

## Contributing to existing projects

Making code style related changes to existing projects can be challenging if you don't own the code.

As a contributor, a good approach would be to:

* Make your intentions known
* Get buy-in on a minimal EditorConfig file
* Follow the recommended process for resolving violations for all configured rules
* For potentially controversial rules it may be beneficial to open an issue/discussion before introducing the rule and making changes
* Only after resolving the build-in analyzers should additional analyzer packages be considered

I would encourage reading these articles that emphasize the importance of a slow approach:

* [Open Source Contribution Etiquette](https://tirania.org/blog/archive/2010/Dec-31.html), by Miguel de Icaza
* [Don't "Push Your Pull Requests](https://www.igvita.com/2011/12/19/dont-push-your-pull-requests/), by Ilya Grigorik

## The recommended process

There are a few options for how to resolve rule violations in a codebase:

* One rule at a time
* One file at a time
* All at once

[Automated analyzer fixes](https://docs.microsoft.com/visualstudio/ide/code-styles-and-code-cleanup) will make any of the processes go relatively smoothly. However the results may not be desirable by everyone (read the above articles).

The currently recommended process is:

1. If a rule needs to be introduced or modified to the EditorConfig, do so first in a separate commit
2. Use Visual Studio's Error List to navigate to multiple violations of a single rule
3. Observe how the recommended fixes will impact the codebase
4. Make note of instances where changing the code might not be desirable
5. Resolve all instances of the rule violation across the codebase
6. Create a commit to capture this rule-specific set of changes
7. Optional (when not committing directly to master): Create a pull request whenever the number of changes is non-trivial (e.g. more than ~5 instances of rule violations were resolved)
8. Optional: In the PR provide a link to the relevant Style as Code rationale (https://styleascode.net/ID/RULE_ID)

This will allow the maintainers to review the impact of individual rules, while reviewing the rationale provided here if desired.

The approach of tackling one rule at a time will result in less jarring modifications, even though they make touch many files in the codebase.

// Todo: How many rule violation resolution instances should have a dedicated PR?

// Todo: Should changes be discussed before or after PRs are created?

**Note:** A pilot application of this process is being applied to the [XAML Controls Gallery](https://github.com/microsoft/Xaml-Controls-Gallery). Lessons learned during that process will shape the process found here.

---

## Templates

Pull request template that introduces a new EditorConfig rule and resolves its violations:

```
This pull request introduces the EditorConfig rule:

# $RULE_ID$: $RULE_DESCRIPTION$
$RULE_PROPERTY$ : $RULE_VALUE$

It also resolves $COUNT# violations where the recommendation:

$RULE_RECOMMENDATION$

See the rationale for this rule here:

https://styleascode.net/ID/$RULEID$
```

Example:

```
This pull request introduces the EditorConfig rule:

# IDE0007: Use var instead of explicit type when type is apparent
csharp_style_var_when_type_is_apparent : true:suggestion

It also resolves 14 violations where the recommendation is to:

Use var when the type is already mentioned on the right-hand side of a declaration expression.

See the rationale for this rule here:

https://styleascode.net/ID/IDE0007
```

Note that multiple rules may be included in the same pull request if the total number of resolved violations is relatively small (<5 or so), and each rule is non-controversial. Example:

```
Resolves 4 violations of rule IDE00?? where the recommendation is to:

Always specify visibility, even if it's the default.

See the rationale for this rule here:

https://styleascode.net/ID/IDE00??

---

Resolves 2 violations of rule IDE0036 where the recommendation is to:

Respect the preferred modifier order.

See the rationale for this rule here:

https://styleascode.net/ID/IDE0036
```

---

Commit templates:

```
Introduces $RULE_PROPERTY$ : $RULE_VALUE$
```

```
Resolves $COUNT$ violations of rule $RULE_ID$.
```