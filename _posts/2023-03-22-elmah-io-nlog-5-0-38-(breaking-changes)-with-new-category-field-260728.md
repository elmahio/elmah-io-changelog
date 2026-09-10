---
title: "Elmah.Io.NLog 5.0.38 (breaking changes) with new Category field"
date: 2023-03-22T11:37:28Z
categories: [New]
slug: elmah-io-nlog-5-0-38-(breaking-changes)-with-new-category-field-260728
permalink: /elmah-io-nlog-5-0-38-(breaking-changes)-with-new-category-field-260728/
---

We released a new version ([5.0.38](https://www.nuget.org/packages/Elmah.Io.NLog/5.0.38)) of the `Elmah.Io.NLog` NuGet package. The jump in major version indicates that there could be issues in your code that needs to be fixed after upgrading. The new version includes the following changes:

- This new version is dependent on NLog >= 5.0.1. v5 of NLog introduces some new concepts and general cleanup.
- Removed obsolete `Application` property on the target. Set the application name through the [context](https://docs.elmah.io/logging-to-elmah-io-from-nlog/#setting-application-name) or [OnMessage](https://docs.elmah.io/logging-to-elmah-io-from-nlog/#decorating-log-messages).
- Replaced `mdlc` with `scopeproperty`.
- Console sample for .NET 7.
- `CancellationToken` support.
- Set new Category property from custom properties or NLog logger name.
- Build script modernization, build on .NET 7, and package validation.
- Running on the newest version of `Elmah.Io.Client`.
