---
title: "Elmah.Io.Log4Net (and Elmah.Io.AspNetCore.Log4Net) 3.2.26"
date: 2019-10-02T09:17:23Z
categories: [Improvement]
slug: elmah-io-log4net-(and-elmah-io-aspnetcore-log4net)-3-2-26-120805
---
There is a [new stable version](https://www.nuget.org/packages/elmah.io.log4net/3.2.36) of the elmah.io appender for log4net. Changes in this version:

- Support for [reserved property names](https://docs.elmah.io/logging-to-elmah-io-from-log4net/#logging-custom-properties).
- New [Elmah.Io.AspNetCore.Log4Net](https://www.nuget.org/packages/Elmah.Io.AspNetCore.Log4Net/) package to include cookies, server variables, etc. when [logging through log4net from ASP.NET Core](https://docs.elmah.io/logging-to-elmah-io-from-log4net/#aspnet-core).
- Performance and stability improvements using the most recent `Elmah.Io.Client` package.

[Documentation](https://docs.elmah.io/logging-to-elmah-io-from-log4net/) has been updated to reflect all recent changes.
