---
title: "Support for Microsoft.Extensions.Logging v2"
date: 2018-03-16T06:04:46Z
categories: [New]
slug: support-for-microsoft-extensions-logging-v2-53356
permalink: /support-for-microsoft-extensions-logging-v2-53356/
---

When launching Microsoft.Extensions.Logging v2, Microsoft switched to a new way of configuring logging. Our provider now supports the new set of API's, which makes it possible to configure logging from Microsoft.Extensions.Logging to elmah.io like this (in `Program.cs` not `Startup.cs`):

```csharp
WebHost.CreateDefaultBuilder(args)
    .UseStartup<Startup>()
    .ConfigureLogging((ctx, logging) =>
    {
        logging.AddElmahIo(options =>
        {
            options.ApiKey = "API_KEY";
            options.LogId = new Guid("LOG_ID");
        });
        logging.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);
    })
.Build();
```

If you're already using the provider, you may notice that we now support the options API too. Setting up logging using the `ConfigureLogging`-method, ensures that log statements in the entire application are sent to elmah.io.

The [documentation](https://docs.elmah.io/logging-to-elmah-io-from-microsoft-extensions-logging/) has been updated and there are [two new .NET Core 2.x samples](https://github.com/elmahio/Elmah.Io.Extensions.Logging/tree/master/samples) to try out.
