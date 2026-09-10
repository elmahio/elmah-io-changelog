---
title: "Elmah.Io.Client 4.4.56 with Category, FixAll, and CancellationToken support"
date: 2023-03-21T10:52:06Z
categories: [New]
slug: elmah-io-client-4-4-56-with-category-fixall-and-cancellationtoken-support-260575
permalink: /elmah-io-client-4-4-56-with-category-fixall-and-cancellationtoken-support-260575/
---

We released a new version ([4.4.56](https://www.nuget.org/packages/Elmah.Io.Client/4.4.56)) of the `Elmah.Io.Client` package. The new version includes the following changes:

- Support for `CancellationToken` on all async methods.
- Support for new `Category` field on log messages.
- Include properties from `TaskCanceledException`.
- New `FixAll`-method to mark a range of log messages as fixed.
