---
title: FAQ
nav_order: 6
---

## Q: Why is this project called Style as Code?

A: Similar to [Infrastructure as Code](https://docs.microsoft.com/azure/devops/learn/what-is-infrastructure-as-code), Style as Code is meant to help manage coding style through versioned EditorConfig files.

Also:

```cs
var goodName = style as Code;
```

## Q: What are Roslyn Analyzers?

A: A key part of implementing code style best practices is [Roslyn Analyzers](https://docs.microsoft.com/visualstudio/code-quality/roslyn-analyzers-overview). These convert EditorConfig settings and theoretical best practices to the squiggles and suggestions shown in your IDE.

Many analyzer packages exist, each containing multiple rules (also known as *diagnostics*). One goal of this project is to map analyzer rules to best practice pages that discusses their usage.

This allows developers to easily search by rule IDs (e.g. IDE0003) to find the best practices information on that subject.

## Q: Should I use code analysis or EditorConfig for checking code style?

See the [Microsoft Docs on this question](https://docs.microsoft.com/visualstudio/code-quality/analyzers-faq?#code-analysis-versus-editorconfig).
