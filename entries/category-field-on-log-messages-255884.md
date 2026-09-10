---
title: "Category field on log messages"
date: 2023-01-25T08:30:27Z
categories: [New]
slug: category-field-on-log-messages-255884
---
There's a new field on all log messages named `Category`. This may sound like a minor addition but it's actually something that is available throughout a larger part of elmah.io. The category field can be set on all log messages stored through the API. The field and value show up inside the elmah.io UI on the details:

![Category](/images/255884/093-21895ddc62a0a782eb50ce77966fca118236fd9a.png)

Unless you are logging messages manually through the API or the `Elmah.Io.Client` package, you typically don't need to set the field. New prereleases have been published of the `Elmah.Io.Extensions.Logging`, `Elmah.Io.NLog`, `Elmah.Io.Log4Net`, and `Serilog.Sinks.ElmahIo` NuGet packages. These integrations automatically pick up the category from the logging framework and set the new field. Having a category or logger name is something common for all logging frameworks. We have adopted the name from Microsoft.Extensions.Logging which calls it *Category*, NLog and log4net call it *LoggerName*, and Serilog calls it *SourceContext*.

Besides being available as a field on the log message details, Category can be used from the search field, search filters, the group by dropdown, as a column on the search result, and as part of rules.
