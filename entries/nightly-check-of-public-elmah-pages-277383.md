---
title: "Nightly check of public ELMAH pages"
date: 2023-10-23T10:11:58Z
categories: [New]
slug: nightly-check-of-public-elmah-pages-277383
---
We still see users accidentally publishing their ELMAH endpoints to the public ([here's](https://www.troyhunt.com/aspnet-session-hijacking-with-google/) why you don't want that). That is the simple error browser on `/elmah.axd` or `/elmah` the open-source library ELMAH provides when logging to elmah.io from ASP.NET. To help take action if this happens we have extended uptime checks with a toggle to check this nightly. If we find a public ELMAH page we will log an error in your log.

![Nightly check of public ELMAH pages](/images/277383/832-3a4d93e3f40228757989ec946e1cd08137f28d55.png)

The feature is available on Enterprise plans and only makes sense to enable if you are logging from Webforms, MVC (not ASP.NET Core MVC), or Web API.
