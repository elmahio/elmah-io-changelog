---
title: "New documentation: How to stay below the message size limit"
date: 2026-11-10T06:30:00Z
categories: [New]
permalink: /new-documentation-how-to-stay-below-the-message-size-limit/
---

There's a new page on the documentation site explaining how to [stay below the message size limit](https://docs.elmah.io/how-to-stay-below-the-message-size-limit/). It lists the maximum size of a single message and a bulk request, and shows how to trim large fields like `Detail` in the `OnMessage` action and how to lower the batch size in Serilog, Microsoft.Extensions.Logging, and NLog.
