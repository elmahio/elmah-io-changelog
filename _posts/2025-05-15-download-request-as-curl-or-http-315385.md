---
title: "Download request as curl or .http"
date: 2025-05-15T19:03:23Z
categories: [New]
slug: download-request-as-curl-or-http-315385
permalink: /download-request-as-curl-or-http-315385/
---

There are two new features available on the log message details: exporting the request causing a log message to a curl or .http file. The options are available below the new *Export* button on the right side of the details view (we also moved *Copy message* here).

Clicking one of the two export options will download a file for either curl or .http capable tools (like Visual Studio and Visual Studio Code). Using these files, you can re-create the request causing an error, including the headers and body used for the original request. This will allow you to inspect failing endpoints from your local machine 🤠

![Download request as curl or .http](/images/315385/808-04e9b92cc0d3e8ea6960ce770c5122c6be24f880.png)

![.http file in Visual Studio](/images/315385/809-341f93e05b66abb2e9d664e5e5ebfaf79cb8fb57.png)
