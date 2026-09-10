# elmah.io changelog

Source for [changelog.elmah.io](https://changelog.elmah.io), published as markdown instead
of through a third-party changelog SaaS.

## Adding an entry

Add a new file under `entries/`, named after the URL you want (e.g. `entries/my-new-feature.md`):

```markdown
---
title: My new feature
date: 2026-09-10T12:00:00Z
categories: [New]
slug: my-new-feature
---
Description of the change, in markdown. Images go under `images/<slug-or-id>/` and are
referenced with a root-relative path, e.g. `/images/my-new-feature/screenshot.png`.
```

`categories` is one of `[New]`, `[Improvement]`, `[Fix]`, or `[]` for none.

Pushing to `main` builds the site (`src/ChangelogGenerator`) and publishes it to GitHub Pages.
