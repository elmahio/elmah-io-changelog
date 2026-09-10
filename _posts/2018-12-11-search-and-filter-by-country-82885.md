---
title: "🗺️ Search and filter by country"
date: 2018-12-11T08:37:21Z
categories: [New]
slug: search-and-filter-by-country-82885
permalink: /search-and-filter-by-country-82885/
---

Sometimes, errors generated from a specific country are more, or less, important than others. With the new country support on elmah.io, you can search, filter and set up rules based on the origin country of an error. On all errors, where we were able to identify a country, an ISO 3166-1 alpha-2 country code is added. You can search by country using a query like this:

```
country:"US"
```

For easier filtering, you can click the *Add filter* button and search using the filtered search feature:

![Search by country](/images/82885/961-8fe6fe474f65e3e8886877823f1ee8be359adb02.png)

Finally, ignore rules (or any other rule type) can be based on the country too.

The country information is extracted by looking at a combination of HTTP headers like `User-Language` and `Accept-Language`. If you are using Cloudflare, geolocation can be enabled as described here: https://support.cloudflare.com/hc/en-us/articles/200168236-What-does-Cloudflare-IP-Geolocation-do-. We may or may not extend elmah.io with IP-based geolocation, but for now, Cloudflare is the way to go for a 100% accurate resolving of country codes.
