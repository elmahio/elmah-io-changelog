---
title: "Elmah.Io.AspNetCore 3.7.72-pre"
date: 2019-04-25T07:01:55Z
categories: [Improvement]
slug: elmah-io-aspnetcore-3-7-72-pre-98879
---
We've refactored some of the internals of the `Elmah.Io.AspNetCore` NuGet package. This materialized in a prerelease of the `3.7.x` version, which will be released in a month or two.

`3.7.x` has been heavily optimized by re-using internal resources (like `HttpClientHandler`) and by queueing up messages for later processing. These changes should make logging to elmah.io from your ASP.NET Core applications much faster. Also, failing actions will no longer result in delayed response times for showing an error page to your users (because of the new queue architecture).

`3.7.72-pre` is [available on NuGet](https://www.nuget.org/packages/Elmah.Io.AspNetCore/). As usual, we would love for you to try it out and get back to us with feedback.
