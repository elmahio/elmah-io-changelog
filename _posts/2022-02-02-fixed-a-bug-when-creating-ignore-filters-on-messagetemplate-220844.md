---
title: "Fixed a bug when creating ignore filters on messageTemplate"
date: 2022-02-02T10:19:14Z
categories: [Fix]
slug: fixed-a-bug-when-creating-ignore-filters-on-messagetemplate-220844
permalink: /fixed-a-bug-when-creating-ignore-filters-on-messagetemplate-220844/
---

We fixed a bug which would cause some instances of ignore filters based on the `messageTemplate` field to fail. With this fix, ignore filters can now fully utilize custom queries like this:

```
messageTemplate: "{user} says hello"
```
