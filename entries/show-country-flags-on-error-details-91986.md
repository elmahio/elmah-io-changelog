---
title: "Show country flags on error details"
date: 2019-02-28T14:41:56Z
categories: [New]
slug: show-country-flags-on-error-details-91986
---
3 months ago we started putting country information on all errors where we can find appropriate HTTP headers. Today we released a small change showing the country flag inside error details:

![Country flag](/images/91986/322-1ebdad317bcc11fc8ed43b72793dd078ba72bcf9.png)

We are working on implementing real IP-to-country lookup in elmah.io, which should put more accurate country information on all errors. Stay tuned for updates.
