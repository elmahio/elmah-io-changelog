---
title: "Allow existing version number in deployments"
date: 2020-01-15T05:58:17Z
categories: [Improvement]
slug: allow-existing-version-number-in-deployments-133769
permalink: /allow-existing-version-number-in-deployments-133769/
---

As [announced](https://changelog.elmah.io/breaking-change-on-create-deployment-endpoint-130284) a little over a month ago, the [create deployment](https://api.elmah.io/swagger/index.html#/Deployments/Deployments_Create) endpoint on the [API](https://api.elmah.io/swagger/index.html) has now been changed. With this change, the same version number can now be created multiple times to allow redeployments. The API still returns a status code of `201` on updates to ensure backward compatibility.
