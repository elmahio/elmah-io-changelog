---
title: "Elmah.Io.Client 3.9.90"
date: 2020-08-12T12:59:40Z
categories: [Improvement]
slug: elmah-io-client-3-9-90-163886
---
We released a new version ([3.9.90](https://www.nuget.org/packages/elmah.io.client/3.9.90)) of the `Elmah.Io.Client` package. This version includes the following changes:

- Rebuild against the newest version of our API, adding C# support for all of the new endpoints. We had to change some parameter names which could introduce a compile problem after upgrading. That should only happen if you have used named arguments when using the client. Get in contact if you need help migrating any errors.
- Support for [AggregateException](https://elmah.io/exceptions/System.AggregateException/). Previously, the data list generated from a logged exception would only contain one of the inner exceptions in a thrown `AggregateException`. This version iterates the entire tree of aggregates and collects all properties and exception-specific information.

All integrations work with this version. You can either upgrade `Elmah.Io.Client` manually or wait for the integration you use to depend on the new version.
