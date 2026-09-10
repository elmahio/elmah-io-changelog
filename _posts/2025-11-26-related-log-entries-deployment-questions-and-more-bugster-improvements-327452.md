---
title: "Related log entries, deployment questions, and more Bugster improvements"
date: 2025-11-26T05:56:28Z
categories: [New]
slug: related-log-entries-deployment-questions-and-more-bugster-improvements-327452
permalink: /related-log-entries-deployment-questions-and-more-bugster-improvements-327452/
---

A new wave of features has been added to Bugster. Most of these changes are only available when enabling Extended Access, as explained in the [Bugster documentation](https://docs.elmah.io/how-to-configure-and-use-bugster/).

**Related log entries**

When asking questions about your data, any log messages part of the reply are now shown below the answer. Clicking each row will open the details of that log message on the search page.

![Related log entries](/images/327452/547-70725236d5b4dd1004289cb0ca2a624fa0d74540.png)

**Answer questions about deployments, logs, and organizations**

Bugster can now answer questions about deployments, logs, and organizations. This means that you can ask questions like "How many errors are in the deployment with version 20251101.8?" and "How many uptime checks do I have on this log?".

![Answer questions about deployments, logs, and organizations](/images/327452/548-2a92cab92d0e6d90e2a6ab2b7db989699f92bce4.png)

**Better log message counting**

A new set of tools able to count log messages has been added. This means that Bugster is way better at providing statistics since it can call counting tools rather than having to fetch log messages to make in-memory counting.

**Utilities**

We have also started providing Bugster with small utility tools. An example is something as simple as getting the current date. When running on top of an LLM and without these utilities, Bugster would think that the current date is the day the model was built.
