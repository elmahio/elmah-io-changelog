---
title: Uptime checks for MCP servers
date: 2026-11-02T06:00:00Z
categories: [New]
permalink: /uptime-checks-for-mcp-servers/
---

You can now monitor MCP servers with uptime checks. Choose MCP as the type when creating an uptime check, enter the URL of your MCP endpoint, and add an `Authorization` header with the value `Bearer your-token` if your server requires one. Click Connect to MCP Server to list the tools on your server and pick the one to monitor.

On every run, each region connects to your server, verifies that the tool still exists, and calls it without arguments. The check fails if the server is unreachable, rejects the credentials, no longer has the tool, or the tool returns an error.

MCP checks are in beta and count toward the uptime check limit of your plan, like HTTP checks. Learn more in the [documentation](https://docs.elmah.io/monitor-mcp-servers-with-uptime-checks/) or on the [MCP server monitoring](https://elmah.io/ai/mcp-monitoring/) page.
