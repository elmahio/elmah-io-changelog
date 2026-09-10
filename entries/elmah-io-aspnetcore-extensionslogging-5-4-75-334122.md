---
title: "Elmah.Io.AspNetCore.ExtensionsLogging 5.4.75"
date: 2026-03-19T07:39:04Z
categories: [New]
slug: elmah-io-aspnetcore-extensionslogging-5-4-75-334122
---
We released a new version ([5.4.75](https://www.nuget.org/packages/Elmah.Io.AspNetCore.ExtensionsLogging/5.4.75)) of the `Elmah.Io.AspNetCore.ExtensionsLogging` package. The new version includes the following changes:

- Added new extension methods and attributes for enabling multipart body logging and disabling form logging entirely: `EnableElmahIoMultipartBodyLogging` and `DisableElmahIoFormLogging`. Thanks to pagefault for creating [this PR](https://github.com/elmahio/Elmah.Io.Extensions.Logging/pull/8).

The [documentation](https://docs.elmah.io/logging-to-elmah-io-from-microsoft-extensions-logging/#include-http-context) has been updated to reflect the latest changes.
