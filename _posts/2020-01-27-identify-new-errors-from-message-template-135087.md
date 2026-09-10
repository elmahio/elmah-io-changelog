---
title: "Identify new errors from message template"
date: 2020-01-27T08:03:11Z
categories: [New]
slug: identify-new-errors-from-message-template-135087
permalink: /identify-new-errors-from-message-template-135087/
---

You may remember back in August and September of last year when we [introduced structured logging](https://changelog.elmah.io/structured-logging-vnext-114977) and started [grouping messages by the new message template field](https://changelog.elmah.io/group-by-message-template-117959). Today, we released the third (and final so far) step in getting structured logging to elmah.io. With today's change, we now calculate the `isNew` flag based on the `messageTemplate` field rather than looking at `message`. In short, this means that we will now only set `isNew` to true on one of the following log messages (previously, both were set to new):

```csharp
log.Information("Error while saving {UserId}", 1);
log.Information("Error while saving {UserId}", 2);
```

The `isNew` algorithm still looks at a range of different fields (like URL and source of the error). If the message above is logged from two different URLs, both messages will be marked as new to help you identify that the error happened on multiple pages.
