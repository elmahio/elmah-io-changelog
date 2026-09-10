---
title: "Elmah.Io.AspNetCore.Serilog 3.0.3"
date: 2019-11-21T09:18:30Z
categories: [New]
slug: elmah-io-aspnetcore-serilog-3-0-3-128142
permalink: /elmah-io-aspnetcore-serilog-3-0-3-128142/
---

There's a new [package](https://www.nuget.org/packages/Elmah.Io.AspNetCore.Serilog/) available for ASP.NET Core and Serilog. If you are logging to elmah.io using Serilog from ASP.NET Core, you may have noticed that HTTP contextual information like the current URL, status code, server variables aren't logged. That's because the elmah.io sink isn't HTTP context-aware (nor should it be). To decorate log messages with the HTTP context, you can install the `Elmah.Io.AspNetCore.Serilog` package and configure it as part of the `Startup.cs` file:

```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    ...
    app.UseElmahIoSerilog();
    ...
}
```

The [documentation](https://docs.elmah.io/logging-to-elmah-io-from-serilog/#aspnet-core) is updated to reflect the changes and there's a sample available [here](https://github.com/elmahio/Elmah.Io.AspNetCore.Serilog/tree/master/samples/Elmah.Io.AspNetCore.Serilog.AspNetCore22).
