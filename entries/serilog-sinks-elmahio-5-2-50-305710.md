---
title: "Serilog.Sinks.ElmahIo 5.2.50"
date: 2024-12-04T13:02:35Z
categories: [New]
slug: serilog-sinks-elmahio-5-2-50-305710
---
We released a new version ([5.2.50](https://www.nuget.org/packages/Serilog.Sinks.ElmahIo/5.2.50)) of the `Serilog.Sinks.ElmahIo` package. The new version includes the following changes:

- Create installation during startup. An installation is a new term on elmah.io and will show up beneath the *Active installs* folder on the log settings page. More info [here](https://changelog.elmah.io/new-active-installs-page-304986).
- Use the new `OnMessageFilter` event from `Elmah.Io.Client`.
- Building and testing on .NET 9. Also added a new .NET 9 sample.
- Newest `Elmah.Io.Client`.
- General code improvements by fixing all code suggestions.
