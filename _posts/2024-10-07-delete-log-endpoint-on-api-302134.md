---
title: "Delete log endpoint on API"
date: 2024-10-07T13:32:08Z
categories: [New]
slug: delete-log-endpoint-on-api-302134
permalink: /delete-log-endpoint-on-api-302134/
---

There's a [new endpoint](https://api.elmah.io/swagger/index.html#/Logs/Logs_Delete) available on the API to delete a log. Deleting a log requires the new *Delete log* permission available on the edit API key view on elmah.io. Only empty logs can be deleted through the API so make sure to clear it first through either the UI or the delete messages endpoint.

The delete log endpoint is also available in the [newest prerelease](https://www.nuget.org/packages/Elmah.Io.Client/5.2.98-pre) of the `Elmah.Io.Client` package.

![Delete log endpoint on API](/images/302134/692-24e2991782cd96a7e693e90d7c357e7983bd9672.png)
