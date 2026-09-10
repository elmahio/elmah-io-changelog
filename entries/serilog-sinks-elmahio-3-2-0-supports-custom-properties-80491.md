---
title: "Serilog.Sinks.ElmahIo 3.2.0 supports custom properties"
date: 2018-11-19T09:57:21Z
categories: [New]
slug: serilog-sinks-elmahio-3-2-0-supports-custom-properties-80491
---
Time for some new features on the elmah.io sink for Serilog. Using the recent version ([available on NuGet](https://www.nuget.org/packages/Serilog.Sinks.ElmahIO/3.2.0)), fields on elmah.io can be set using a range of reserved keywords.

Example: I want to set the `URL`, `Method` and `Status Code` fields on elmah.io, using Serilog structured data:

```csharp
Log.Information("Request to {method} {url} returned {statusCode}",
    "GET, "/home/index", 500);
```

For more information, check out the updated [documentation](https://docs.elmah.io/logging-to-elmah-io-from-serilog/#logging-custom-properties) and this [sample](https://github.com/serilog/serilog-sinks-elmahio/blob/master/examples/Serilog.Sinks.ElmahIo.Example/Program.cs#L46).
