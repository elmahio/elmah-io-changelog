---
title: "Elmah.Io.Umbraco 5.0.27"
date: 2023-07-24T10:51:43Z
categories: [New]
slug: elmah-io-umbraco-5-0-27-270201
---
We released a new version ([5.0.27](https://www.nuget.org/packages/Elmah.Io.Umbraco/5.0.27)) of the `Elmah.Io.Umbraco` package. This is a major version upgrade that may need changes in your code after upgrading. The new version includes the following change:

- Running on Umbraco 10 and higher.
- Running on the newest version of `Elmah.Io.Client` with support for [Exception Inspector](https://changelog.elmah.io/announcing-the-new-exception-inspector-265594).
- Running on the newest versions of `Elmah.Io.AspNetCore` and `Serilog.Sinks.ElmahIo`.
- Fixed namespace name of notification method.

Small changes may be needed to upgrade from 4.x to 5.x. Check out [Upgrade elmah.io from v4 to v5](https://docs.elmah.io/upgrade-elmah-io-from-v4-to-v5/) for more information.
