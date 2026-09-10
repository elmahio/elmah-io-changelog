---
title: "New hidden filter on message tools on MCP server"
date: 2026-08-06T11:25:57Z
categories: [New]
slug: new-hidden-filter-on-message-tools-on-mcp-server-343630
permalink: /new-hidden-filter-on-message-tools-on-mcp-server-343630/
---

The `messages_list_recent`, `messages_list_frequent`, and `messages_count` tools on the MCP server have been extended to include a new `hidden` filter. This will make it possible for the AI client to filter log messages based on whether they are hidden or not. Previously, all log messages were returned, no matter if they were marked as hidden or not. Having a default value of `false`, this means that the behavior now changes to filter out hidden messages by default.
