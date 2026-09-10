---
title: "Use a proxy with ASP.NET Core and elmah.io"
date: 2018-01-08T11:47:05Z
categories: [New]
slug: use-a-proxy-with-asp-net-core-and-elmah-io-46098
---
Since ASP.NET Core no longer support proxy configuration through `web.config`, you can log to elmah.io by configuring a proxy manually:

```csharp
var settings = new ElmahIoSettings();
settings.WebProxy = new System.Net.WebProxy("localhost", 8888);
app.UseElmahIo("API_KEY", new Guid("LOG_ID"), settings);
```

[Documentation](https://docs.elmah.io/logging-to-elmah-io-from-aspnet-core/#logging-through-a-proxy) has been updated. We also extended the proxy documentation for ASP.NET/MVC/Web API: [Logging through a HTTP proxy](https://docs.elmah.io/logging-through-a-http-proxy/).
