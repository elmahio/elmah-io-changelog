---
title: "Improved URL grouping containing GUIDs"
date: 2022-04-05T12:46:19Z
categories: []
slug: improved-url-grouping-containing-guids-228210
---
The URL grouping algorithm that fuels features like the Unique grouping option on the UI and the new error detection have been improved. With the recent change, elmah.io will start considering the following URLs as the same URL:

```
/products/07ffdd2b-db77-4614-a310-5530cc8f7a89/edit
/products/c82d2c83-4e43-49b3-961a-230dd80cc1ee/edit
```

This change is for GUIDs only. We have already done something similar for numbers and timestamps.
