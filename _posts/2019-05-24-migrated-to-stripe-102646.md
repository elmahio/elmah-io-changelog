---
title: "Migrated to Stripe"
date: 2019-05-24T07:26:50Z
categories: [Improvement]
slug: migrated-to-stripe-102646
permalink: /migrated-to-stripe-102646/
---

Today is a day we have been waiting for a long time at elmah.io. We've successfully migrated to Stripe. I hoped to be able to move all credit card data from our old payment provider (Paymill) to Stripe automatically. It turned out not as easy as I thought, and since we don't want to get our hands on any credit card data as a file export, we've chosen another path. Stripe will charge new customers while existing customers will continue to be charged by Paymill. For the later, please go to the Subscription tab on the Organization Settings view. There's a new dialog which will guide you through a manual migration to Stripe. It requires nothing more than inputting a valid credit card. When done, Stripe will automatically charge you on the next subscription renewal.

Don't hesitate to reach out if you have questions.
