---
title: "Improved API key validation on ChatGPT integration"
date: 2024-10-16T09:09:20Z
categories: [Improvement]
slug: improved-api-key-validation-on-chatgpt-integration-302752
permalink: /improved-api-key-validation-on-chatgpt-integration-302752/
---

The ChatGPT app has been improved in several ways. We have added a *Test* button on the app to allow for testing the inputted OpenAI API key:

![Test button on ChatGPT app](/images/302752/100-841cd3ab4422daeecfd48b36ec90e4b318f94430.png)

Furthermore, we have improved potential errors being returned from the OpenAI API when clicking the *Get suggestion* button in the search UI. Rather than failing silent, the UI will now indicate if the API key is wrong, the usage limit has been reached, and more errors.

These changes make it easier than ever to integrate AI-suggested error resolution directly on your errors in elmah.io.
