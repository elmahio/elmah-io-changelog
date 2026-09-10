---
title: "Elmah.Io.Extensions.Logging 4.2.36 with synchronous logging"
date: 2022-12-20T07:32:58Z
categories: [New]
slug: elmah-io-extensions-logging-4-2-36-with-synchronous-logging-253258
permalink: /elmah-io-extensions-logging-4-2-36-with-synchronous-logging-253258/
---

We released a new version ([4.2.36](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/4.2.36)) of the `Elmah.Io.Extensions.Logging` NuGet package. The new version includes the following changes:

- New `Synchronous` option to disable async logging (don't do this if async logging works).
- Upgraded `Microsoft.Extensions.Logging` to 3.1.x (.NET Core older than 3.1 may still be supported but it's not something we are testing anymore).
- Added documentation on all public methods and classes.
- Build script modernization, build on .NET 7, and package validation.
- Upgraded Azure Functions sample to functions runtime v4 on .NET 6.
- Added new samples for ASP.NET Core 7 and console application on .NET 7.
- Running on the newest version of `Elmah.Io.Client`.
