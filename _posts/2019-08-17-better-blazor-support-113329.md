---
title: "Better Blazor support"
date: 2019-08-17T19:35:59Z
categories: [Improvement]
slug: better-blazor-support-113329
permalink: /better-blazor-support-113329/
---

We have discontinued the `Elmah.Io.Blazor` package in exchange for a better solution when needing to log from Blazor to elmah.io. The [documentation](https://docs.elmah.io/logging-to-elmah-io-from-blazor/) has been updated with the new approach, but in short, you will need to install the following NuGet packages:

```powershell
Install-Package Blazor.Extensions.Logging
Install-Package Elmah.Io.Extensions.Logging
```

And then add logging as you would in any other ASP.NET Core application:

```csharp
namespace MyBlazorApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(builder => builder
                .AddElmahIo(options =>
                {
                    options.ApiKey = "API_KEY";
                    options.LogId = new Guid("LOG_ID");
                })
            );
        }
    }
}
```
