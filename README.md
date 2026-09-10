# elmah.io changelog

Source for [changelog.elmah.io](https://changelog.elmah.io), published as markdown instead
of through a third-party changelog SaaS. Built with [Jekyll](https://jekyllrb.com/) and
served by GitHub Pages, which builds and deploys it automatically on every push to `main`
(no CI workflow needed).

## Adding an entry

Add a new file under `_posts/`, named `YYYY-MM-DD-your-slug.md` (the date prefix is Jekyll's
`_posts` convention; the actual published URL comes from `permalink` below, not the filename):

```markdown
---
title: My new feature
date: 2026-09-10T12:00:00Z
categories: [New]
permalink: /my-new-feature/
---
Description of the change, in markdown. Images go under `images/<id-or-topic>/` and are
referenced with a root-relative path, e.g. `/images/my-new-feature/screenshot.png`.
```

`categories` is one of `[New]`, `[Improvement]`, `[Fix]`, or `[]` for none.

## Local preview

Requires Docker (avoids installing Ruby locally):

```sh
docker run --rm -it -v "${PWD}:/srv/jekyll" -p 4000:4000 jekyll/jekyll jekyll serve
```

Then open http://localhost:4000.
