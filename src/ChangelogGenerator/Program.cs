using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using Markdig;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var repoRoot = FindRepoRoot(Directory.GetCurrentDirectory());
var entriesDir = Path.Combine(repoRoot, "entries");
var imagesDir = Path.Combine(repoRoot, "images");
var siteDir = Path.Combine(repoRoot, "site");
const int pageSize = 20;

if (Directory.Exists(siteDir))
    Directory.Delete(siteDir, recursive: true);
Directory.CreateDirectory(siteDir);

var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
var deserializer = new DeserializerBuilder()
    .WithNamingConvention(CamelCaseNamingConvention.Instance)
    .IgnoreUnmatchedProperties()
    .Build();

var entries = Directory.GetFiles(entriesDir, "*.md")
    .Select(path => ParseEntry(path, deserializer, pipeline))
    .OrderByDescending(e => e.Date)
    .ToList();

Console.WriteLine($"Loaded {entries.Count} entries.");

foreach (var entry in entries)
    WriteEntryPage(entry, siteDir);

WriteIndexPages(entries, siteDir, pageSize);
WriteFeedJson(entries, siteDir);
CopyDirectory(imagesDir, Path.Combine(siteDir, "images"));

var cnamePath = Path.Combine(repoRoot, "CNAME");
if (File.Exists(cnamePath))
    File.Copy(cnamePath, Path.Combine(siteDir, "CNAME"), overwrite: true);

Console.WriteLine($"Site generated at {siteDir}");

static string FindRepoRoot(string start)
{
    var dir = new DirectoryInfo(start);
    while (dir is not null)
    {
        if (Directory.Exists(Path.Combine(dir.FullName, "entries")))
            return dir.FullName;
        dir = dir.Parent;
    }
    throw new DirectoryNotFoundException($"Could not find a repo root (directory containing 'entries/') starting from {start}");
}

static Entry ParseEntry(string path, IDeserializer deserializer, MarkdownPipeline pipeline)
{
    var text = File.ReadAllText(path);
    if (!text.StartsWith("---", StringComparison.Ordinal))
        throw new InvalidDataException($"{path}: missing front matter");

    var closingFenceIndex = text.IndexOf("\n---", 3, StringComparison.Ordinal);
    if (closingFenceIndex < 0)
        throw new InvalidDataException($"{path}: unterminated front matter");

    var yaml = text[3..closingFenceIndex].Trim();
    var bodyStart = text.IndexOf('\n', closingFenceIndex + 4);
    var bodyMarkdown = bodyStart >= 0 ? text[(bodyStart + 1)..].TrimStart('\n') : "";

    var fm = deserializer.Deserialize<FrontMatter>(yaml) ?? new FrontMatter();
    if (string.IsNullOrWhiteSpace(fm.Slug))
        throw new InvalidDataException($"{path}: missing slug in front matter");

    return new Entry(
        Slug: fm.Slug,
        Title: fm.Title,
        Date: fm.Date,
        Categories: fm.Categories ?? new List<string>(),
        BodyMarkdown: bodyMarkdown,
        BodyHtml: Markdown.ToHtml(bodyMarkdown, pipeline));
}

static void WriteEntryPage(Entry entry, string siteDir)
{
    var dir = Path.Combine(siteDir, entry.Slug);
    Directory.CreateDirectory(dir);
    var html = Layout(
        title: entry.Title,
        bodyHtml: $"""
            <article class="entry">
              <a class="back" href="/">&larr; All changes</a>
              <h1>{Html(entry.Title)}</h1>
              {MetaLine(entry)}
              <div class="body">{entry.BodyHtml}</div>
            </article>
            """);
    File.WriteAllText(Path.Combine(dir, "index.html"), html);
}

static void WriteIndexPages(List<Entry> entries, string siteDir, int pageSize)
{
    var pageCount = (int)Math.Ceiling(entries.Count / (double)pageSize);
    for (var page = 1; page <= pageCount; page++)
    {
        var pageEntries = entries.Skip((page - 1) * pageSize).Take(pageSize);
        var cards = string.Join("\n", pageEntries.Select(e => $"""
            <article class="card">
              <a href="/{e.Slug}/"><h2>{Html(e.Title)}</h2></a>
              {MetaLine(e)}
              <div class="body">{e.BodyHtml}</div>
            </article>
            """));

        var nav = PaginationNav(page, pageCount);
        var html = Layout(
            title: page == 1 ? "elmah.io changelog" : $"elmah.io changelog - page {page}",
            bodyHtml: $"""
                <h1><a href="/">elmah.io changelog</a></h1>
                {cards}
                {nav}
                """);

        var outDir = page == 1 ? siteDir : Path.Combine(siteDir, "page", page.ToString(CultureInfo.InvariantCulture));
        Directory.CreateDirectory(outDir);
        File.WriteAllText(Path.Combine(outDir, "index.html"), html);
    }
}

static string PaginationNav(int page, int pageCount)
{
    var parts = new List<string>();
    if (page < pageCount)
    {
        var nextHref = page + 1 == 1 ? "/" : $"/page/{page + 1}/";
        parts.Add($"<a class=\"older\" href=\"{nextHref}\">Show previous changelogs &darr;</a>");
    }
    if (page > 1)
    {
        var prevHref = page - 1 == 1 ? "/" : $"/page/{page - 1}/";
        parts.Add($"<a class=\"newer\" href=\"{prevHref}\">&uarr; Newer changes</a>");
    }
    return parts.Count == 0 ? "" : $"<nav class=\"pagination\">{string.Join("", parts)}</nav>";
}

static void WriteFeedJson(List<Entry> entries, string siteDir)
{
    var feed = entries.Take(10).Select(e => new
    {
        slug = e.Slug,
        title = e.Title,
        date = e.Date.ToString("O"),
        category = e.Categories.FirstOrDefault()
    });
    var json = JsonSerializer.Serialize(feed, new JsonSerializerOptions
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    });
    File.WriteAllText(Path.Combine(siteDir, "feed.json"), json);
}

static void CopyDirectory(string source, string destination)
{
    if (!Directory.Exists(source))
        return;
    Directory.CreateDirectory(destination);
    foreach (var file in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
    {
        var relative = Path.GetRelativePath(source, file);
        var destPath = Path.Combine(destination, relative);
        Directory.CreateDirectory(Path.GetDirectoryName(destPath)!);
        File.Copy(file, destPath, overwrite: true);
    }
}

static string MetaLine(Entry entry)
{
    var category = entry.Categories.FirstOrDefault();
    var badge = category is null ? "" : $"<span class=\"badge badge-{category.ToLowerInvariant()}\">{Html(category)}</span>";
    var date = entry.Date.ToString("MMMM d, yyyy", CultureInfo.InvariantCulture);
    return $"<div class=\"meta\">{badge}<time datetime=\"{entry.Date:O}\">{date}</time></div>";
}

static string Html(string text) => System.Net.WebUtility.HtmlEncode(text);

static string Css() => """
    :root { color-scheme: light dark; }
    body { font-family: -apple-system, Segoe UI, Roboto, Helvetica, Arial, sans-serif; max-width: 720px; margin: 0 auto; padding: 2rem 1.25rem 4rem; line-height: 1.6; color: #1b1f23; background: #fff; }
    @media (prefers-color-scheme: dark) { body { color: #e6e6e6; background: #14181c; } a { color: #6cb6ff; } }
    a { color: #0f6fde; text-decoration: none; }
    a:hover { text-decoration: underline; }
    h1 { font-size: 1.5rem; margin-bottom: .25rem; }
    h1 a { color: inherit; }
    .card, .entry { padding: 1.5rem 0; border-bottom: 1px solid rgba(128,128,128,.25); }
    .card h2 { font-size: 1.15rem; margin: 0 0 .25rem; color: inherit; }
    .back { display: inline-block; margin-bottom: 1rem; font-size: .9rem; }
    .meta { font-size: .85rem; opacity: .7; margin-bottom: .5rem; display: flex; gap: .5rem; align-items: center; }
    .badge { display: inline-block; padding: .1rem .5rem; border-radius: 1rem; font-size: .75rem; font-weight: 600; color: #fff; }
    .badge-new { background: #3778ff; }
    .badge-improvement { background: #16a085; }
    .badge-fix { background: #e74c3c; }
    .body img { max-width: 100%; border-radius: 6px; }
    .body pre { overflow-x: auto; padding: .75rem; background: rgba(128,128,128,.12); border-radius: 6px; }
    .pagination { margin-top: 2rem; display: flex; justify-content: space-between; font-size: .9rem; }
    """;



static string Layout(string title, string bodyHtml) => $"""
    <!doctype html>
    <html lang="en">
    <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <title>{Html(title)}</title>
      <link rel="icon" href="https://elmah.io/favicon.ico">
      <style>
    {Css()}
      </style>
    </head>
    <body>
      {bodyHtml}
    </body>
    </html>
    """;

record Entry(string Slug, string Title, DateTimeOffset Date, List<string> Categories, string BodyMarkdown, string BodyHtml);

class FrontMatter
{
    public string Title { get; set; } = "";
    public DateTimeOffset Date { get; set; }
    public List<string>? Categories { get; set; }
    public string Slug { get; set; } = "";
}
