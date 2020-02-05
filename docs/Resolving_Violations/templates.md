---
parent: Resolving Violations
title: Templates
nav_order: 3
---

Pull request template that introduces a new EditorConfig rule and resolves its violations:

```
This pull request introduces the EditorConfig rule:

# $RULE_ID$: $RULE_DESCRIPTION$
$RULE_PROPERTY$ : $RULE_VALUE$

It also resolves $VIOLATION_COUNT# violations where the recommendation is to:

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

Commit template for introducing a new rule:

```
Introduces $RULE_PROPERTY$ : $RULE_VALUE$
```

Commit template for resolving a rule's violations (remember, one rule per commit):

```
Resolves $COUNT$ violations of rule $RULE_ID$.
```