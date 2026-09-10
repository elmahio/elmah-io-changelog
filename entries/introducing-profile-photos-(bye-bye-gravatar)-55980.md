---
title: "Introducing profile photos (bye bye Gravatar)"
date: 2018-04-11T17:26:26Z
categories: [Improvement]
slug: introducing-profile-photos-(bye-bye-gravatar)-55980
---
As part of our efforts towards GDPR compliance, we are looking through external services that we share data with. One of these is Gravatar, which we have been using from day one. Gravatar is a simple service, returning either a profile picture (if the user has a Gravatar account) or a default user icon.  While this is a neat feature, we need to share your hashed email address with Gravatar. This means that they in theory can track your webpage usage. We want to limit the amount of services able to do so and since a profile photo can be implemented on elmah.io instead, we have decided to do that.

On the Profile view, there's a new Profile photo section:

![Profile Photo](/images/55980/550-47b7ac12490cb542486e1d2cf8aa0304bda1ee68.png)

When choosing a file and uploading the photo, your teammates are able to see your new photo.
