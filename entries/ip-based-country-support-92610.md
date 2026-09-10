---
title: "IP based country support"
date: 2019-03-06T13:01:22Z
categories: [New]
slug: ip-based-country-support-92610
---
The last step of country support on elmah.io has been launched. As of today, the country code attached to each log message is resolved from a database of IP to country mappings. We still support [resolving the country from looking at HTTP headers](https://changelog.elmah.io/search-and-filter-by-country-82885), but it will act as a fallback when the country cannot be mapped using the IP to country database.

With this change, we are able to put a country code on a lot of previously unmapped log messages, including log messages generated through [client-side logging](https://elmah.io/features/clientside-logging/).

Check out the following blog post for details about the entire country feature: [Country support](https://blog.elmah.io/country-support/).
