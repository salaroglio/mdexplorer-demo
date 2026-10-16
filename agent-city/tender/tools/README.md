---
title: Tender tools
---

# Tender tools

## TL;DR

Programs the agents run when a job must be exact and repeatable, instead of doing it in words.

- `download-tender-document.mjs <code>`: downloads the tender document of the call for tenders from the Nordica portal into
  `../tender-documents/<code>-specification.md`. If the call for tenders has no attached document, it stops and says so.
- They need Node.js (it is already there wherever Copilot and Claude Code run) and no packages.

Try it by hand, from the root of the project:

```bash
node agent-city/tender/tools/download-tender-document.mjs NC-2027-014
```
