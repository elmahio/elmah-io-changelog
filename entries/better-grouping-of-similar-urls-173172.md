---
title: "Better grouping of similar URLs"
date: 2020-10-22T07:32:19Z
categories: [Improvement]
slug: better-grouping-of-similar-urls-173172
---
The hashing algorithm used in various features on elmah.io (like the `isNew` flag and when grouping log messages by *Unique*) has been improved in the way it looks at URLs. It's a common practice to include IDs as part of a REST URL like this:

```
/customers/42/edit
/customers/43/edit
```

elmah.io is now able to detect this scheme and treat it as the same URL.

(The hash is constructed from multiple fields, why the two URLs above could still get individual hashes if the log message and/or error type are different.)
