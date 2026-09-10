---
title: "Root Cause view with heartbeat checks"
date: 2024-03-07T07:44:50Z
categories: [New]
slug: root-cause-view-with-heartbeat-checks-287553
permalink: /root-cause-view-with-heartbeat-checks-287553/
---

There's a new *Root Cause* view available on missing and unhealthy heartbeat errors. The view combines the overall status and reason for a heartbeat either failing or missing. In addition, any bundled checks included as part of the heartbeat are shown on the right side of the view. Heartbeat Checks are a new feature already introduced on the API and currently in prerelease in the `Elmah.Io.Client` NuGet package. We also provide prerelease versions of the `Elmah.Io.AspNetCore.HealthChecks` and `Elmah.Io.Umbraco` packages that automatically fill in checks.

![Root Cause view with heartbeat checks](/images/287553/900-c7a2ce7fef1abc5c4d5f42fd1afa83f0ac91c44e.png)

The documentation of including checks in Heartbeats will be written before the packages are moved to stable.
