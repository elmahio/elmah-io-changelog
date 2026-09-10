---
title: "Embedding source code on errors"
date: 2021-08-24T06:17:05Z
categories: [New]
slug: embedding-source-code-on-errors-205144
---
You probably tried looking at a stack trace, locating the details about the failing file and line number, and then opening the source code in your favorite IDE to inspect what is going on in that file and line. A tedious process that requires you to clone the code, maybe check out a specific tag, launch Visual Studio or similar, and locate the file and line number. With the new Embedded source code feature, elmah.io make it possible to embed the failing line and the lines around it directly in the error. Check out the details in this introduction blog post: [Embedding source code on errors logged to elmah.io](https://blog.elmah.io/embedding-source-code-on-errors-logged-to-elmah-io/).

![Embedding source code on errors](/images/205144/743-53c5ea6f5580a368ec2ac7bbbbb1cd36076c3571.png)
