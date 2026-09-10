---
title: "Elmah.Io.Log4Net 5.2.39"
date: 2024-12-04T12:56:40Z
categories: [New]
slug: elmah-io-log4net-5-2-39-305708
---
We released a new version ([5.2.39](https://www.nuget.org/packages/Elmah.Io.Log4Net/5.2.39)) of the `Elmah.Io.Log4Net` package. The new version includes the following changes:

- Create installation during startup. An installation is a new term on elmah.io and will show up beneath the *Active installs* folder on the log settings page. More info [here](https://changelog.elmah.io/new-active-installs-page-304986).
- Log errors during log message creation to internal log (`LogLog`).
- Building and testing on .NET 9. Also added a new .NET 9 sample.
- Newest `Elmah.Io.Client`.
- General code improvements by fixing all code suggestions.
