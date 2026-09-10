---
title: "Integration with PoShLog (PowerShell)"
date: 2022-12-15T15:05:58Z
categories: [New]
slug: integration-with-poshlog-(powershell)-252903
permalink: /integration-with-poshlog-(powershell)-252903/
---

There's a new integration with PoShLog. For those of you who may not know PoShLog, it's a PowerShell logging module built on top of Serilog. The elmah.io sink for PoShLog brings easy logging to elmah.io from PowerShell using code like this:

```powershell
Import-Module PoShLog
Import-Module PoShLog.Sinks.ElmahIo

New-Logger |
    Add-SinkElmahIo -ApiKey 'API_KEY' -LogId 'LOG_ID' |
    Start-Logger

Write-ErrorLog 'Say My Name'
```

The integration is available in the [PowerShell Gallery](https://www.powershellgallery.com/packages/PoShLog.Sinks.ElmahIo/4.0.4) and documented on [Logging to elmah.io from PowerShell](https://docs.elmah.io/logging-to-elmah-io-from-powershell/).
