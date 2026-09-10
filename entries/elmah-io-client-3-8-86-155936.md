---
title: "Elmah.Io.Client 3.8.86"
date: 2020-06-23T06:39:31Z
categories: [Improvement]
slug: elmah-io-client-3-8-86-155936
---
We released a new version ([3.8.86](https://www.nuget.org/packages/elmah.io.client/3.8.86)) of the `Elmah.Io.Client` package. The package automatically decorate all log messages containing an exception with type-specific properties like `ParamName` from `ArgumentException`, `FileName` from `FileNotFoundException`, and more.

![param-name.png](/images/155936/646-67f9ef439a0276c7c9f2201f46374c5fecd3df95.png)

All integrations work with this version. You can either upgrade `Elmah.Io.Client` manually or wait for the integration you use to depend on the new version.
