---
title: "Support for Azure Functions v2"
date: 2018-03-20T06:37:16Z
categories: [New]
slug: support-for-azure-functions-v2-53669
permalink: /support-for-azure-functions-v2-53669/
---

Azure Functions v2 (running on .NET Core, yay!) moved out of preview. We've just released a new version of the elmah.io integration for Azure Functions, which fully supports Functions v2. Since the API is identical, the only thing needed is to install the newest version of the `Elmah.Io.Functions` package as described here: https://docs.elmah.io/logging-to-elmah-io-from-azure-functions/#automatic-using-elmahiofunctions-the-prerelease-choice. The documentation has been updated to cover v2 and there's a [new sample](https://github.com/elmahio/Elmah.Io.Functions/tree/master/samples/Elmah.Io.Functions.FunctionCoreApp) for you to check out.

We are using the prerelease package for both Azure Functions v1 and v2 internally at elmah.io. The reason for it to be a prerelease is only caused by the fact that the Azure Functions packages are still marked as beta.
