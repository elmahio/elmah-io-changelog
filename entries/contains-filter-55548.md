---
title: "Contains filter"
date: 2018-04-08T18:06:04Z
categories: [Improvement]
slug: contains-filter-55548
---
We just extended Search Filters with a new feature. It is now possible to search using *Contains*:

![Contains Filter](/images/55548/372-3472055562a45687a8491faea3b81911983de50d.png)

Play around with it and please get back to us with feedback. It is still based on Elasticsearch full-text queries, why the behavior doesn't necessarily match an `IndexOf` or SQL `LIKE` statement.
