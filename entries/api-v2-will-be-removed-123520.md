---
title: "API v2 will be removed"
date: 2019-10-21T06:34:07Z
categories: []
slug: api-v2-will-be-removed-123520
---
We are removing the old [elmah.io v2 API](https://elmah.io/api/v2). The API has been deprecated for two years now, and it is time for a cleanup. The old API will be closed down on April 13th, 2020. If you have already switched to the new API, you don't need to do anything else.

To see which major API version you are using, check out the version number of the elmah.io NuGet package you currently have installed. The major version of the NuGet package follows the major version of the API. 

Examples:

- Elmah.Io version 3.4.60 - uses API v3 🙌
- Elmah.Io version 2.0.20 - uses API v2 😱
- Elmah.Io.AspNetCore version 3.7.86 - uses API v3 🙌
- Elmah.Io.Client version 2.0.29 - uses API v2 😱

Installations that target the old API after April 13th will stop logging messages to elmah.io why now is an excellent time to switch. There is an [Upgrade elmah.io from v2 to v3](https://docs.elmah.io/upgrade-elmah-io-from-v2-to-v3/) guide available, and our support can help you with any other questions you may have.
