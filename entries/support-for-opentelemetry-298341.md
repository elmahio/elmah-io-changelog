---
title: "Support for OpenTelemetry"
date: 2024-08-07T11:15:40Z
categories: [New]
slug: support-for-opentelemetry-298341
---
There's a new (experimental) integration with OpenTelemetry that allows for logging messages from OpenTelemetry to elmah.io. The integration can be installed from NuGet using the `Elmah.Io.OpenTelemetry` package and a custom exporter:

```csharp
builder.Logging.AddOpenTelemetry(options =>
{
    options.AddElmahIoExporter(options =>
    {
        options.ApiKey = "API_KEY";
        options.LogId = new Guid("LOG_ID");
    });
});
```

Check out the [documentation](https://docs.elmah.io/logging-to-elmah-io-from-opentelemetry/) for details.
