---
title: "Link to search results from Bugster and UI improvements"
date: 2026-05-25T15:24:01Z
categories: [New]
slug: link-to-search-results-from-bugster-and-ui-improvements-338497
---
We have extended Bugster to include links to search results when log messages are used as input for an answer. Like the direct links beneath *Related log messages*, the new *Search results* section will let you navigate directly to the *Search* page. So, for example, when asking about new errors, you'd get a link to a search result showing all log messages with a `isNew` flag set to `true` and `severity` set to `Error`.

We also used the occasion to make a few UI changes in the Bugster view. Among other improvements, the answer is not generated directly after the question, instead of using up space for speech bubbles. This also aligns with how popular chat clients like Claude and ChatGPT look.

![Link to search results from Bugster and UI improvements](/images/338497/228-5975dcba02e1e8c2862585c74cf63d0acfb1fa5f.png)
