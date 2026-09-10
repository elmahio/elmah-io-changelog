---
title: "Elmah.Io.Extensions.Logging 3.5.49"
date: 2019-09-17T07:52:14Z
categories: [Improvement]
slug: elmah-io-extensions-logging-3-5-49-117716
permalink: /elmah-io-extensions-logging-3-5-49-117716/
---

The stable version of [Elmah.Io.Extensions.Logging](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/3.5.49) 3.5.x is finally here. The release includes major performance improvements, and we recommend everyone to upgrade.

3.5.x contains the following changes:

- Support for the new `TitleTemplate` field which makes structured log message templates searchable through the elmah.io UI.
- Batch logging will store messages in an internal queue for better performance and to minimize the impact on your application when logging many messages.
- Use the new elmah.io bulk API to upload messages in bulk.
- Updated to Microsoft.Extensions.Logging version 2.2.0 and netstandard 2.0.
- Performance and stability improvements using the most recent Elmah.Io.Client.
- Support for logging through a web proxy.
- Improved internal use of HttpClient.
- Show full exception name in the Error field on elmah.io.

[Documentation](https://docs.elmah.io/logging-to-elmah-io-from-microsoft-extensions-logging/) has been updated to reflect all recent changes.
