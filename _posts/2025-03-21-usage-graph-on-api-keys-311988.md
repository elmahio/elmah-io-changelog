---
title: "Usage graph on API keys"
date: 2025-03-21T08:15:56Z
categories: [New]
slug: usage-graph-on-api-keys-311988
permalink: /usage-graph-on-api-keys-311988/
---

The elmah.io API enforces request limits to ensure stability and to avoid logging millions of messages within a few minutes. Each API key has a limit on the number of requests allowed per minute and per hour. To make it easier to track usage, we've added a visual usage graph to the list of API keys. Now, you can see in real-time how many requests each key has made and how close you are to hitting the limit. This update makes it easier to manage API access, avoid unexpected rate limit errors, and optimize how your application interacts with elmah.io.

![Usage graph on API keys](/images/311988/579-25a6ed3a8743cfb2fa28b3f8c63239c6dbd50f77.png)
