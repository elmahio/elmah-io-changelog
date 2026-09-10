---
title: "Better parsing and visualization of user agents"
date: 2019-09-09T08:33:39Z
categories: [Improvement]
slug: better-parsing-and-visualization-of-user-agents-116625
---
An improved user agent parsing and visualization have been released.

**Parser improvements**

We parse the user agent (if there) on all logged messages and make it possible to search by browser (and soon OS too). The implementation has been migrated from a homemade solution to use UAParser. Parsing a user agent seems easy but believe me, it's not. Moving to something like UAParser will eliminate a lot of the browser misses we have experienced in the past.

**Visual improvements**

Previously, there was a small browser and os button as part of the toolbar when opening the error details. We have removed this in favor of the graphical representation already known from client-side logging. With this, you will see an instant view of the device causing an error as well as which OS and Browser the user is running:

![Device view](/images/116625/968-73f4cb7fc1c56f978c4c5cfb861f28eacb3abbc8.png)

When hovering the control, you will be able to click a *Details* button to see more information:

![useragent modal](/images/116625/969-b2c04f88661458dfd011b38db6d5eacd09bdd86e.png)
