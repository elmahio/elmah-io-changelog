---
title: "Serilog.Sinks.ElmahIo 3.3.0-pre3"
date: 2019-07-25T10:54:12Z
categories: [Improvement]
slug: serilog-sinks-elmahio-3-3-0-pre3-110357
permalink: /serilog-sinks-elmahio-3-3-0-pre3-110357/
---

We just published [a prerelease](https://www.nuget.org/packages/Serilog.Sinks.ElmahIo/3.3.0-pre3) of a new elmah.io sink for Serilog. There are two improvements available in the new version:

**Periodic batching**

Messages are sent to elmah.io asynchronously and in intervals. Posting and storing messages in batches too, is something we are working on for a future version. The behavior can be configured to your needs (see below).

**Options pattern and hooks**

Using the same options pattern as seen in other sinks, the elmah.io sink now supports a range of new settings and hooks:

```csharp
Log.Logger =
    new LoggerConfiguration()
        .WriteTo.ElmahIo(new ElmahIoSinkOptions("API_KEY", new Guid("LOG_ID"))
        {
            BatchPostingLimit = 50,
            MinimumLogEventLevel = LogEventLevel.Warning,
            Period = TimeSpan.FromSeconds(2),
            OnMessage = msg =>
            {
                msg.Data.Add(new Elmah.Io.Client.Models.Item("Hello", "World"));
            },
            OnFilter = msg =>
            {
                return msg.StatusCode == 404;
            },
            OnError = (msg, ex) =>
            {
                Console.Error.WriteLine(ex.Message);
            }
        })
        .CreateLogger();
```

Documentation will be fully updated before launching the stable version.
