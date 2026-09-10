---
title: "Broken Links Checker for Azure DevOps"
date: 2025-10-15T07:19:15Z
categories: [New]
slug: broken-links-checker-for-azure-devops-325086
---
We have open-sourced and published our Broken Links Checker for Azure DevOps. With this extension, you can automatically scan your code for links during a build and have Azure DevOps test all of those links. Get it on the Azure DevOps Marketplace here: https://marketplace.visualstudio.com/items?itemName=elmahio.broken-links-checker.

Here's a quick example of YAML for running the checker:

```yaml
steps:
- task: BrokenLinksChecker@0
  inputs:
    includeGlobs: |
      **/*.html
      **/*.cshtml
    excludeFileGlobs: |
      **/node_modules/**
    ignoreUrlPatterns: |
      example.com/*
    failOnBroken: true
    concurrency: 16
    timeoutMs: 10000
    allowedStatus: 200-299,301,302
```
