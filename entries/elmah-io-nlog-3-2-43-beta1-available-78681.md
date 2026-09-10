---
title: "Elmah.Io.NLog 3.2.43-beta1 available"
date: 2018-11-05T11:22:18Z
categories: [New]
slug: elmah-io-nlog-3-2-43-beta1-available-78681
---
This may sound boring, but actually, it isn't. [3.2.x](https://www.nuget.org/packages/elmah.io.nlog/3.2.43-beta1) of our integration for NLog supports full control of all of the message fields available on elmah.io. Custom fields like `User`, `Source`, `Url` and `StatusCode`, can be set using NLog's structured logging:

```csharp
log.Info("{user} says: {quote}",
    "Arnold Schwarzenegger", "Hasta la vista, baby");
```

In the example above, the `User` field on elmah.io, is automatically set to `Arnold Schwarzenegger`.

This is currently an experiment for NLog only. If turning out as a success, a similar feature will be rolled out to other logging framework integrations (like Serilog and Microsoft.Extensions.Logging).
