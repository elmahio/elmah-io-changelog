---
title: "Elmah.Io.Client 5.2.118"
date: 2025-01-06T19:20:51Z
categories: [New]
slug: elmah-io-client-5-2-118-307322
---
We released a new version ([5.2.118](https://www.nuget.org/packages/Elmah.Io.Client/5.2.118)) of the `Elmah.Io.Client` package. The new version fixes a problem with the lifetime of the internal `HttpClient` when adding more integrations to the same project. Like, if you use both `Elmah.Io.AspNetCore` and `Elmah.Io.Extensions.Logging`.

If you are using either `Elmah.Io.Client` version `5.2.114` - `5.2.117` directly or one of the integrations with a dependency of these versions, make sure to install `5.2.118` to avoid errors during dispose of the `HttpClient`. You normally don't need to install `Elmah.Io.Client` manually but you can run with the newest version even though no new minor versions of the integration packages have been released yet.
