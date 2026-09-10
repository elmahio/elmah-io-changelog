---
title: "\"New\" Fixes app in the app store"
date: 2025-03-17T08:30:45Z
categories: [New]
slug: new-fixes-app-in-the-app-store-311638
permalink: /new-fixes-app-in-the-app-store-311638/
---

There's a "new" app in the elmah.io app store called *Fixes*. "New" in quotation marks since it covers features already available on elmah.io. The *Fixes* app will show a tab named *Fix* on the extended log message details view with Quick Fixes and answers from Stack Overflow. This view has been available on elmah.io for years, but with the new app, you will be able to disable one or both sections from the view.

There can be different motives behind disabling these features. The main one is to avoid sharing log messages with external partners. Quick Fixes suggest searching for log message details through Google and similar. Clicking this will open a Google search result with the log message as input. If the log message contains information you don't want to share outside your organization, doing a Google search breaks this. Similarly, if the Stack Overflow section is enabled through the *Fixes* app, opening the extended log details view will make a search on Stack Overflow's API with the log message. Again, when this is enabled, log messages are shared outside of elmah.io which for some users may not be the desired behavior.

For consistency, we have installed the new *Fixes* app on all logs and the app will also be automatically installed when creating new logs through either the UI or the API. To disable one or both of the sections Quick Fixes and Stack Overflow, you can configure settings in the app or uninstall it entirely:

![Fixes app](/images/311638/346-8e7764cbc23dd38906db41f6d157135bbd279544.png)
