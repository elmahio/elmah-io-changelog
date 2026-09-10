---
title: "New major version bump of all integrations in prerelease"
date: 2021-06-23T06:41:00Z
categories: []
slug: new-major-version-bump-of-all-integrations-in-prerelease-197834
permalink: /new-major-version-bump-of-all-integrations-in-prerelease-197834/
---

We have published new prerelease versions of an upcoming major version bump of all integrations. The new integrations will all be version `4.*` and up. The integrations depend on the new `Elmah.Io.Client` [v4 package](https://www.nuget.org/packages/Elmah.Io.Client/4.0.26-pre) which is generated with NSwag instead of AutoRest. We have tried supporting most of the existing code from the v3 package, but some minor code changes may be needed after upgrading. Most upgrades shouldn't cause any problem, but additional help is available right here: [Upgrade elmah.io from v3 to v4](https://docs.elmah.io/upgrade-elmah-io-from-v3-to-v4/).

As always, don't run with prerelease packages in production. These versions are for preview only.
