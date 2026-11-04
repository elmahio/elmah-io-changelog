---
title: New MCP server tools to mark messages as bot by query
date: 2026-11-04T06:00:00Z
categories: [New]
permalink: /new-mcp-server-tools-to-mark-messages-as-bot-by-query/
---

The MCP server has two new tools: `messages_bot_by_query` and `messages_unbot_by_query`. They mark (or unmark) every message matching a query as bot traffic, without the AI client having to pass a list of message IDs. This makes it practical to flag a whole group in one call, like thousands of 404s from a single client IP, which previously meant paging through the messages and sending IDs back 500 at a time.

Both tools take a required `severity` and `query`, using the same Lucene syntax as `messages_list_recent`, plus optional `from`, `to`, and `hidden` filters. Messages already marked as bot are skipped, and match-all queries like `*` are rejected. A single call updates up to 10,000 messages by default, controlled by the `maxMessages` parameter (maximum 50,000). If more messages match, the response says so and the call can be repeated. Like the other write tools, they only act when a user has explicitly asked for that change.

The [documentation](https://docs.elmah.io/setup-mcp-server/#available-tools) has been updated to include the new tools.
