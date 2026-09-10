---
title: "Checking for vulnerable NuGet packages on GitHub Actions"
date: 2024-05-14T06:46:04Z
categories: []
slug: checking-for-vulnerable-nuget-packages-on-github-actions-292706
permalink: /checking-for-vulnerable-nuget-packages-on-github-actions-292706/
---

We've open-sourced a GitHub Action that is rolling out to all of our client integrations built on GitHub. The Action runs through a repository, lists the usage of vulnerable NuGet packages, and fails the build if any vulnerabilities are found. The Action is available in the [GitHub Marketplace](https://github.com/marketplace/actions/check-vulnerable-nuget-packages).

![Checking for vulnerable NuGet packages on GitHub Actions](/images/292706/585-7d04e5bf6cb1a07ce6147ae62c5d9df45f789ca2.png)
