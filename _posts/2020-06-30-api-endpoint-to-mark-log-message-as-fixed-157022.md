---
title: "API endpoint to mark log message as fixed"
date: 2020-06-30T09:18:34Z
categories: [New]
slug: api-endpoint-to-mark-log-message-as-fixed-157022
permalink: /api-endpoint-to-mark-log-message-as-fixed-157022/
---

There's a new endpoint on the API, able to mark one or more log messages as fixed:

```
https://api.elmah.io/v3/messages/LOG_ID/MESSAGE_ID/_fix
```

For details, check out the added section in the documentation: [Fixing a message](https://docs.elmah.io/using-the-rest-api/#fixing-a-message).
