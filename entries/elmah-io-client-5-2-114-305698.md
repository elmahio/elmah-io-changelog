---
title: "Elmah.Io.Client 5.2.114"
date: 2024-12-04T12:16:00Z
categories: [New]
slug: elmah-io-client-5-2-114-305698
---
We released a new version ([5.2.114](https://www.nuget.org/packages/Elmah.Io.Client/5.2.114)) of the `Elmah.Io.Client` package. The new version includes the following changes:

- There's a new `OnMessageFilter` event available on messages. This event is similar to the one from some of the other packages and can be used to ignore log messages based on code of your choice.
- Use the `_OR_GREATER` directives to target more supported frameworks. This means that more .NET versions will include additional information in the Inspector.
- New `Delete` and `DeleteAsync` methods to delete a log by its ID. Only empty logs can be deleted.
- New methods for creating installations. An installation is a new term on elmah.io and will show up beneath the *Active installs* folder on the log settings page. More info [here](https://changelog.elmah.io/new-active-installs-page-304986).
- Dispose previous instance of `HttpClientHandler` when renewing.
- Building and testing on .NET 9.
- General code improvements by fixing all code suggestions.
