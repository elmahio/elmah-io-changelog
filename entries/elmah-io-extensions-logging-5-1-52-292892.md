---
title: "Elmah.Io.Extensions.Logging 5.1.52"
date: 2024-05-16T06:00:35Z
categories: [New]
slug: elmah-io-extensions-logging-5-1-52-292892
---
We released a new version ([5.1.52](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/5.1.52)) of the `Elmah.Io.Extensions.Logging` package. The new version includes the following changes:

- Fixed a minor issue where a property is only added to the Data tab if not already mapped to a field. As an example, there is no need to have a URL both in the URL field and in the Data tab.
- When targeting .NET we now make use of a framework reference to `Microsoft.AspNetCore.App` instead of installing ASP.NET Core NuGet packages. This only applies when using the `Elmah.Io.AspNetCore.ExtensionsLogging` package. When targeting .NET 8 we also install the `Microsoft.Extensions.Logging` in version `8.0.0`.
- Removed old 3.1 samples and added samples for .NET 8.
- Building on .NET 8.
- Newest `Elmah.Io.Client`.
- Upgraded `Microsoft.SourceLink.GitHub` to `8.0.0`.
- Several code improvements after running Sonar checks. This is all internal so no need for code changes are required by you.
