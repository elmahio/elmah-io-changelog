---
title: "Elmah.Io.Cli 4.0.68 with import from IIS and W3C log files"
date: 2023-03-13T11:39:39Z
categories: [New]
slug: elmah-io-cli-4-0-68-with-import-from-iis-and-w3c-log-files-259842
permalink: /elmah-io-cli-4-0-68-with-import-from-iis-and-w3c-log-files-259842/
---

There's a new command in the elmah.io CLI named `import`. With `import` you can easily import one, more, and even parts of IIS and W3C log files in an elmah.io of your choice. The command can be executed like this:

```
elmahio import --apiKey API_KEY --logId LOG_ID --type iis --filename u_inetsv1.log
```

The [Documentation](https://docs.elmah.io/cli-import/) has been updated to include the new `import` command. As always, the CLI can be installed by running the following command:

```
dotnet tool install --global Elmah.Io.Cli
```
