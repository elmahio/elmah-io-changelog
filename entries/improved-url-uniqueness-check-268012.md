---
title: "Improved URL uniqueness check"
date: 2023-06-26T08:24:45Z
categories: [Improvement]
slug: improved-url-uniqueness-check-268012
---
We put a new URL uniqueness improvement in production which will catch more unique URLs. URL uniqueness is, among other things, used to identify if an error has been seen before by elmah.io. It's a feature that we constantly tweak, but we still wanted to mention this specific improvement to avoid any confusion.

The improvements include date time detection inside URL parts:

```
# Considered as the same page
https://blog.example.com/posts/2023-06-25/list
https://blog.example.com/posts/2023-06-26/list
```

As well as URL fragment ignore:

```
# Considered as the same page
https://example.com/post#42
https://example.com/post#43
```

Let us know if these changes cause any problems.
