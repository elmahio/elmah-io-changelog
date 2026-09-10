---
title: "Improved messages search API endpoint"
date: 2023-10-09T11:03:58Z
categories: [Improvement]
slug: improved-messages-search-api-endpoint-276292
permalink: /improved-messages-search-api-endpoint-276292/
---

There's an improved way of fetching a large set of log messages from the API. Previously (you can still do that) you'd have to use pagination to get more than 100 messages:

```
https://api.elmah.io/v3/messages/LOG_ID?pageSize=100&pageIndex=2
```

The data is stored in Elasticsearch which doesn't allow pagination in more than 10,000 documents. With the improved API, all search requests return a new `searchAfter` property:

```json
{
  "messages": [
    // ...
  ],
  "searchAfter": "1694180633270",
  "total": 42
}
```

In subsequent requests you can provide the API with the value of the `searchAfter` property to pick up where you left off:

```
https://api.elmah.io/v3/messages/LOG_ID?pageSize=100&searchAfter=1694180633270
```

The change is available on the API and in the `Elmah.Io.Client` [5.1 prerelease](https://www.nuget.org/packages/Elmah.Io.Client/5.1.67-pre) NuGet package.
