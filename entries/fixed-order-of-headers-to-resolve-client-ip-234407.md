---
title: "Fixed order of headers to resolve Client IP"
date: 2022-06-07T08:59:48Z
categories: []
slug: fixed-order-of-headers-to-resolve-client-ip-234407
---
We have pushed a fix to the order of HTTP headers we look at to resolve the Client IP field. With this fix, we now prioritize headers like `X-Forwarded-For` over `Client-IP` and similar, to better support reverse proxies like Cloudflare, Nginx, and Squid. Let us know if you believe errors include the wrong IP in the Client IP field going forward.
