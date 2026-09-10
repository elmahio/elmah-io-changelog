---
title: "Experimental support for isolated Azure Functions"
date: 2021-10-15T08:24:16Z
categories: [New]
slug: experimental-support-for-isolated-azure-functions-210405
---
There's a new (experimental) package named `Elmah.Io.Functions.Isolated` for isolated Azure Functions running on .NET 5. Much like the `Elmah.Io.Functions` package, this new package will log all uncaught exceptions happening inside functions and include contextual information (like HTTP headers) not included through Microsoft.Extensions.Logging-based logging. Learn how to get started in the [updated documentation](https://docs.elmah.io/logging-to-elmah-io-from-azure-functions/#isolated-azure-functions-on-net-5) and check out the [samples](https://github.com/elmahio/Elmah.Io.Functions.Isolated/tree/main/samples).
