---
title: "Elmah.Io.AspNetCore 5.1.65"
date: 2024-05-16T05:46:04Z
categories: [New]
slug: elmah-io-aspnetcore-5-1-65-292891
---
We released a new version ([5.1.65](https://www.nuget.org/packages/Elmah.Io.AspNetCore/5.1.65)) of the `Elmah.Io.AspNetCore` package. The new version includes the following changes:

- A `ElmahIoExceptionHandler` class has been added. This implements the new `IExceptionHandler` interface introduced in .NET 8.
- The health check publisher now includes checks. With this change, individual health checks will show up in the elmah.io UI with separate statuses and descriptions.
- When targeting .NET we now make use of a framework reference to `Microsoft.AspNetCore.App` instead of installing ASP.NET Core NuGet packages.
- Updated tag helper to reference `Elmah.Io.JavaScript` version `4.1.0`.
- Removed old 3.1 samples and added samples for .NET 8.
- Building on .NET 8.
- Newest `Elmah.Io.Client`.
- Upgraded `Microsoft.SourceLink.GitHub` to `8.0.0`.
- Several code improvements after running Sonar checks. This is all internal so no need for code changes are required by you.
