---
title: "Problem Details (RFC 7807) support in Uptime Monitoring"
date: 2018-04-20T08:20:09Z
categories: [New]
slug: problem-details-(rfc-7807)-support-in-uptime-monitoring-57095
permalink: /problem-details-(rfc-7807)-support-in-uptime-monitoring-57095/
---

Uptime Monitoring now supports Problem Details in the response from your endpoints. You may not know about Problem Details, but it's a standard for returning detailed error messages from web APIs. Problem Details are supported by most web frameworks already and we recommend you to adopt the standard, rather than inventing new response formats for communicating errors back from your API.

If our Uptime checker identifies Problem Details in your response, we extract this information and present it as part of the logged error.

Check out the specification here: https://tools.ietf.org/html/rfc7807
