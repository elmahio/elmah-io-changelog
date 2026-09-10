---
title: "Azure Functions client changes"
date: 2017-12-19T07:14:18Z
categories: [New]
slug: azure-functions-client-changes-44375
permalink: /azure-functions-client-changes-44375/
---

The client for Azure Functions/WebJobs ([https://github.com/elmahio/Elmah.Io.Functions](https://github.com/elmahio/Elmah.Io.Functions)) has been updated with new properties. The function name is set as application name, to support function apps with multiple functions. The assembly source of the original exception, is set as source, to align with the other client integrations:

![elmahiofunctions.png](/images/44375/925-34acdaf71c863df1002ccfb3dd2ef59f059288a5.png)

Please upgrade to [3.0.15-pre](https://www.nuget.org/packages/Elmah.Io.Functions/3.0.15-pre).
