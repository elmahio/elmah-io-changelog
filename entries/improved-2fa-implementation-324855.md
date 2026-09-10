---
title: "Improved 2FA implementation"
date: 2025-10-10T09:08:30Z
categories: [Improvement]
slug: improved-2fa-implementation-324855
---
We've updated the two-factor authentication (2FA) implementation on elmah.io to improve both security and usability. The new version includes:

- Regenerated secrets for each setup. You now need to scan the QR code again whenever you re-enable 2FA.
- Streamlined enable/disable flow for a smoother user experience.
- One-time token validation to prevent reuse of old authentication codes.

To take advantage of the new implementation, we recommend disabling and then re-enabling 2FA on your account. When doing so, create a new account entry in your authenticator app, as previously stored entries will no longer work.
