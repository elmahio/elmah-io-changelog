---
title: "Azure DevOps extension for uploading source maps"
date: 2021-08-31T14:49:24Z
categories: [New]
slug: azure-devops-extension-for-uploading-source-maps-205952
---
There's a brand new extension [available in the Azure DevOps Marketplace](https://marketplace.visualstudio.com/items?itemName=elmahio.elmah-io-upload-source-map) for uploading source maps to elmah.io from Azure DevOps Pipelines.

In short, adding a task to your pipeline will upload a minified JavaScript file and source map to elmah.io:

![Azure DevOps extension for uploading source maps](/images/205952/170-cd9e4873e3502fa50aa3e8d6e481d823e84cb459.png)

There's a new section in the Source map documentation explaining this in more detail: [https://docs.elmah.io/sourcemaps/#upload-from-azure-devops](https://docs.elmah.io/sourcemaps/#upload-from-azure-devops). Be aware that the server-side source map feature is still in beta.
