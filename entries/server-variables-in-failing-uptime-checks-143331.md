---
title: "Server variables in failing uptime checks"
date: 2020-03-27T07:47:29Z
categories: [New]
slug: server-variables-in-failing-uptime-checks-143331
---
When logging a failed uptime check, we try to log as much information about the failing request as possible. The more information available, the easier it is to spot why a request is failing. With a recent addition to elmah.io Uptime Monitoring, we now also log the response headers returned by a failing endpoint:

![Server variables](/images/143331/545-304bc84dc111052418213879d77a8cc24607053b.png)
