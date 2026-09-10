---
title: "Elmah.Io.Extensions.Logging 3.6.30"
date: 2020-01-20T19:25:00Z
categories: [Improvement]
slug: elmah-io-extensions-logging-3-6-30-134311
---
We released a new version ([3.6.60](https://www.nuget.org/packages/Elmah.Io.Extensions.Logging/3.6.60)) of the `Elmah.Io.Extensions.Logging` package (our integration with Microsoft.Extensions.Logging). Here are the included new features and bugfixes:

- Support for log scopes.
- Support for Azure Functions.
- New `Elmah.Io.AspNetCore.ExtensionsLogging` package (see later)
- Newest elmah.io.client.
- Fixed a bug on Dispose.
- New ASP.NET Core 3.x samples.

I want to put a few words on the new `Elmah.Io.AspNetCore.ExtensionsLogging` package. As the name implies, the package improves logging through Microsoft.Extensions.Logging from ASP.NET Core web applications. You may have already noticed that messages logged through Microsoft.Extensions.Logging doesn't include the usual HTTP context variables like HTTP method, cookies and server variables. With the new package, including the HTTP context on messages logged through Microsoft.Extensions.Logging can be easily set up in ASP.NET Core by installing the new middleware:

```csharp
public void Configure(IApplicationBuilder app, ...)
{
    ... // Exception handling middleware
    app.UseElmahIoExtensionsLogging();
    ... // UseMvc etc.
}
```
