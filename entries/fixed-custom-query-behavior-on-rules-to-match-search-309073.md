---
title: "Fixed custom query behavior on rules to match search"
date: 2025-02-05T09:36:11Z
categories: [Fix]
slug: fixed-custom-query-behavior-on-rules-to-match-search-309073
---
We have fixed two inconsistencies between queries inputted on the search page and when creating rules with custom queries.

- Using Wildcards has always been supported on the search page but not in queries. This is now fully supported in rule queries as well.
- When searching for multiple terms (like: `search query`) the search page uses `AND` meaning that both the term `search` and `query` would need to be found in a log message to show up. Rule queries have been aligned to use the same approach.

What does this mean for you? Current custom queries in rules are left untouched, meaning they work with the old approach. You don't need to do anything if you are happy with your current rules. Next time you update a rule, the rule will be moved to the new implementation. Make sure to check a custom query before saving a rule next time. The good news here is that you will now be able to copy the query and paste it into the search field and be sure your rule will match the same result as shown in the search result.
