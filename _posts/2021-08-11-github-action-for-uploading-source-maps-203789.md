---
title: "GitHub Action for uploading source maps"
date: 2021-08-11T09:03:09Z
categories: [New]
slug: github-action-for-uploading-source-maps-203789
permalink: /github-action-for-uploading-source-maps-203789/
---

There's a brand new integration [available in the GitHub Marketplace](https://github.com/marketplace/actions/elmah-io-upload-source-map-action) for uploading source maps to elmah.io from GitHub Actions.

In short, adding a build step to your YAML file will upload a minified JavaScript file and source map to elmah.io:

```yaml
uses: elmahio/github-upload-source-map-action@v1
with:
  apiKey: ${{ secrets.ELMAH_IO_API_KEY }}
  logId: ${{ secrets.ELMAH_IO_LOG_ID }}
  path: '/bundles/sharedbundle.min.js'
  sourceMap: 'path/to/sharedbundle.map'
  minifiedJavaScript: 'path/to/sharedbundle.min.js'
```

There's a new section in the Source map documentation explaining this in more detail: [https://docs.elmah.io/sourcemaps/#upload-from-github-actions](https://docs.elmah.io/sourcemaps/#upload-from-github-actions). Be aware that the server-side source map feature is still in beta.
