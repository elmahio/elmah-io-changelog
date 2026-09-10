---
title: "Rolling back OpenAPI to Swagger"
date: 2020-08-06T08:12:44Z
categories: []
slug: rolling-back-openapi-to-swagger-162850
---
We recently upgraded our API from Swagger v2 to OpenAPI v3. The upgrade was transparent to the clients, meaning that all existing versions worked on the new endpoints. We had to roll back to Swagger today since we found out that AutoRest (the tool we use to generate the `Elmah.Io.Client` package) doesn't support OpenAPI v3 yet. No changes are required from your side.
