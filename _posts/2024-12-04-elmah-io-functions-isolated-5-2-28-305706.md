---
title: "Elmah.Io.Functions.Isolated 5.2.28"
date: 2024-12-04T12:52:23Z
categories: [New]
slug: elmah-io-functions-isolated-5-2-28-305706
permalink: /elmah-io-functions-isolated-5-2-28-305706/
---

We released a new version ([5.2.28](https://www.nuget.org/packages/Elmah.Io.Functions.Isolated/5.2.28)) of the `Elmah.Io.Functions.Isolated` package. The new version includes the following changes:

- Create installation during startup. An installation is a new term on elmah.io and will show up beneath the *Active installs* folder on the log settings page. More info [here](https://changelog.elmah.io/new-active-installs-page-304986).
- Use the new `OnMessageFilter` event from `Elmah.Io.Client`.
- Fixed a bug where GrpcHttpRequestData tries to create an Uri from an empty string.
- Building and testing on .NET 9. Also added a new .NET 9 sample.
- Newest `Elmah.Io.Client`.
- General code improvements by fixing all code suggestions.
