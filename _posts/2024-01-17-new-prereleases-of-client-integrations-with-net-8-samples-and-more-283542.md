---
title: "New prereleases of client integrations with .NET 8 samples and more"
date: 2024-01-17T09:22:21Z
categories: [New]
slug: new-prereleases-of-client-integrations-with-net-8-samples-and-more-283542
permalink: /new-prereleases-of-client-integrations-with-net-8-samples-and-more-283542/
---

We've had a few questions about elmah.io and .NET 8 so I'll post a quick update here. All of our client integrations support .NET 8 in the recent stable versions. There are new prereleases of all integrations and most of them contain a .NET 8 sample (like [the one for `Elmah.Io.AspNetCore` here](https://github.com/elmahio/Elmah.Io.AspNetCore/tree/main/samples/Elmah.Io.AspNetCore80.Example)).

The new prerelease of `Elmah.Io.Client` for .NET 8 requires `Newtonsoft.Json` version `13.0.3` so make sure to update that package. Once NSwag (the library we use to generate the client) moves to `System.Text.Json` we will move the client over as well. This will be done in a new major version since there may be breaking changes.
