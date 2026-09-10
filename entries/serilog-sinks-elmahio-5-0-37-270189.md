---
title: "Serilog.Sinks.ElmahIo 5.0.37"
date: 2023-07-24T09:06:06Z
categories: [New]
slug: serilog-sinks-elmahio-5-0-37-270189
---
We released a new version ([5.0.37](https://www.nuget.org/packages/Serilog.Sinks.ElmahIo/5.0.37)) of the `Serilog.Sinks.ElmahIo` and `Elmah.Io.AspNetCore.Serilog` packages. This is a major version upgrade that may need changes in your code after upgrading. The new version includes the following changes:

- Running on Serilog 3.
- Running on the newest version of `Elmah.Io.Client` with support for [Exception Inspector](https://changelog.elmah.io/announcing-the-new-exception-inspector-265594).
- Removed obsolete methods.
- Config examples in ASP.NET Core 6.0 sample.

Small changes may be needed to upgrade from 4.x to 5.x. Check out [Upgrade elmah.io from v4 to v5](https://docs.elmah.io/upgrade-elmah-io-from-v4-to-v5/) for more information.
