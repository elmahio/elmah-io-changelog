---
title: "Fixed warning in the Azure DevOps integration"
date: 2020-01-22T16:18:35Z
categories: [Fix]
slug: fixed-warning-in-the-azure-devops-integration-134572
---
Those of you who use the integration between Azure DevOps and elmah.io may have noticed the following warning in the log when notifying elmah.io about a new release:

```
##[warning]Task 'ElmahIoDeploymentNotification' (3.1.1) is using deprecated task execution handler. The task should use the supported task-lib: https://aka.ms/tasklib
```

We released a new version which fixes this warning. The new integration is automatically rolled out to your pipelines. If you experience any problems in this process, it can be installed manually from here: https://marketplace.visualstudio.com/items?itemName=elmahio.deploy-tasks
