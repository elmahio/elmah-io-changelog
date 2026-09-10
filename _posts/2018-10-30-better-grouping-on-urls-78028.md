---
title: "Better grouping on URLs"
date: 2018-10-30T10:15:16Z
categories: [Improvement]
slug: better-grouping-on-urls-78028
permalink: /better-grouping-on-urls-78028/
---

We just launched a new version of our grouping algorithm. Grouping is used throughout elmah.io to group similar errors together, identify new errors and much more. With the recent change, URLs that aren't equal but still represents the same resource, are grouped together. Examples could be:

- `http://domain.com:80` and `http://domain.com`
- `/some/path/` and `/some/path`
- `/books?id=1` and `/books?id=2`

Let us know if you experience similar URLs that aren't grouped.
