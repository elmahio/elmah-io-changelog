---
title: "Config variable support for Functions and WebJobs"
date: 2018-02-17T19:20:05Z
categories: [Improvement]
slug: config-variable-support-for-functions-and-webjobs-50378
permalink: /config-variable-support-for-functions-and-webjobs-50378/
---

Our integration for Azure Functions and WebJobs (available here: [Elmah.Io.Functions](https://www.nuget.org/packages/Elmah.Io.Functions/3.0.18-pre), now has the abillity to pull API key and log ID from settings:

Rather than hard-coding config variables in C#, use pointers to your `settings.json` or `App.config` files:

```csharp
[ElmahIoExceptionFilter("%apiKey%", "%logId%")]
```

The actual values should be added in your configuration file:

```json
{
  "Values": {
    "apiKey": "API_KEY",
    "logId": "LOG_ID"
  }
}
```
