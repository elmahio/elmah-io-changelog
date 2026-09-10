---
title: "Additional information on failing endpoints"
date: 2019-12-11T12:08:37Z
categories: [Improvement]
slug: additional-information-on-failing-endpoints-130461
---
We've extended elmah.io Uptime Monitoring to log additional information when an endpoint doesn't generate a response. Rather than just printing the exception thrown by the `HttpClient` we use internally, we now inspect the error and generate a better error message:

![Uptime error](/images/130461/577-4cbb7ee432c2d76837ad94c3718c7ea779bffe72.png)
