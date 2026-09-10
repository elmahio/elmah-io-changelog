---
title: "Group by Message Template"
date: 2019-09-18T14:50:39Z
categories: [New]
slug: group-by-message-template-117959
permalink: /group-by-message-template-117959/
---

If you've started using one of the recent versions of our integrations with [NLog](https://docs.elmah.io/logging-to-elmah-io-from-nlog/), [Serilog](https://docs.elmah.io/logging-to-elmah-io-from-serilog/) or [Microsoft.Extensions.Logging](https://docs.elmah.io/logging-to-elmah-io-from-microsoft-extensions-logging/), you may have noticed the new [Message Template](https://blog.elmah.io/structured-logging-vnext/) field. If not, maybe now is a good time to upgrade. We just added a *Message Template* item to the *Group by* dropdown on the search page. This makes it possible to group all log messages by their original form. This would group both `Poll - custom columns: true` and `Poll - custom columns: false` in the same group:

![Group by message template](/images/117959/434-66019fe51b5743208470523672d1aa61675d56d6.png)
