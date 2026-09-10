---
title: "All uptime issues have now been migrated to Recommendations"
date: 2026-05-14T07:42:22Z
categories: [Improvement]
slug: all-uptime-issues-have-now-been-migrated-to-recommendations-337749
---
Since all issues logged by uptime monitoring have now been migrated to Recommendations, these are no longer logged as log messages. This applies to the various toggles available on uptime checks and not up/down messages. Examples of issues migrated to recommendations are expiring SSL certificates, Lighthouse score decrease, security headers, etc.

Switching to recommendations means that an issue is only logged once, instead of the previous solution, where issues were logged as log messages daily. This took up log messages against your monthly quota, and the issues quickly disappeared between normal log messages.

To subscribe to emails when new recommendations are logged, enable the *New Recommendation* toggle on the *Emails* tab on your profile.

![All uptime issues have now been migrated to Recommendations](/images/337749/829-c424cab784b8ce2a3bfb4af8f7019711e8c23cbb.png)
