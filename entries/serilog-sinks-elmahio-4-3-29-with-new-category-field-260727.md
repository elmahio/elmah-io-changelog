---
title: "Serilog.Sinks.ElmahIo 4.3.29 with new Category field"
date: 2023-03-22T11:34:26Z
categories: [New]
slug: serilog-sinks-elmahio-4-3-29-with-new-category-field-260727
---
We released a new version ([4.3.29](https://www.nuget.org/packages/Serilog.Sinks.ElmahIo/4.3.29)) of the `Serilog.Sinks.ElmahIo` NuGet package. The new version includes the following changes:

- Set new Category property from category property or SourceContext.
- Migrated from extending `PeriodicBatchingSink` to implementing `IBatchedLogEventSink` (`Serilog.Sinks.PeriodicBatching` >= 3.1.0 needed).
- Running on the newest version of `Elmah.Io.Client`.
