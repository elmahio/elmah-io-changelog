---
title: "Integration with WPF in prerelease"
date: 2022-12-02T10:48:24Z
categories: [New]
slug: integration-with-wpf-in-prerelease-251756
permalink: /integration-with-wpf-in-prerelease-251756/
---

You asked for it. We deliver 😊 There's a new prerelease of support for Windows Presentation Foundation (WPF). The integration is implemented in the [Elmah.Io.Wpf](https://www.nuget.org/packages/Elmah.Io.Wpf/) NuGet package. When installed, simply call the `Init` method to have uncaught exceptions logged in elmah.io:

```csharp
ElmahIoWpf.Init(new ElmahIoWpfOptions
{
    ApiKey = "API_KEY",
    LogId = new Guid("LOG_ID")
});
```

The package already has some nice features like maintaining breadcrumbs, storing WPF properties, and more. To learn more, visit the updated [documentation](https://docs.elmah.io/logging-to-elmah-io-from-wpf/) and check out the [samples](https://github.com/elmahio/Elmah.Io.Wpf/tree/main/samples) for both .NET Framework and .NET 6.
