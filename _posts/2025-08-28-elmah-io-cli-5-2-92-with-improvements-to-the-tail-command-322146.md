---
title: "Elmah.Io.Cli 5.2.92 with improvements to the tail command"
date: 2025-08-28T07:02:15Z
categories: [New]
slug: elmah-io-cli-5-2-92-with-improvements-to-the-tail-command-322146
permalink: /elmah-io-cli-5-2-92-with-improvements-to-the-tail-command-322146/
---

We released a [new version](https://www.nuget.org/packages/Elmah.Io.Cli/5.2.92) of the [elmah.io CLI](https://docs.elmah.io/cli-overview/). This version improves the [tail](https://docs.elmah.io/cli-tail/) command in several ways. `tail` can be used to inspect changes to a log and is great for both monitoring and validating that an elmah.io in a project works as expected.

Besides a new information header and instructions for how to exit the program, the `tail` command now makes live updates to a table instead of writing a new table for every log message. The date format has been improved, and new log messages are now marked with a yellow star ⭐ indicating recently added log messages:

![Elmah.Io.Cli 5.2.92 with improvements to the tail command](/images/322146/206-b2bd21fb86995db96c32f5cc972de9cf56d8196f.png)
