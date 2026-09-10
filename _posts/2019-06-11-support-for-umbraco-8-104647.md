---
title: "Support for Umbraco 8"
date: 2019-06-11T09:08:07Z
categories: [Improvement]
slug: support-for-umbraco-8-104647
permalink: /support-for-umbraco-8-104647/
---

For all of you first movers out there, there's a prerelease of the upcoming support for Umbraco 8. The new integration still logs uncaught exceptions and 404s. Umbraco 8 moved from log4net to Serilog, why our integration now bundles the Serilog.Sinks.ElmahIo package. Check out the new prerelease here: https://www.nuget.org/packages/elmah.io.umbraco/3.3.40-pre
