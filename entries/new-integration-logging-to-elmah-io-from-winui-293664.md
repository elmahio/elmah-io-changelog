---
title: "New integration: Logging to elmah.io from WinUI"
date: 2024-05-28T06:59:36Z
categories: [New]
slug: new-integration-logging-to-elmah-io-from-winui-293664
---
There's a new experimental integration for logging from WinUI to elmah.io. The integration can be added through NuGet:

```shell
dotnet add package Elmah.Io.WinUI --prerelease
```

And set up using a single line of code:

```csharp
ElmahIoWinUI.Init(new ElmahIoWinUIOptions("API_KEY", new Guid("LOG_ID")));
```

All uncaught errors are now logged to elmah.io:

![Logging to elmah.io from WinUI](/images/293664/213-3ecd7787d818779da5dc114cbc55f2c5b2c8a1fa.png)

Full documentation available here: [Logging to elmah.io from WinUI](https://docs.elmah.io/logging-to-elmah-io-from-winui/)
