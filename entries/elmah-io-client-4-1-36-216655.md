---
title: "Elmah.Io.Client 4.1.36"
date: 2021-12-15T07:21:39Z
categories: [New]
slug: elmah-io-client-4-1-36-216655
---
We released a new version ([4.1.36](https://www.nuget.org/packages/Elmah.Io.Client/4.1.36)) of the `Elmah.Io.Client` package. The new version includes the following changes:

- Better support for [AggregateException](https://elmah.io/exceptions/System.AggregateException/).
- Set type to base exception type.
- Added missing documentation on all public.
- Made HttpClient on `IElmahioAPI` and `ElmahioAPI` obsolete. Custom settings should be made through the provided options or a custom `HttpClient` should be provided for the `ElmahioAPI.Create` method.
- UserAgent can now be set through options. You typically don't want to do this manually.
- Include readme in the NuGet package.
- Build on .NET 6.
