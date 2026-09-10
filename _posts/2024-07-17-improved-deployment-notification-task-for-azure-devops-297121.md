---
title: "Improved deployment notification task for Azure DevOps"
date: 2024-07-17T15:11:15Z
categories: [Improvement]
slug: improved-deployment-notification-task-for-azure-devops-297121
permalink: /improved-deployment-notification-task-for-azure-devops-297121/
---

The [elmah.io Deployment Notification](https://marketplace.visualstudio.com/items?itemName=elmahio.deploy-tasks) extension for Azure DevOps has been improved with the following changes:

- Added support for YAML-based Pipelines.
- If not specified, the version will automatically use the build number if installed through Pipelines and the release name if installed through Releases.
- Support for running on Linux images.

The [documentation](https://docs.elmah.io/create-deployments-from-azure-devops-pipelines/) has been updated to reflect all changes. If you have already installed the extension, Azure DevOps will automatically update to the latest version. You will need to update existing usages of the task to target version 4, though.
