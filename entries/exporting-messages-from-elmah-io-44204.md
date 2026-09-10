---
title: "Exporting messages from elmah.io"
date: 2017-12-17T19:25:14Z
categories: [New]
slug: exporting-messages-from-elmah-io-44204
---
There's a new tool for exporting messages from elmah.io: [https://github.com/elmahio/Elmah.Io.Exporter](https://github.com/elmahio/Elmah.Io.Exporter). With the exporter tool, you can export messages to a JSON file, for processing in other tools like Microsoft Excel.

Example:

```bash
dotnet Elmah.Io.Export.dll
   -ApiKey c7e049966ddf450f8ce6aeded7b581d0
   -LogId 9f01ca78-174a-4a96-9f84-a336917a9deb
   -Filename export.json
   -DateFrom 2017-01-01
   -DateTo 2017-12-31
   -Query statusCode:500
   -IncludeHeaders
```

The tool is currently in beta, so please help us test it and create issues or pull requests on GitHub :)
