---
title: "New Recommendations feature"
date: 2026-01-09T07:14:51Z
categories: [New]
slug: new-recommendations-feature-329655
---
You may have already noticed the new *Recommendations* tab on the log search page. Recommendations is a new concept on elmah.io that we silently launched some time ago. Recommendations are intended as a list of suggestions and best practices for your website, domain, and other relevant areas, identified through various elmah.io features. In the past, we have logged recommendations as log messages, which caused the messages to disappear among regular logging.

Recommendations are found on the log search page:

![New Recommendations feature](/images/329655/023-79b3003499d19b61181def1dbf76fdecf5080f99.png)

Suggestions already migrated to recommendations are:

- SSL Score decreased
- Domain name expires/expired
- Canonical checks

We still log both a log message and a recommendation on these issues, but the plan is to move entirely to recommendations once the feature is fully rolled out.

In the future, new types of recommendations will be added. These could be suggestions for optimizing logging config in your clients, failing apps and integrations, changes in Lighthouse score, and more.
