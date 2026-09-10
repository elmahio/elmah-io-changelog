---
title: "Announcing the new Exception Inspector"
date: 2023-05-24T12:42:14Z
categories: [New]
slug: announcing-the-new-exception-inspector-265594
permalink: /announcing-the-new-exception-inspector-265594/
---

After having looked at exception stack traces for more than 10 years now, we have been talking about a better way to show them over and over again. I'm happy to reveal the first shot at improving this on elmah.io. A new feature/view that we call the Exception Inspector:

![Announcing the new exception Inspector](/images/265594/567-b628250e0f7c6dc6b5a018a55480972046bd62e5.png)

As seen in the screenshot, inner exceptions are better visualized using a tree structure. Clicking each exception not only shows the stack trace but also other vital information on each exception. Like exception-specific properties, the Data dictionary, and more info.

All of the data for this new view will be automatically collected when using one of the integrations for ASP.NET Core, NLog, Serilog, etc. If logging manually through the `Elmah.Io.Client` NuGet package, you need to call the `ToDataList` method as shown in this [full example](https://docs.elmah.io/logging-to-elmah-io-from-console-application/#full-example). The feature is currently available in the new 5.x prereleases but will be released in stable within the next couple of months. We would love to hear your feedback if you want to play with this locally or on non-critical systems.
