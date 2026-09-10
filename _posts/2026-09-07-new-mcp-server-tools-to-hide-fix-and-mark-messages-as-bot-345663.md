---
title: "New MCP server tools to hide, fix, and mark messages as bot"
date: 2026-09-07T08:42:05Z
categories: []
slug: new-mcp-server-tools-to-hide-fix-and-mark-messages-as-bot-345663
permalink: /new-mcp-server-tools-to-hide-fix-and-mark-messages-as-bot-345663/
---

The MCP server now exposes six new tools for managing log messages: `messages_hide`, `messages_unhide`, `messages_fix`, `messages_open`, `messages_bot`, and `messages_unbot`. These let an AI client hide noisy messages, mark errors as fixed (or reopen them), and flag messages as bot traffic (or undo that), directly from a conversation with Claude, Codex, or another MCP client.

`messages_hide`, `messages_fix`, and `messages_open` accept an optional flag to apply the change to every other message sharing the same grouping hash, while `messages_bot` and `messages_unbot` take a list of up to 500 message IDs per call. All six tools only act when a user has explicitly asked for that specific change, never speculatively while an AI is just investigating errors.

The [documentation](https://docs.elmah.io/setup-mcp-server/#available-tools) has been updated to include the new tools.
