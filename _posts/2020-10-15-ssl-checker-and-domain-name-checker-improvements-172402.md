---
title: "SSL Checker and Domain Name Checker improvements"
date: 2020-10-15T11:32:00Z
categories: [Improvement]
slug: ssl-checker-and-domain-name-checker-improvements-172402
permalink: /ssl-checker-and-domain-name-checker-improvements-172402/
---

We pushed new versions of the SSL Checker and Domain Name Checker, part of elmah.io Uptime Monitoring. Both checkers have been improved in the way they mark logged errors as new. When logging issues about an SSL certificate or domain name that has already been logged, additional errors are no longer logged as new. As soon as the SSL certificate gets a new thumbprint or the domain name a new expires date, issues will be marked as new.

In addition, more checks have been added to the SSL Checker. Misconfigured hostnames and chain issues (like an untrusted root or problems with self-signed certificates) will now also cause errors to be logged.
