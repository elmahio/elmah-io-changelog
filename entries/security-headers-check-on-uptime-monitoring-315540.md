---
title: "Security headers check on Uptime Monitoring"
date: 2025-05-20T06:45:16Z
categories: [New]
slug: security-headers-check-on-uptime-monitoring-315540
---
A new feature has been added to Uptime Monitoring. Enabling the new Security Headers Check toggle will inspect the response headers returned from your endpoint and validate against well-known security recommendations like adding `X-Frame-Options`, `Content-Security-Policy`, and similar headers. Much like the other available check toggles on uptime checks, the feature will log messages in your log, telling you which headers to add if something is missing.

![Security headers check on Uptime Monitoring](/images/315540/906-56e0d0001b31298c4b7531c49a5fc8be40dc847d.png)

If you are interested in security headers, the checks implemented in this feature are headers mentioned in [this](https://blog.elmah.io/improving-security-in-asp-net-mvc-using-custom-headers/) and [this](https://blog.elmah.io/the-asp-net-core-security-headers-guide/) blog post.
