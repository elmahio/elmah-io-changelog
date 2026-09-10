---
title: "New uptime check agents"
date: 2021-03-24T11:01:23Z
categories: [Improvement]
slug: new-uptime-check-agents-189881
permalink: /new-uptime-check-agents-189881/
---

New uptime check agents have been deployed to the 9 supported regions to make [Uptime Monitoring](https://elmah.io/features/uptimemonitoring/) more resilient and transparent to Azure outages. This won't change anything on your end unless you are explicitly allowing IP addresses to ping your endpoints from the United States East region. In this case, you will need to include additional IP addresses as specified here: [https://docs.elmah.io/allowing-elmah-io-uptime-agents/](https://docs.elmah.io/allowing-elmah-io-uptime-agents/). This step is required for the US East region only.
