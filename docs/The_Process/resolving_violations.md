---
parent: The Process
title: Resolving Violations
nav_order: 2
---

There are a few options for how to resolve rule violations in a codebase:

* One rule at a time
* One file at a time
* All at once

Automated analyzer fixes will make any of the processes go relatively smoothly, however the results may not always be desirable.

## The recommended process

The currently recommend process is as follows:

1. Use Visual Studio's Error List to navigate to multiple violations of a single rule
2. Observe how the recommended fixes will impact the code
3. Make note of any situations where changing the code might not be desirable
4. Resolve all instances of the rule violation across the codebase
5. Create a commit to capture this rule-specific set of changes
6. Optional (when not committing directly to master): Create a pull request whenever the number of changes is non-trivial (e.g. more than ~5 instances of rule violations were resolved)
7. Optional: In the PR provide a link to the relevant Style as Code rationale (https://styleascode.net/ID/*******)

// Todo: How many rule violation resolution instances should have a dedicated PR?

// Todo: Should changes be discussed before or after PRs are created?

**Note:** A pilot application of this process is being applied to the [XAML Controls Gallery](https://github.com/microsoft/Xaml-Controls-Gallery). Lessons learned during that process will shape the process found here.

---

## Templates

This is a template that can be used to initiate pull requests meant to resolve all or most violations of a single rule:

```
This pull request resolves $COUNT$ violations of rule $RULE_ID$ where:

$RULE_RECOMMENDATION$

See the reasoning for this rule here:

https://styleascode.net/ID/$RULEID$
```