---
title: "Elmah.Io.Client now obfuscates passwords (breaking change)"
date: 2018-12-03T11:31:13Z
categories: [Improvement]
slug: elmah-io-client-now-obfuscates-passwords-(breaking-change)-81942
---
We've released a new version of `Elmah.Io.Client` ([3.3.57](https://www.nuget.org/packages/elmah.io.client/3.3.57)), the package that most of our integrations use to communicate with api.elmah.io. The client now automatically obfuscates passwords in form variables logged as part of HTTP POSTs. Out of the box, keys named `password` or `pwd` are obfuscated. You can add additional keys like this:

```csharp
var client = ElmahioAPI.Create("API_KEY");
client.Options.FormKeysToObfuscate.Add("my-very-secret-form-variable");
```

Obfuscation can be disabled like this (we don't recommend you to do so):

```csharp
var client = ElmahioAPI.Create("API_KEY");
client.Options.FormKeysToObfuscate.Clear();
```

This is a breaking change that will enforce when you install the new version. You usually don't install `Elmah.Io.Client` manually, since integrations have a dependency which automatically pulls and reference the package. To upgrade to the new package, you can either wait until your integration updates its dependency to `Elmah.Io.Client` or update the package manually:

```ps
Update-Package Elmah.Io.Client
```
