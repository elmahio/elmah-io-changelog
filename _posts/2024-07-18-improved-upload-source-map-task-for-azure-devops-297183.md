---
title: "Improved upload source map task for Azure DevOps"
date: 2024-07-18T10:56:32Z
categories: [Improvement]
slug: improved-upload-source-map-task-for-azure-devops-297183
permalink: /improved-upload-source-map-task-for-azure-devops-297183/
---

The [elmah.io Upload Source Map](https://marketplace.visualstudio.com/items?itemName=elmahio.elmah-io-upload-source-map) extension for Azure DevOps has been improved with the following changes:

- Support for running on Linux images.
- Documentation for running on YAML-based pipelines.

The [documentation](https://docs.elmah.io/sourcemaps/#upload-from-azure-devops) has been updated to reflect all changes. If you have already installed the extension, Azure DevOps will automatically update to the latest version. You will need to update existing usages of the task to target version 4, though.
