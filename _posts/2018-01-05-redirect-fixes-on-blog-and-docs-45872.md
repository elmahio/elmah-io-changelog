---
title: "Redirect fixes on blog and docs"
date: 2018-01-05T08:22:16Z
categories: [Fix]
slug: redirect-fixes-on-blog-and-docs-45872
permalink: /redirect-fixes-on-blog-and-docs-45872/
---

The redirect issues on our blog and documentation site have been fixed. I don't believe that this is of interest to anyone, but the solution may be. We are hosting both the [blog](https://blog.elmah.io/) and the [documentation](https://docs.elmah.io/) site on GitHub Pages. Since Pages doesn't support SSL certificates for custom domains, we have developed a reverse proxy ([open sourced here](https://github.com/elmahio/Elmah.Io.ReverseProxy)), hosted on Azure in front of each site.

The first fixed problem were in a custom IIS rewrite rule in the proxy, in order to redirect requests from HTTP to HTTPS. The rule worked on all pages except the frontpage. Switching to the Azure solution, redirect now works everywhere:

![httpsonly.png](/images/45872/253-e8720bb6700b26fde0943ef85e780c9371a0b972.png)

The second problem were a bad redirect caused by GitHub Pages. Pages automatically append a trailing slash when omitted. But it redirect to the *.github.io URL rather than the domain name of the proxy. Addind a new redirect rule directly in the proxy fixed this:

```xml
<rule name="Add Trailing Slash" stopProcessing="true">
  <match url=".*[^/]$" />
  <conditions logicalGrouping="MatchAll" trackAllCaptures="false">
    <add input="{REQUEST_FILENAME}" pattern=".+?\.\w+$" negate="true" />
    <add input="{REQUEST_FILENAME}" matchType="IsDirectory" negate="true" />
    <add input="{REQUEST_FILENAME}" matchType="IsFile" negate="true" />
  </conditions>
  <action type="Redirect" url="{ToLower:{R:0}}/" />
</rule>
```
