---
title: "elmah.io.javascript 3.1.1"
date: 2019-11-20T20:04:37Z
categories: [Improvement]
slug: elmah-io-javascript-3-1-1-128054
---
There's a new feature version of the `elmah.io.javascript` package. This version includes a new `message` function that will return a prefilled message (including URL, server variables, etc.):

```javascript
var msg = logger.message(); // Get a prefilled message
msg.title = "This is a custom log message";
logger.log(msg);
```

The new version is available on [GitHub](https://github.com/elmahio/elmah.io.javascript/releases/tag/3.1.1), [CDN](https://cdn.jsdelivr.net/gh/elmahio/elmah.io.javascript@3.1.1/dist/elmahio.min.js), [npm](https://www.npmjs.com/package/elmah.io.javascript), and [NuGet](https://www.nuget.org/packages/elmah.io.javascript/).

[Documentation](https://docs.elmah.io/logging-to-elmah-io-from-javascript/) and [TypeScript mappings](https://github.com/elmahio/elmah.io.javascript/blob/master/typescript/elmahio.d.ts#L61) have been updated accordingly.
