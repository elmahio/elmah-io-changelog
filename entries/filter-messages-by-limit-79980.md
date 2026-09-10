---
title: "Filter messages by limit"
date: 2018-11-15T07:26:39Z
categories: [New]
slug: filter-messages-by-limit-79980
---
There's a new limit filter available on log settings. The limit filter lets you input a max number of messages you want in a log each month:

![Filter Limit](/images/79980/983-de08ff9af63d5d59c7933f836696af1d1b4b11a2.png)

In this example, I've inputted `1000` which means that no more than 1,000 messages will be logged in this log each month. This can act as a way to help you distribute your included log messages over multiple logs. As always when filtering messages, this may cause inconsistencies in various features and graphs, since you don't get the full picture of what your application actually generates. It is recommended to use the new filter for development logs and similar only. As always, message counts are based on the messages sent to a log this month and not on what's currently stored.
