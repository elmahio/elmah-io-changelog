---
title: "API key authentication on the MCP server"
date: 2026-06-01T06:31:06Z
categories: [New]
slug: api-key-authentication-on-the-mcp-server-338801
permalink: /api-key-authentication-on-the-mcp-server-338801/
---

The MCP server now supports authentication through an elmah.io API key. This makes it possible to integrate with the MCP from automated processes like a remote agent, a build pipeline, and similar. When using an API key, your requests run in the context of your organization and not your user. To fully understand the differences and how to set it up, read through the new documentation here: [Call MCP Server Using an API Key](https://docs.elmah.io/call-mcp-server-using-api-key/).

We also added an overview of all available tools here: [Available tools](https://docs.elmah.io/setup-mcp-server/#available-tools).
