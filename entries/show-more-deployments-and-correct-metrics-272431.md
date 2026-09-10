---
title: "Show more deployments and correct metrics"
date: 2023-08-22T10:34:56Z
categories: [Improvement]
slug: show-more-deployments-and-correct-metrics-272431
---
We have improved the Deployments tab to show up to 50 recent deployments for those of you who release often. While changing this we also excluded '0' metric badges on old deployments where we no longer have the data to calculate the metrics. In the past, deployments older than the retention period included in your plan would show all zeros. This could give a wrong impression of the quality of the deployment since the zero was caused by missing data and not the actual number for the deployment.

![Show more deployments and correct metrics](/images/272431/993-7d36f79770024adc167d06651a2787500389b413.png)
