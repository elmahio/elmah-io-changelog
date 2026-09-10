---
title: "Returning problem details on API request limits"
date: 2021-08-26T09:23:28Z
categories: [Improvement]
slug: returning-problem-details-on-api-request-limits-205456
permalink: /returning-problem-details-on-api-request-limits-205456/
---

The elmah.io API uses the Problem Details ([rfc7807](https://datatracker.ietf.org/doc/html/rfc7807)) specification to communicate errors back to the client. In a recent change, communication from the request limit feature has been changed to use Problem Details responses too, to avoid returning errors in different formats. The response status code still equals `429` and no changes are needed on your part unless you are inspecting the response body from request limit error responses. The new response looks like this:

![Returning problem details on API request limits](/images/205456/881-c07b451e6003e017a91d02a486624747a45910f4.png)

1 request per hour is from a test environment. The production API accepts 500 requests per API key per minute and 3,600 requests per API key per hour.
