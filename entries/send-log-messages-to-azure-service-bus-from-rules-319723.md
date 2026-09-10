---
title: "Send log messages to Azure Service Bus from rules"
date: 2025-07-18T13:27:37Z
categories: [New]
slug: send-log-messages-to-azure-service-bus-from-rules-319723
---
There's a new authentication method available on HTTP rules named *SharedAccessSignature*. When choosing this option, you can generate and input a Shared Access Signature (SAS) for Azure resources like Azure Service Bus, making it possible to send log messages to a queue or similar:

![image.png](/images/319723/670-ccb8d98e9c6bd4baf3d71f7f107afec8abdd410f.png)

There's an example of how to generate a SAS from code available here: https://docs.elmah.io/sending-messages-from-elmah-io-to-azure-service-bus-using-sas-authentication/. For now, you will need to generate a SAS manually and set a long expiration date or update it frequently. If this is something that people are interested in, we might add an app that automates this later on.
