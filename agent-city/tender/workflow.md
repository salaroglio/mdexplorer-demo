---
mde_type: workflow
title: How they pass the work
workflow: tender.workflow.json
---

# How they pass the work

## TL;DR

This document says how the people of the tender and their agents pass the work to each other: who starts each agent, what
it receives, who approves and who decides. The plan is in [tender.workflow.json](tender.workflow.json) and the agent cards
say what each piece of work receives, reads and delivers: MdExplorer joins them, runs them and draws the diagram below.

- The account manager begins the round: they launch the search and press «Start the round» on the call for tenders; each
  lead starts their own sheet, with the tender document and the search in the assignment.
- The synthesis starts on its own when all three sheets are approved; then the account manager decides whether to bid, with
  a button.
- A rejected sheet is redone when the person presses «Restart», with no limit on the number of times.

## The round

```plantuml(@workflow, ./tender.workflow.json)
```

Each box is a turn of work: the name in bold is the step, below it is the agent; the white box with the person is the
account manager's decision. The figures are the roles of [responsibilities.md](responsibilities.md), with what they do:
launch, start, approve. In green the documents a piece of work reads, in lilac those it delivers; a hexagon is a button, an
outcome or a wait. A click on a box opens the agent's card, one on a file opens the document.

The diagram is not drawn by hand: if the plan, a card or the roles change, MdExplorer draws it again.

## Who decides and who writes

| What | Where it is |
|---|---|
| Who answers for which agent | [responsibilities.md](responsibilities.md) |
| How they pass the work (this document) | [tender.workflow.json](tender.workflow.json) |
| What each piece of work receives, reads and delivers | its card, in `.github/agents/` (the `a2a:` block) |
| How each agent does its job | its card, the text below the block |
| What happened in each round | the round log, on the `mde/giri` branch of the repository |

[The tender case](README.md) · [Section index](../README.md)
