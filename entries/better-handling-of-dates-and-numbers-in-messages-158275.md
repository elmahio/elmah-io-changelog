---
title: "Better handling of dates and numbers in messages"
date: 2020-07-07T13:51:36Z
categories: [Improvement]
slug: better-handling-of-dates-and-numbers-in-messages-158275
---
We pushed some improvements to the hashing algorithm used internally on elmah.io. The hash is used for various purposes like the `isNew` flag and Unique grouping on the elmah.io UI. With the recent changes, elmah.io is able to detect dates and similar in log messages.

As an example, the following log messages would both be marked as unique (`isNew=true`) with the old hashing algorithm but as the same log message with the new hash:

```
The last successful renewal completed at 2020-04-07T05:12:54.257Z
The last successful renewal completed at 2020-05-12T13:44:35.593Z
```
