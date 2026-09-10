---
title: "Including users without an email in Affected Users"
date: 2024-04-19T10:52:25Z
categories: [Improvement]
slug: including-users-without-an-email-in-affected-users-290943
permalink: /including-users-without-an-email-in-affected-users-290943/
---

The *AFFECTED USERS* view in both the organization and log overview is already known by those of you logging emails as part of the `user` field on log messages. For others, this will now show up as a brand new view in the organization pages.

We have extended the backend to also include log messages with user info, not an email for this view. This will make the view show up in scenarios where the user is something like an identifier from a database or a username. In logs that contain messages with both emails and identifiers stored in the same log, the view will highlight problematic users better. Previously, a user with an email could show up as the most affected user, while another user with an identifier and many more log messages would not show up at all.

![iIncluding users without an email in Affected Users](/images/290943/266-4ea74b8b4ec1c856e3f817efbad257c04340d800.png)
