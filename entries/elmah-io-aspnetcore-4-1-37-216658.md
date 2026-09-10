---
title: "Elmah.Io.AspNetCore 4.1.37"
date: 2021-12-15T07:43:07Z
categories: [New]
slug: elmah-io-aspnetcore-4-1-37-216658
---
We released a new version ([4.1.37](https://www.nuget.org/packages/Elmah.Io.AspNetCore/4.1.37)) of the `Elmah.Io.AspNetCore` package. The new version includes the following changes:

- Running on the newest version of the `Elmah.Io.Client` package.
- Log exception happening while dequeue and execute tasks to Microsoft.Extensions.Logging.
- Override `StopAsync` on hosted services to await any active work items.
- Call the `OnMessage` action before putting the error on the queue to allow for accessing the HTTP context while decorating messages.
- Include readme in the NuGet package.
- Building on .NET 6 and new .NET 6 sample.
- Generate start and end tag for script element in tag helper.
- Newest `elmah.io.javascript` installed in tag helper.
