---
title: "IsNew fix when errors marked as fixed"
date: 2017-12-29T19:25:52Z
categories: [Fix]
slug: isnew-fix-when-errors-marked-as-fixed-45351
---
We fixed a bug where the IsNew flag were set to true, when previous errors had been marked as fixed. From today, a message is only set to new if we didn't see it before or if all previous instances had been marked as fixed.
