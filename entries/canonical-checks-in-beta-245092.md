---
title: "Canonical checks in beta"
date: 2022-09-26T06:13:38Z
categories: [New]
slug: canonical-checks-in-beta-245092
---
We published a new canonical check toggle on uptime checks:

![Canonical checks in beta](/images/245092/713-357a61af5dda7d8a1180508df9d1360f5f61b7b2.png)

While just a simple toggle on the UI, this covers a nice new feature that will run a range of rules against your endpoints:

- Check that HTTP redirects to HTTPS.
- Check that www redirects to non-www or non-www redirects to www.
- Check unnecessary redirect chains.
- Check the use of correct redirect status code.
- Check canonical URL metadata.
- Check any use of meta refresh metadata.

The new canonical checker will be available as part of the Enterprise plan. But as part of the beta, we are offering this to everyone. If you are not on the Enterprise plan (and don't want to upgrade), you can enable the new toggle to have your endpoints checked and fixes made before this is moved out of beta.
