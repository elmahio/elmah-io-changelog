---
title: "Recommendation for outdated clients"
date: 2026-03-10T08:46:13Z
categories: [New]
slug: recommendation-for-outdated-clients-333512
---
We have added a new recommendation to help keep your integration up to date. This feature uses package and version metadata automatically included with every log message sent to the elmah.io API via the `Elmah.Io.*` client libraries.

By analyzing this incoming information, elmah.io can now identify when a log message comes from an older version of a package. If we detect a client version with a known update, a recommendation is generated on the log.

![Recommendation for outdated clients](/images/333512/337-1327cb10113e383ae911a62ab8284aef7e8ea0b4.png)
