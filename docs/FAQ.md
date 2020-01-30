---
layout: default
title: What is Style as Code?
nav_order: 5
---

**Q: Why is this project called Style as Code?**

A: Similar to [Infrastructure as Code](https://docs.microsoft.com/en-us/azure/devops/learn/what-is-infrastructure-as-code), Style as Code is meant to help manage coding style through a versioned EditorConfig file.

**Q: What are Roslyn Analyzers?**

A: A key part of implementing code style best practices is [Roslyn Analyzers](https://docs.microsoft.com/visualstudio/code-quality/roslyn-analyzers-overview). These convert EditorConfig settings and theoretical best practices to the squiggles and suggestions shown in your IDE.

Many analyzer packages exist, each containing multiple individual analyzers. One goal of this project is to map analyzers to a best practice page that discusses their usage.

This allows develops to easily search by analyzer ID (e.g. IDE0003) to find the best practices information on that topic.

**Q: Should I use code analysis or EditorConfig for checking code style?**

See the [Microsoft Docs on this question](https://docs.microsoft.com/en-us/visualstudio/code-quality/analyzers-faq?#code-analysis-versus-editorconfig).
