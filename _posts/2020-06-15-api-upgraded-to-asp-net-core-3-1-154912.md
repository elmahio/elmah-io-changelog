---
title: "API upgraded to ASP.NET Core 3.1"
date: 2020-06-15T18:26:29Z
categories: [Improvement]
slug: api-upgraded-to-asp-net-core-3-1-154912
permalink: /api-upgraded-to-asp-net-core-3-1-154912/
---

We upgraded the API from ASP.NET Core 2.2 to 3.1. The upgrade should have been transparent for all clients but caused a JSON serialization problem when calling the API directly from `HttpClient` or similar. The issue has now been fixed. Integrations using the Elmah.Io.Client package shouldn't have been affected by the upgrade.
