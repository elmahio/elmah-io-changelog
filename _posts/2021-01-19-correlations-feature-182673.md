---
title: "Correlations feature"
date: 2021-01-19T11:55:01Z
categories: [New]
slug: correlations-feature-182673
permalink: /correlations-feature-182673/
---

We have launched a new feature on elmah.io called **Correlations**. With Correlations, you can correlate/group log messages across multiple sites and services together. Think of a console app calling an API that puts a message on a queue that a service consumes. By correlating log messages from all three processes, you will be able to see a shared trace of what happens.

I won't go into more detail here, since the feature is already described here: [How to correlate messages across services](https://docs.elmah.io/how-to-correlate-messages-across-services/). The Correlations feature is currently in beta and will in some cases require you to install prerelease NuGet packages. I look forward to hearing what you think.
