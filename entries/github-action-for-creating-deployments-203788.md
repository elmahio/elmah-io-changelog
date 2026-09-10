---
title: "GitHub Action for creating deployments"
date: 2021-08-11T08:52:24Z
categories: [New]
slug: github-action-for-creating-deployments-203788
---
There's a brand new integration [available in the GitHub Marketplace](https://github.com/marketplace/actions/elmah-io-create-deployment-action) for creating elmah.io deployments from GitHub Actions.

In short, adding a build step to your YAML file will notify elmah.io about a new deployment without you having to add any custom script:

```yaml
- name: Create Deployment on elmah.io
  uses: elmahio/github-create-deployment-action@v1
  with:
    apiKey: ${{ secrets.ELMAH_IO_API_KEY }}
    version: '1.0.0'
```

The [documentation](https://docs.elmah.io/create-deployments-from-github-actions/) has been updated to reflect the new action.
