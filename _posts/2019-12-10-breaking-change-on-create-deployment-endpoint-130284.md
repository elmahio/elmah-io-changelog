---
title: "Breaking change on create deployment endpoint"
date: 2019-12-10T06:23:37Z
categories: [Improvement]
slug: breaking-change-on-create-deployment-endpoint-130284
permalink: /breaking-change-on-create-deployment-endpoint-130284/
---

We want to implement a breaking change on the [Create deployment API endpoint](https://api.elmah.io/swagger/index.html#/Deployments/Deployments_Create). Currently, the endpoint returns a status code `409` if someone tries to create a new deployment with a version number that has already been created. This was done to prevent anyone from accidentally create the same deployment twice. When talking to you guys, it seems like this check causes more problems than it solves. When releasing through Octopus Deploy, Azure DevOps Pipelines, and similar, releasing the same version twice is a feature, not a bug.

We've already spoken with some of you about this and everyone seems happy about the change so far. If we haven't heard any complaints by January 15th the breaking change will roll out in production.
