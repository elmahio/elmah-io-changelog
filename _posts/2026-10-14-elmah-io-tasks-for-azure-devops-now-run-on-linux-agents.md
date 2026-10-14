---
title: elmah.io tasks for Azure DevOps now run on Linux agents
date: 2026-10-14T05:00:00Z
categories: [Fix]
permalink: /elmah-io-tasks-for-azure-devops-now-run-on-linux-agents/
---

The [elmah.io Deployment Notification](https://marketplace.visualstudio.com/items?itemName=elmahio.deploy-tasks) and [elmah.io Upload Source Map](https://marketplace.visualstudio.com/items?itemName=elmahio.elmah-io-upload-source-map) extensions for Azure DevOps now run on Linux and macOS agents as well as Windows. Both tasks are available as version 5.

Until now, both tasks were written for Azure DevOps' PowerShell handler, which only runs on Windows agents, so a step on an `ubuntu-latest` agent failed with "The current operating system is not capable of running this task". Version 5 is rewritten in Node.js, which every agent type can run.

To upgrade, change the task version in your pipeline. Inputs are unchanged:

```yaml
- task: ElmahIoDeploymentNotification@5
- task: ElmahIoUploadSourceMap@5
```

In classic release pipelines, select task version 5.*. Version 5 requires agent 3.232.1 or newer, which all Microsoft-hosted agents already run. It also fails the step if elmah.io rejects the request, for example because of an invalid API key, and shows elmah.io's error message in the step log. Pipelines still on version 4 keep running on Windows agents.

The documentation has been updated for [deployments from Pipelines](https://docs.elmah.io/create-deployments-from-azure-devops-pipelines/), [deployments from Releases](https://docs.elmah.io/create-deployments-from-azure-devops-releases/), and [uploading source maps from Azure DevOps](https://docs.elmah.io/sourcemaps/#upload-from-azure-devops).
