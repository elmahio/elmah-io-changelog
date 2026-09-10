---
title: "Burst detection"
date: 2018-08-17T07:57:37Z
categories: [New]
slug: burst-detection-69282
permalink: /burst-detection-69282/
---

There's a new Filter in town: Burst detection. With the burst filter (currently in beta), elmah.io will ignore a log message, when the same message is logged 50 times already:

![Filter Bursts](/images/69282/772-0c107016a95569771c181277b9dbd4271e680c76.png)

The filter is based on the new `isBurst` flag, available on all log messages. You can search for burst messages (as long as you haven't enabled the burst filter) through the search UI and/or Rules:

```
isBurst:true
```

Be aware that ignoring burst messages will cause some features on elmah.io to not work as intended. The spike detection will in most cases don't have enough data to send the Impact Increased Email. Also, graphs on elmah.io and in the Daily Digest Email won't show the full picture of your current errors. Burst protection is primarily created for users, where staying within the message limit is more important than getting the correct picture.
