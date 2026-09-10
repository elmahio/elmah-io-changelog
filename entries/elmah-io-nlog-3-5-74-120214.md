---
title: "Elmah.Io.NLog 3.5.74"
date: 2019-09-27T06:07:44Z
categories: [Improvement]
slug: elmah-io-nlog-3-5-74-120214
---
There is a [new stable version](https://www.nuget.org/packages/elmah.io.nlog/3.5.74) of the elmah.io target for NLog. Changes in this version:

- Support for [Message Template](https://blog.elmah.io/structured-logging-vnext/).
- Decorate log messages with server variables, cookies, etc. when using correct property naming or by including either `NLog.Web` or `NLog.Web.AspNetCore`.
- Performance and stability improvements using the most recent `Elmah.Io.Client` package.
- Updated to version 4.6.7 of the `NLog` package.

[Documentation](https://docs.elmah.io/logging-to-elmah-io-from-nlog/) has been updated to reflect all recent changes.
