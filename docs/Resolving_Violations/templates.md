---
parent: Resolving Violations
title: Templates
nav_order: 3
---

Pull request template that introduces a new EditorConfig rule and resolves its violations:

```
This pull request introduces the EditorConfig rule:

# $RULE_ID$: $RULE_DESCRIPTION$

Recommendation:

`$RULE_PROPERTY$ : $RULE_VALUE$`

> $RULE_RECOMMENDATION$

Rationale: https://styleascode.net/ID/$RULEID$

Instances resolved: $VIOLATION_COUNT$
```

Example:

```
This pull request introduces the EditorConfig rule:

# IDE0007: Use var instead of explicit type when type is apparent

`csharp_style_var_when_type_is_apparent : true:suggestion`

Recommendation:

> Use var when the type is already mentioned on the right-hand side of a declaration expression.

Rationale: https://styleascode.net/ID/IDE0007

Instances resolved: 14
```

Note that multiple rules may be included in the same pull request if the total number of resolved violations is relatively small (<5 or so), and each rule is non-controversial. Example:

```
#IDE0018: Variable declaration can be inlined

Recommendation:

> `out` variables should be declared inline when possible.

Rationale: https://styleascode.net/ID/IDE0018

Instances resolved: 6

---

#IDE1005: Delegate invocation can be simplified

Recommendation:

> The null-conditional operator should be used to simplify delegate invocation when possible.

Rationale: https://styleascode.net/ID/IDE1005

Instances resolved: 7
```

---

Commit template for introducing a new rule:

```
Introduces $RULE_PROPERTY$ : $RULE_VALUE$.
```

Commit template for resolving a rule's violations (remember, one rule per commit):

```
Resolves $COUNT$ violations of rule $RULE_ID$.
```