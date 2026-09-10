---
title: "Elmah.Io.Functions 4.0.17"
date: 2021-08-18T05:35:01Z
categories: [New]
slug: elmah-io-functions-4-0-17-204495
---
We released a new version ([4.0.17](https://www.nuget.org/packages/Elmah.Io.Functions/4.0.17)) of the `Elmah.Io.Functions` package. The new version includes the following changes:

- Running on the newest version of the new `Elmah.Io.Client` v4 package moving from AutoRest to NSwag.
- Added documentation on filters.
- Record the performance of a heartbeat in the `Took` property (available on the heartbeat history view on elmah.io).

Upgrading from `3.x` to `4.x` may require changes in your code. Check out [Upgrade elmah.io from v3 to v4](https://docs.elmah.io/upgrade-elmah-io-from-v3-to-v4/) for details.
