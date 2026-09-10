---
title: "Elmah.Io.Client 5.0.66"
date: 2023-07-24T08:03:45Z
categories: [New]
slug: elmah-io-client-5-0-66-270180
---
We released a new version ([5.0.66](https://www.nuget.org/packages/Elmah.Io.Client/5.0.66)) of the `Elmah.Io.Client`, `Elmah.Io.Client.Extensions.SourceCode`, and `Elmah.Io.Client.Extensions.Correlation` packages. This is a major version upgrade that may need changes in your code after upgrading. The new version includes the following changes:

- Include data for the new [Exception Inspector](https://changelog.elmah.io/announcing-the-new-exception-inspector-265594).
- Include information about the current .NET version on log messages.
- Limit iteration to 10 levels of inner exceptions. The stack trace will still include everything.
- Removed obsolete methods.

Small changes may be needed to upgrade from 4.x to 5.x. Check out [Upgrade elmah.io from v4 to v5](https://docs.elmah.io/upgrade-elmah-io-from-v4-to-v5/) for more information.
