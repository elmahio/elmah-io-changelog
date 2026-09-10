---
title: "New API endpoints to enable/disable logging"
date: 2021-05-13T07:58:57Z
categories: [New]
slug: new-api-endpoints-to-enable-disable-logging-194845
permalink: /new-api-endpoints-to-enable-disable-logging-194845/
---

We added two new API endpoints to enable/disable logging. The endpoints will turn on and off logging for the specified log in the same way as the toggle on the log settings page.

![image.png](/images/194845/516-81a1bbf34d13a0a86d7f8d24aa9bfdbb37473360.png)

There's a new [prerelease](https://www.nuget.org/packages/Elmah.Io.Client/3.12.18-pre) of the `Elmah.Io.Client` package supporting these endpoints. Once the package is released in stable we will write about it on the changelog. For now, you can either install the prerelease or call the API directly through a `HttpClient` or similar.
