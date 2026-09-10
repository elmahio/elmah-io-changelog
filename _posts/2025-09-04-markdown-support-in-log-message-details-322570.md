---
title: "Markdown support in log message details"
date: 2025-09-04T10:10:30Z
categories: [New]
slug: markdown-support-in-log-message-details-322570
permalink: /markdown-support-in-log-message-details-322570/
---

The *Detail* field on the extended log message view now supports markdown (besides stack traces, JSON, and a few others). This is primarily intended for messages produced by various elmah.io features, but you can use it in your logs if you have use cases where it will make sense to embed markdown. This is currently an opt-in feature, which requires the following key and value logged in the `Data` dictionary:

| Key | Value |
| --- | --- |
| `X-ELMAHIO-DETAILFORMAT` | `markdown` |

Existing features like the Canonical checker, SSL Scoring, and the Security checker have been updated to use markdown in the logged messages:

![Markdown support in log message details](/images/322570/513-7df08d7f6d6ec3fa2f4ef3234d7a8cdc3f757d8a.png)
