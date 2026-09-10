---
title: "Logger and Exception Visualizer extensions for Visual Studio"
date: 2024-09-20T07:35:59Z
categories: [New]
slug: logger-and-exception-visualizer-extensions-for-visual-studio-301084
permalink: /logger-and-exception-visualizer-extensions-for-visual-studio-301084/
---

As you may know, we have built various free tools, from [online services](https://elmah.io/tools/) to extensions for popular development tools. A new extension for Visual Studio just landed and since the previous one was never announced, let's go through both tools in this changelog. Both extensions are Debugger Visualizers for Visual Studio. A Debugger Visualizer will help you inspect objects when debugging .NET applications inside of VS.

## Logger Visualizer

If you are using Microsoft.Extensions.Logging, the Logger Visualizer is a great way to inspect the current logging configuration in a more pleasing way than looking through JSON.

![Logger Visualizer](/images/301084/901-5bc5e1d7842feb516f65008f08ddf712cdc88a72.png)

As an elmah.io user, there's an extra benefit in using the extension. When the `Elmah.Io.Extensions.Logging` logger is configured, a special tab will show up:

![elmah.io tab](/images/301084/902-8a48cf624de1b3d79a25e6df489c1de528e0a9ab.png)

Logger Visualizer is available through the Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=elmahio.loggervisualizer

## Exception Visualizer

Getting a good overview of an exception through Visual Studio's built-in visualizer can be tricky. Especially when dealing with inner and aggregate exceptions. With Exception Visualizer, viewing an exception while debugging will give you a much better overview:

![Exception Visualizer](/images/301084/904-b6bb1de946c735c20ab75570246d381b770782d8.png)

Exception Visualizer is available through the Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=elmahio.exceptioninspector
