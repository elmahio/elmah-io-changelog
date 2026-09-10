---
title: "Elmah.Io.Log4Net 5.1.34"
date: 2024-05-27T05:57:52Z
categories: [New]
slug: elmah-io-log4net-5-1-34-293581
---
We released a new version ([5.1.34](https://www.nuget.org/packages/Elmah.Io.Log4Net/5.1.34)) of the `Elmah.Io.Log4Net` package. The new version includes the following changes:

- Target .NET 8 in `Elmah.Io.AspNetCore.Log4Net` to define framework reference to `Microsoft.AspNetCore.App` instead of package reference to `Microsoft.AspNetCore.Http`.
- New .NET 8 sample and removed the .NET 3.1 sample.
- Upgraded `Microsoft.SourceLink.GitHub` to `8.0.0`.
- Newest `Elmah.Io.Client`.
- Upgraded `log4net` to 2.0.15 (you can use a newer version if you prefer).
- Building on .NET 8.
- Several code improvements after running Sonar checks. This is all internal so no need for code changes are required by you.
