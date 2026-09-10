---
title: "Octopus Deploy step template for uploading source maps"
date: 2021-09-08T05:22:12Z
categories: [New]
slug: octopus-deploy-step-template-for-uploading-source-maps-206662
permalink: /octopus-deploy-step-template-for-uploading-source-maps-206662/
---

There's a new step template [available in the Octopus Deploy Library](https://library.octopus.com/step-templates/0EAF2914-E291-4CCF-833C-25EA769BF82B/actiontemplate-elmah.io-upload-source-map) for uploading source maps to elmah.io from Octopus Deploy.

In short, adding a step to your process will upload a minified JavaScript file and source map to elmah.io:

![Octopus Deploy step template for uploading source maps](/images/206662/639-d54ef7ac7d7bacbb1b2f13bf39e903cd19915f05.png)

There's a new section in the Source map documentation explaining this in more detail: [https://docs.elmah.io/sourcemaps/#upload-from-octopus-deploy](https://docs.elmah.io/sourcemaps/#upload-from-octopus-deploy). Be aware that the server-side source map feature is still in beta.
