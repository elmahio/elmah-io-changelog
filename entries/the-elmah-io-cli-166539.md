---
title: "The elmah.io CLI"
date: 2020-08-31T13:02:42Z
categories: [New]
slug: the-elmah-io-cli-166539
---
We released the first version of the [elmah.io CLI](https://github.com/elmahio/Elmah.Io.Cli). The CLI will help you carry out common tasks like exporting data from elmah.io or tailing a log - all from the command line. Currently, three commands are available:

- `export`: Export log messages from a specified log (the Elmah.Io.Exporter tool will be deprecated in favor of this)
- `log`: Log a message to the specified log
- `tail`: Tail log messages from a specified log

The CLI can be installed from either [GitHub](https://github.com/elmahio/Elmah.Io.Cli/releases/) or as a .NET global tool:

```cmd
dotnet tool install --global Elmah.Io.Cli
```

To launch the tool run the `elmahio` command:

```cmd
elmahio --help
```

The [documentation](https://docs.elmah.io/cli-overview/) has been updated with a description of the tool as well as all available commands.
