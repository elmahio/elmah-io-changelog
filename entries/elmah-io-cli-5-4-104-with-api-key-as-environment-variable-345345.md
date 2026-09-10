---
title: "Elmah.Io.Cli 5.4.104 with API key as environment variable"
date: 2026-09-01T11:18:12Z
categories: [New]
slug: elmah-io-cli-5-4-104-with-api-key-as-environment-variable-345345
---
We released a [new version](https://www.nuget.org/packages/Elmah.Io.Cli/5.4.104) of the [elmah.io CLI](https://docs.elmah.io/cli-overview/). The new version contains the following changes:

- Allow setting the API key as an environment variable instead of providing an `--apiKey` parameter or calling `login`.
- Fixed a security issue while storing the API key on disk.

The [documentation](https://docs.elmah.io/cli-login/#using-an-environment-variable-instead) has been updated to show the use of the new environment variable.
