---
title: "Elmah.Io.Cli 5.3.102 with multiple new commands"
date: 2026-04-08T12:30:00Z
categories: [New]
slug: elmah-io-cli-5-3-102-with-multiple-new-commands-335151
---
We released a [new version](https://www.nuget.org/packages/Elmah.Io.Cli/5.3.102) of the [elmah.io CLI](https://docs.elmah.io/cli-overview/). The new version contains a general restructure of commands, as well as a range of new commands like:

```
elmahio messages list-recent
elmahio messages list-frequent
elmahio logs list
```

And a few more. Be aware that you may now receive a deprecation warning if you are using root commands like `elmahio log` since many commands have been migrated to sub-commands. The deprecation warning will highlight which command to use instead, and the [documentation](https://docs.elmah.io/cli-overview/) is fully updated.

Thanks to jasonnissen for doing most of the work in [this PR](https://github.com/elmahio/Elmah.Io.Cli/pull/2).
