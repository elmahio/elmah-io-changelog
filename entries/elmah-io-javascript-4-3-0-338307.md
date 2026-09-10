---
title: "Elmah.Io.JavaScript 4.3.0"
date: 2026-05-22T05:51:17Z
categories: [New]
slug: elmah-io-javascript-4-3-0-338307
---
We released a new version ([4.3.0](https://www.npmjs.com/package/elmah.io.javascript/v/4.3.0)) of the `Elmah.Io.JavaScript` package. The new version includes the following changes:

**Improved CSS selectors:**

- Added `:nth-of-type()` to differentiate identical sibling elements.
- Breadcrumbs now generate shorter paths by stopping at the first ID.
- Breadcrumbs now capture the actual text of buttons, labels, and links (e.g., [text="Save"]).
- Breadcrumbs now capture the actual values of select boxes.
- Breadcrumbs now use `data-testid`, `data-id`, `data-cy`, and `data-track` attributes to identify elements when available, resulting in shorter and cleaner paths (commonly used attributes for testing and tracking).

**SPA navigation tracking:**

- Replaced the deprecated `history.onpopstate` method.
- Added `pushState` and `replaceState` support to track route changes in modern frameworks.
