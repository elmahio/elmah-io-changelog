---
title: "Elmah.Io.Client 5.1.75"
date: 2024-05-15T07:30:17Z
categories: [New]
slug: elmah-io-client-5-1-75-292777
---
We released a new version ([5.1.75](https://www.nuget.org/packages/Elmah.Io.Client/5.1.75)) of the `Elmah.Io.Client` package. The new version includes the following changes:

- New `searchAfter` parameter added to the `GetAll` and `GetAllAsync` methods when searching for log messages. The `searchAfter` parameter can be used as an alternative to `pageIndex` to fetch more than 10,000 log messages from a log. For details about the `searchAfter` parameter, you can read through this article: https://docs.elmah.io/using-the-rest-api/#searching-messages.
- Added `Color`, `EnvironmentName`, and `Disabled` properties on the `CreateLog` class. This will allow you to set these properties from C# rather than having to set them through the UI.
- Added `Checks` to heartbeats. With this change, you can split up a heartbeat into multiple checks with individual statuses. Checks will show up in the elmah.io UI when available on the heartbeat. Our client integrations that automatically store heartbeats will automatically start using checks when new versions are released. For details about Checks, you can read through this article: https://docs.elmah.io/setup-heartbeats/#checks.
- The sample applications have been upgraded to .NET 8.
- Upgraded the dependency of `Newtonsoft.Json` to `13.0.3` when targeting .NET 8 or newer. No matter what version of .NET you are targeting, we recommend installing version `13.0.3` manually to avoid known vulnerabilities in version 10.
- Building on .NET 8.
- Upgraded `Microsoft.SourceLink.GitHub` to `8.0.0`.
- Several code improvements after running Sonar checks. This is all internal so no need for code changes are required by you.

Unless you are using the `Elmah.Io.Client` package directly, there is no need to upgrade manually since the upcoming client integration versions will all install this package version.
