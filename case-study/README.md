---
title: The case study
---

# The case study: an AI assistant for the help desk

> **TL;DR** — Alpina Servizi is a made-up company that wants to try an AI assistant for its help desk.
> This folder holds the documents of the pilot project, written the way a real team would write them.
> Use it to try MdExplorer and MarkAgent on something that looks like everyday work.

## The documents

| Document | Written by | What it holds |
|---|---|---|
| [Goals and requirements](01-goals-and-requirements.md) | pilot lead | why it is done, what the assistant must do |
| [Architecture](02-architecture.md) | information systems | the components, the path of a ticket, the data |
| [Pilot plan](03-pilot-plan.md) | pilot lead | phases, calendar, metrics, risks |
| [Minutes of 18 September](minutes/2026-09-18-steering-committee.md) | pilot lead | decisions and actions of the steering committee |
| [Slides for the committee](committee-slides.md) | pilot lead | the presentation for the next meeting |

Next to the documents there are two files the documents use without copying them:

- `data/target-metrics.json`, the numbers of the pilot;
- `mockup/operator-panel.html`, the prototype of the operator's screen.

## The challenge: three inconsistencies

The documents were written at different times by different people, and they do not all say the same thing.
There are **three inconsistencies**, placed on purpose. It happens in every real project.

Ask MarkAgent to find them:

> Compare requirements, architecture, plan and minutes of the case study. Which inconsistencies do you find?
> For each one, cite the document and the place.

Then ask it to fix them, and look in the "Changes" tab at what it changed before you accept.

## Other things to ask

> Summarise in five lines where the pilot stands and what is still to be decided.

> Write the minutes of the committee of 23 October starting from the slides, with the decisions still to be taken.

> Add to the architecture a sequence diagram of the anonymisation decided in the minutes.

How MarkAgent works is explained in [MarkAgent](../tour/03-markagent.md).

[Back to the start](../README.md)
