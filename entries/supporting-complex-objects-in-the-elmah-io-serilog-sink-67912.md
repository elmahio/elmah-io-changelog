---
title: "Supporting complex objects in the elmah.io Serilog sink"
date: 2018-08-02T07:26:04Z
categories: [Improvement]
slug: supporting-complex-objects-in-the-elmah-io-serilog-sink-67912
---
We just released a [new version](https://www.nuget.org/packages/Serilog.Sinks.ElmahIO/3.1.0) of our Serilog sink. The dependency to `Elmah.Io.Client` has been updated to the most recent version to avoid problems when installing the sink in ASP.NET Core. We also support log messages through the `SelfLog` class, in case something fails inside the sink.

Besides the small changes already mentioned, the sink now supports complex objects and descructoring. Properties inside structured log messages in Serilog, have always been visible as a simple `ToString` in the Data tab of the error details on elmah.io. With the new version of the sink, we now support list, dictionaries and complex objects. Let's look at an example:

```csharp
var complex = new
{
    Hello = "World",
    Foo = new
    {
        Bar = true
    }
});
Log.Information("Logging {scalar} and {@complex} types", 42, complex);
```

Previously, we would show a simple `ToString` of both `scalar` and `@complex` (even though you told Serilog to destructure `@complex`). With the new sink, complex objects are now shown as you would expect:

![Destructored object](/images/67912/252-5815c3722836eb4d87b9dbfa36034a5df42b1de0.png)
