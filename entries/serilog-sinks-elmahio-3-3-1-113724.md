---
title: "Serilog.Sinks.ElmahIo 3.3.1"
date: 2019-08-20T10:51:46Z
categories: [Improvement]
slug: serilog-sinks-elmahio-3-3-1-113724
---
We released a [stable version](https://www.nuget.org/packages/Serilog.Sinks.ElmahIO/3.3.1) of the elmah.io sink for Serilog. Improvements include periodic batching and a new options pattern to allow message hooks. Check out the updated [documentation](https://docs.elmah.io/logging-to-elmah-io-from-serilog/) for details.

Please notice a breaking change from `3.2.x` to `3.3.x`. The API key and log ID now needs to be specified using the new `ElmahIoSinkOptions` object:

```csharp
var log =
    new LoggerConfiguration()
        .WriteTo.ElmahIo(new ElmahIoSinkOptions("API_KEY", new Guid("LOG_ID")))
        .CreateLogger();
```
