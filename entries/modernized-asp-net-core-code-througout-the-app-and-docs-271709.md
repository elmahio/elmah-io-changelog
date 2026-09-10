---
title: "Modernized ASP.NET Core code througout the app and docs"
date: 2023-08-11T08:49:58Z
categories: [Improvement]
slug: modernized-asp-net-core-code-througout-the-app-and-docs-271709
---
With ASP.NET Core 6 being almost two years old and 3.1 ending support last year, we have decided to move to the new configuration syntax for the documentation site and the docs inlined on app.elmah.io. This means that only a few docs contain references to the old syntax where ASP.NET Core where configured in a `Startup.cs` file with `Configure` and `ConfigureServices` methods.

As the only document, the [Elmah.Io.AspNetCore instructions](https://docs.elmah.io/logging-to-elmah-io-from-aspnet-core/) still have some examples of using the old syntax. But everything else has been ported to showcase the new syntax. Your websites are not required to use top-level statements to use the new syntax. Let us know if anything is unclear with the new code samples and we will consider to include some legacy configuration examples if needed. We still provide multiple samples for ASP.NET Core 3.1 (like [this one](https://github.com/elmahio/Elmah.Io.AspNetCore/tree/main/samples)) in case you need it.
