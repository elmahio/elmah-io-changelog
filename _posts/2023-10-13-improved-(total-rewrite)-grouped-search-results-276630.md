---
title: "Improved (total rewrite) grouped search results"
date: 2023-10-13T09:09:27Z
categories: [New]
slug: improved-(total-rewrite)-grouped-search-results-276630
permalink: /improved-(total-rewrite)-grouped-search-results-276630/
---

There's a brand new view for showing grouped log messages. In fact, we rewrote the entire grouped search based on ideas we received from you guys and had ourselves. Grouped search results now closer correspond to what you'd expect when picking something in the group by dropdown on the log search page.

When grouping the search result you will now get a list of grouped log messages based on the grouping key. As a default, the groups will be sorted by groups with the most log messages first (minus grouping by date which will sort the groups by date). No more having to hit the *Load more* button multiple times to get an overview.

In addition, we introduce a new header for a group, combining the navigation between log messages in the group, with overall information for the group. This information includes a chart, some date statistics, as well as affected users and browsers by this group.

![image.png](/images/276630/301-fffdec564dafb3296bbecc8ed268987c7807c94d.png)

We hope that you like the changes introduced here. Since everything is a total rewrite, we probably need to tweak this moving forward. Your feedback would be very much appreciated in this process. One idea that we are already working on is to switch the i integrations/apps over to using the new grouped view. When doing so, creating an issue in your favorite issue tracker would contain a link to all instances of an error (the group) and not just the first instance.
