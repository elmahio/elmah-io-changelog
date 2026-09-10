# elmah.io changelog

Source for [changelog.elmah.io](https://changelog.elmah.io), published as markdown.
Built with [Jekyll](https://jekyllrb.com/) and served by GitHub Pages, which builds
and deploys it automatically on every push to `main` (no CI workflow needed).

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

### Option A: install Jekyll natively

1. Install Ruby via [rubyinstaller.org](https://rubyinstaller.org/) - pick the **Ruby+Devkit**
   version, and accept the MSYS2/build-tools step at the end of setup.
2. From this folder: `bundle install` (uses the `Gemfile`, which pins the exact Jekyll/kramdown/
   plugin versions GitHub Pages itself builds with, via the `github-pages` gem).
3. `bundle exec jekyll serve`, then open http://localhost:4000.

### Option B: Docker (no local Ruby install)

```sh
docker run --rm -it -v "${PWD}:/srv/jekyll" -p 4000:4000 jekyll/jekyll sh -c "bundle install && bundle exec jekyll serve --host 0.0.0.0"
```

Then open http://localhost:4000.
