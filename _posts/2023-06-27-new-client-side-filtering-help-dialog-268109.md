---
title: "New client-side filtering help dialog"
date: 2023-06-27T09:40:18Z
categories: [New]
slug: new-client-side-filtering-help-dialog-268109
permalink: /new-client-side-filtering-help-dialog-268109/
---

There's a new help dialog available on log messages stored in elmah.io with support for the 4 popular logging frameworks Microsoft.Extensions.Logging, NLog, log4net, and Serilog. The help dialog is available from the log message details toolbar and will show different ways of setting up client-side filtering of messages that you don't want to store in elmah.io. You may be thinking that no filtering needs to happen on your side since elmah.io supports Ignore filters. But Ignore filters are only meant as a way to temporarily ignore log messages. In case you want a permanent solution, ignoring log messages before communicating with the elmah.io API is always the better option. This will improve the performance of your application, limit bandwidth, and reduce the risk of hitting the elmah.io API request limit.

![New client-side filtering help dialog](/images/268109/324-2b79322690d5ebd0a4a104e9424fcb889ac32d63.png)
