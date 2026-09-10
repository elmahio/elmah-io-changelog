---
title: "Filter to ignore common ASP.NET warnings"
date: 2020-01-09T09:50:57Z
categories: [New]
slug: filter-to-ignore-common-asp-net-warnings-133140
permalink: /filter-to-ignore-common-asp-net-warnings-133140/
---

If you are developing a public-facing ASP.NET, MVC, and/or Web API site, you have experienced warnings from crawlers for sure. While we already provide a filter to ignore log messages caused by crawlers, most crawlers don't identify themselves as one. With the new "Filter Common ASP.NET Warnings" feature, ignoring warnings like `A potentially dangerous Request.Path value was detected from the client (&)` is available through a toggle:

![filter-common-asp-net-warnings.png](/images/133140/529-877f6e512479ec44eda432a5057971a1523fb99c.png)
