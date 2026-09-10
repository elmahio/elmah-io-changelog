---
title: "New prereleases of all packages"
date: 2021-10-14T05:34:59Z
categories: [Improvement]
slug: new-prereleases-of-all-packages-210281
---
New prereleases have been published for all client integrations available on [GitHub](https://github.com/elmahio) and [NuGet](https://www.nuget.org/profiles/elmah.io). A lot of good stuff goes into the new version like extended documentation and better handling of [AggregateException](https://elmah.io/exceptions/System.AggregateException/).

We have also started the work on improving the use of the embedded `HttpClient` within the client. The new versions will start marking the `HttpClient` property on `IElmahioAPI` and `ElmahioAPI` as obsolete. If you are currently using this property in your code, reach out to get help migrating.

As usual, we will write individual changelogs once each package is released as stable. For now, feel free to start playing with the new versions, but remember the `prerelease` tag 😉
