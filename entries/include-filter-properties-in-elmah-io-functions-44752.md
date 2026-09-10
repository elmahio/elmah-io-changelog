---
title: "Include filter properties in Elmah.Io.Functions"
date: 2017-12-21T10:28:21Z
categories: [New]
slug: include-filter-properties-in-elmah-io-functions-44752
---
The integration for Azure Functions (and WebJobs) keeps getting better. With the recent version, filter properties are included as data items on elmah.io. Filter properties are a feature of Functions/WebJobs, where multiple action filters can share a dictionary of properties. When our integration is notified of an error, we automatically decorate the error logged on elmah.io, with all properties set by filters. This can heavily improve the debugging experience, since your filters can add information about the execution of each function.
