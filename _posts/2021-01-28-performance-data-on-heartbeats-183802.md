---
title: "Performance data on heartbeats"
date: 2021-01-28T19:31:46Z
categories: [Improvement]
slug: performance-data-on-heartbeats-183802
permalink: /performance-data-on-heartbeats-183802/
---

The history modal on heartbeats now shows the runtime of the job logging the heartbeat:

![Performance data on heartbeats](/images/183802/285-494c650aa11daec1f973dd1db70aac5e79dab19b.png)

The new performance metric is already set automatically through the heartbeat integration packages for Hangfire, Azure Functions, and ASP.NET Core. The metric is named `Took` and can be set manually through the API or from code:

```csharp
var stopwatch = new Stopwatch();
stopwatch.Start();
// run job
stopwatch.Stop();
heartbeats.Healthy(
    logId,
    heartbeatId,
    took: stopwatch.ElapsedMilliseconds);
```
