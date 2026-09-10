---
title: "More configuration options on Uptime Checks"
date: 2026-05-19T07:34:39Z
categories: [New]
slug: more-configuration-options-on-uptime-checks-338036
---
We gave uptime checks an overhaul with even more configuration options. In addition to the existing settings, you can now:

- Specify the HTTP method (`GET`, `POST`, etc.)
- Add custom request headers
- Specify the expected status code with conditions like `<` and `=`

All existing uptime checks are configured using `GET`, no custom headers, and with an expected status code less than `400`. The options can be found by expanding the new *Request* and *Response* groups when creating/editing an uptime check.

![More configuration options on Uptime Checks](/images/338036/970-f5672dc7f248d6bb3df1d7932eef445d46f43654.png)
