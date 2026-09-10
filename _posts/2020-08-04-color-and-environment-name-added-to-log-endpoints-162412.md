---
title: "Color and environment name added to log endpoints"
date: 2020-08-04T06:36:25Z
categories: [Improvement]
slug: color-and-environment-name-added-to-log-endpoints-162412
permalink: /color-and-environment-name-added-to-log-endpoints-162412/
---

The API endpoints for [getting all logs](https://api.elmah.io/swagger/index.html#/Logs/Logs_GetAll) in an organization and [a single log](https://api.elmah.io/swagger/index.html#/Logs/Logs_Get) from a log id have been extended with two new properties: `color` and `environmentName`. These will include the values for the log color and the environment chosen through the elmah.io UI.

![Get logs endpoint](/images/162412/946-3695cdf1fc187c4029b31844631c157567a4bb9c.png)

An updated version of the `Elmah.Io.Client` package will follow asap.
