---
title: "Correlating messages from Durable Functions in isolated model"
date: 2026-08-05T13:10:00Z
categories: [New]
slug: correlating-messages-from-durable-functions-in-isolated-model-343462
permalink: /correlating-messages-from-durable-functions-in-isolated-model-343462/
---

We've added a new section to the correlation docs covering Durable Functions running in the isolated worker model (`dotnet-isolated`), where linking log messages across the starter, orchestrator, and activity functions needs a bit more setup than other trigger types. Check out the [Durable Azure Functions guide](https://docs.elmah.io/how-to-correlate-messages-across-services/#isolated-worker-model) for more details.
