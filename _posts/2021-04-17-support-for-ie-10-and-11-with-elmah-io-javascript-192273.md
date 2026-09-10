---
title: "Support for IE 10 and 11 with elmah.io.javascript"
date: 2021-04-17T08:15:54Z
categories: [Improvement]
slug: support-for-ie-10-and-11-with-elmah-io-javascript-192273
permalink: /support-for-ie-10-and-11-with-elmah-io-javascript-192273/
---

`elmah.io.javascript` now supports Internet Explorer 10 and 11. The support has been added by implementing a small fix on the elmah.io API which means that you don't need to update anything on your end to have client-side errors coming through from IE 10 and 11.

In case you want to ignore these errors, you can add an ignore filter on your log with the following query:

```
data.isClientside:true && browser:ie
```
