---
title: New MCP server tool to see when errors started
date: 2026-11-18T06:00:00Z
categories: [New]
permalink: /new-mcp-server-tool-to-see-when-errors-started/
---

The MCP server has a new tool: `messages_histogram`. It counts messages per hour, day, or week, so an AI client can answer questions like "when did this error start?" and "did it get worse after the last deployment?" without fetching messages and counting them itself. Until now, `messages_count` only returned a single total.

The tool takes the same filters as `messages_count` (`severity`, `query`, `from`, `to`, and `hidden`) plus an `interval` of `hour`, `day`, or `week`. Without an interval, one is picked from the date range. Buckets with no messages are included with a count of 0, so a quiet day shows up as a gap rather than disappearing. A single call returns at most 200 buckets. If the range would need more, the response asks for a shorter range or a larger interval.

The [documentation](https://docs.elmah.io/setup-mcp-server/#available-tools) has been updated to include the new tool.
