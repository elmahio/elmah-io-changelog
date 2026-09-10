---
title: "Elmah.Io.Extensions.Logging also supports custom properties"
date: 2018-11-20T07:02:38Z
categories: [New]
slug: elmah-io-extensions-logging-also-supports-custom-properties-80616
---
Like our integrations for NLog and Serilog, [Elmah.Io.Extensions.Logging](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/3.3.32) now also supports custom properties through a set of reserved property names.

Example: I want to set the `User` field on elmah.io using `Microsoft.Extensions.Logging` and structured logging:

```csharp
logger.LogInformation("Hello world from {user}", "Rick Grimes");
```

For more information, check out out the updated [documentation](https://docs.elmah.io/logging-to-elmah-io-from-microsoft-extensions-logging/#decorating-log-messages) and this [sample](https://github.com/elmahio/Elmah.Io.Extensions.Logging/blob/master/samples/Elmah.Io.Extensions.Logging.ConsoleCore2/Program.cs#L21).
