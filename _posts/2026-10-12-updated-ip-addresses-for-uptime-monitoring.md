---
title: Updated IP addresses for uptime monitoring
date: 2026-10-12T14:30:00Z
categories: [Improvement]
permalink: /updated-ip-addresses-for-uptime-monitoring/
---

The IP addresses used by elmah.io Uptime Monitoring have changed in all regions. If you allow our uptime agents through a firewall or similar by IP address, you will need to update your allowlist. Europe North and Europe West were the most out of date, and some requests were coming from addresses that weren't on the published list.

You can find the current IP addresses per region in the [Allowing elmah.io uptime agents](https://docs.elmah.io/allowing-elmah-io-uptime-agents/) documentation. If you allow requests by `User-Agent` (`elmahio-uptimebot/2.0`) instead, nothing needs to change.
