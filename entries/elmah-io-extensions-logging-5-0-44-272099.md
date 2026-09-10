---
title: "Elmah.Io.Extensions.Logging 5.0.44"
date: 2023-08-17T12:15:21Z
categories: [New]
slug: elmah-io-extensions-logging-5-0-44-272099
---
We released a new version ([5.0.44](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/5.0.44)) of the `Elmah.Io.Extensions.Logging` and `Elmah.Io.AspNetCore.ExtensionsLogging` packages. The new version includes the following change:

- Fixed a bug where calling `AddElmahIo` on `ILoggerFactory` without an options object would cause a null ref.
