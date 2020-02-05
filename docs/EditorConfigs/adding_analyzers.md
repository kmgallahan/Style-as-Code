---
parent: EditorConfigs
title: Adding Analyzers
nav_order: 4
---

Before adding additional analyzers to your project(s), carefully consider if you're willing to take the time to actually configure and resolve the new rules.

Adding a package with hundreds of rules just to end up ignoring them runs against the goal of getting to 0 warnings and suggestions. In fact, configuring all rules to the severity level of `none` may be appropriate in order to more slowly introduce and configure them.

Style as Code does plan to help with the configuration and best practices aspect of this.

Here are some options for general purpose analyzer packages:

* [Microsoft's FxCop Analyzers](https://github.com/dotnet/roslyn-analyzers)
  * [FxCop CodeQuality](https://github.com/dotnet/roslyn-analyzers#microsoftcodequalityanalyzers)
  * [FxCop NetCore](https://github.com/dotnet/roslyn-analyzers#microsoftnetcoreanalyzers)
  * [FxCop NetFramework](https://github.com/dotnet/roslyn-analyzers#microsoftnetframeworkanalyzers)
* [Rosylnator](https://github.com/JosefPihrt/Roslynator)
* [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
* [Sonar-DotNet](https://github.com/SonarSource/sonar-dotnet)

Specialty Analyzers:

* [NUnit](https://github.com/nunit/nunit.analyzers)
* [XUnit](https://github.com/xunit/xunit.analyzers)
* [Entity Framework Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Analyzers/)