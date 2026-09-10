---
title: "Message limit timespan and notifications"
date: 2018-04-11T17:45:46Z
categories: [Improvement]
slug: message-limit-timespan-and-notifications-55983
permalink: /message-limit-timespan-and-notifications-55983/
---

As I've mentioned 100 times already (will keep mentioning it), May 1st marks the day where we will start enforcing message limits. We are currently playing around with a bunch of things, in order to make the transition as smooth as possible. One of the things I've heard from multiple of you, is a bit of annoyance regarding the message limit exceeded email. You want it when it happens and not every freaking day :) So, today we've changed that. You will get a warning when you reach 90% consumption of either messages or emails. And you will receive a new email when going over the message or email limits.

When implementing this change, we realized that using rolling 30 days simply wasn't good enough. Our checks were based on an algorithm, looking through the last 30 days of usage. With this approach, it's simply not possible to send a single email, when you go over the limit (since you could do that daily). In order to fix that, and to make the new limit even easier to understand, we've changed the timespan to follow calendar months.

This means that we will reset the counter first day of the month and you will have the included number of messages available during that month. If you reach your limit, let's say the 28th, you will receive an email. It's up to you if you want to live without logging the following 2-3 days or if you want to upgrade. We think that's a fair, transparent and easy to understand solution for everyone.

Let us know if you have any questions, ok?
