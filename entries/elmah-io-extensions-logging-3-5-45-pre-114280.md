---
title: "Elmah.Io.Extensions.Logging 3.5.45-pre"
date: 2019-08-23T06:52:20Z
categories: [Improvement]
slug: elmah-io-extensions-logging-3-5-45-pre-114280
---
If you are following this changelog, you may have spotted a trend already. That's right, we are currently giving our client integrations some love. Today, we have [published](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/3.5.45-pre) a major update to the integration with `Microsoft.Extensions.Logging`.

The updated version contains the following changes:

- Batch logging will store messages in an internal queue for better performance and to minimize the impact on your application when logging many messages.
- Use the new elmah.io bulk API to upload messages in bulk.
- Updated to `Microsoft.Extensions.Logging` version `2.2.0` and `netstandard 2.0`.
- Performance and stability improvements using the most recent `Elmah.Io.Client`.
