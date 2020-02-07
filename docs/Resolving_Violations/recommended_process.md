---
parent: Resolving Violations
title: Recommended Process
nav_order: 2
---

There are a few options for how to resolve rule violations in a codebase:

* One rule at a time
* One file at a time
* All at once

[Automated analyzer fixes](https://docs.microsoft.com/visualstudio/ide/code-styles-and-code-cleanup) will make any of the processes go relatively smoothly. However the results may not be desirable by everyone (see [considerations](considerations.md)).

The currently recommended process is:

1. If a rule needs to be introduced or modified, do so first in a dedicated commit
2. Use Visual Studio's Error List to navigate to multiple violations of a single rule
3. Observe how the recommended fixes will impact the codebase
4. Make note of instances where changing the code might not be desirable
5. Resolve all instances of the rule violation across the codebase
6. Create a commit to capture this rule-specific set of changes
7. Optional (when not committing directly to master): Create a pull request whenever the number of changes is non-trivial (e.g. more than ~5 instances of rule violations were resolved)
8. Optional: In the PR provide a link to the relevant Style as Code rationale (https://styleascode.net/ID/RULE_ID)

This will allow the maintainers to easily see the impact of individual rules, while reviewing the rationale provided here if desired.

This approach of tackling one rule at a time will result in less jarring modifications, even though they may touch many files in the codebase.

// Todo: How many rule violation resolution instances should have a dedicated PR?

// Todo: Should changes be discussed before or after PRs are created?

**Note:** A pilot application of this process is being applied to the [XAML Controls Gallery](https://github.com/microsoft/Xaml-Controls-Gallery). Lessons learned during that process will shape the process found here.