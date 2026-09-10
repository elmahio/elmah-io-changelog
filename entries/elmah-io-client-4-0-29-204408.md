---
title: "Elmah.Io.Client 4.0.29"
date: 2021-08-17T13:24:05Z
categories: [New]
slug: elmah-io-client-4-0-29-204408
---
We released a new version ([4.0.29](https://www.nuget.org/packages/Elmah.Io.Client/4.0.29)) of the `Elmah.Io.Client` package. The new version includes the following changes:

- Switched from using AutoRest to NSwag to generate client code.
- Support for uploading source maps.
- Support for attaching source code to log messages.
- Fixed exception when setting WebProxy to null in Mono.

`4.0.29` is the foundation for the new series of `4.x` packages. New releases of the client integrations like `Elmah.Io.AspNetCore`, `Serilog.Sinks.ElmahIo`, etc. will be released within the next days/weeks. If you are using a v3 integration, upgrading the `Elmah.Io.Client` to v4 won't work until a `4.x` version of your integration has been released. Also, upgrading from `3.x` to `4.x` may require changes in your code. Check out [Upgrade elmah.io from v3 to v4](https://docs.elmah.io/upgrade-elmah-io-from-v3-to-v4/) for details.
