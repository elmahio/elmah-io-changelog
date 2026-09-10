---
title: "CORS fixes on the API"
date: 2021-08-26T09:17:50Z
categories: [Improvement]
slug: cors-fixes-on-the-api-205454
---
We have improved the way CORS is implemented on the API. This doesn't require changes on your part. I still want to mention it, in case it causes issues somewhere since the headers have been changed.

Previously, we were running on a hand-crafted CORS solution on the API that has now been migrated to the built-in CORS feature in ASP.NET Core. The old solution where returning un-needed response headers in all requests and there was a CORS problem when returning a response with an API request limit. Both issues have been fixed by moving to the built-in CORS feature. Let us know in the chat if you experience any problems.
