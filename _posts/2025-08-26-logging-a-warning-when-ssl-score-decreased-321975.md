---
title: "Logging a warning when SSL score decreased"
date: 2025-08-26T12:00:00Z
categories: [New]
slug: logging-a-warning-when-ssl-score-decreased-321975
permalink: /logging-a-warning-when-ssl-score-decreased-321975/
---

As part of the SSL Certificate Expiration check, we also collect the SSL score available from SSL Labs (available for Enterprise users only). Previously, this was only used to show the current score on the uptime check, but we have extended this to now log a warning if a decrease in the score is identified:

![image.png](/images/321975/101-7d43e34b1a8ba44793e054933ca9d09dc2e93b3b.png)
