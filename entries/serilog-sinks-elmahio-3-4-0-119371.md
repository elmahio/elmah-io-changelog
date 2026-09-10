---
title: "Serilog.Sinks.ElmahIo 3.4.0"
date: 2019-09-20T06:01:50Z
categories: [Improvement]
slug: serilog-sinks-elmahio-3-4-0-119371
---
There is a [new stable version](https://www.nuget.org/packages/Serilog.Sinks.ElmahIO/3.4.0) of the elmah.io sink for Serilog. Changes in this version:

- Support for [Message Template](https://blog.elmah.io/structured-logging-vnext/).
- The sink is now 100% async.
- Decorate log messages with server variables, cookies, etc.
- Performance and stability improvements using the most recent `Elmah.Io.Client` package.
- New sample for ASP.NET Core.

[Documentation](https://docs.elmah.io/logging-to-elmah-io-from-serilog/) has been updated to reflect all recent changes.
