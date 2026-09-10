---
title: "Problem Details support"
date: 2025-11-24T09:11:57Z
categories: [New]
slug: problem-details-support-327343
---
Support for RFC-compliant Problem Details has been added to elmah.io. When your API returns a ProblemDetails response, elmah.io now automatically detects it, parses the standard fields, and shows them in a structured format instead of raw JSON. Validation errors from ASP.NET Core are shown in a dedicated errors table, making it easy to see which fields failed and why. This makes debugging API-level issues significantly faster, especially when working with model validation or custom ProblemDetails implementations. No configuration changes are required, and existing logs will automatically benefit from the improved visualization.

![image.png](/images/327343/479-7985aa8e3e35aa4a69544cd5a11632d9af33b6d4.png)
