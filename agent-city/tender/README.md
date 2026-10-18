---
title: The Nordica tender
---

# The Nordica tender: four people, four agents

## TL;DR

Pentagroup, a managed services company, receives an invitation to a tender from Nordica Crediti: a specification of many pages, to
be read through different eyes (technical, legal, delivery) before deciding whether to bid. Each person has an agent that
prepares their sheet; the person checks it and approves it; at the end the account manager has a synthesis. Who works after whom is
set by the project's workflow, and MdExplorer starts it.

- Four people and four agents: the account manager and three leads (technical, legal, delivery).
- **The agents prepare, the people decide**: no work moves on to the next step without the approval of whoever answers for it;
  the hand-offs are done by MdExplorer, following the workflow.
- Everything is made up: the company, the client, the tender (derived from a real specification, rewritten) and the tender site.

## Who is there

| Person | Their agent | What it prepares | Where |
|---|---|---|---|
| **Account manager** | `account-manager` | finds the new calls for tenders and archives the search, writes the final synthesis | `searches/search-<date>.md`, `sheets/synthesis.md` |
| **Technical lead** | `technical-lead` | the technical feasibility: requirements covered and not | `sheets/technical.md` |
| **Legal lead** | `legal-lead` | the clauses: acceptable, to negotiate, critical | `sheets/contract.md` |
| **Delivery lead** | `delivery-lead` | the team and the dates: whether the timing holds | `sheets/delivery.md` |

In the demo **you play the four parts**, one after the other: it is the quickest way to see how the work passes on. In
a company each one would be a different person, on their own computer.

**Each agent answers to one person, or to a team.** It works only on the computer of whoever answers for it, and it is that person who
judges what the agent writes; as long as an agent has no owner, it does not start. Who answers for whom is written in
[Who answers for which agent](responsibilities.md): at the start the table has the four roles with nobody, and you take them
with «They are all mine».

**Each agent produces two things.** The **document** (the «Where» column), which you read and approve, and a **message** of a few
lines in the mailbox, with the indicators and the path of the document. The message says where to look, it does not replace the document.

## How it flows

The round is drawn by MdExplorer from the [tender workflow](workflow.md): it is the same plan it runs, so the drawing never
needs updating by hand. A click on a box opens the agent's card, a click on a file opens the document.

```plantuml(@workflow, ./tender.workflow.json)
```

**Before starting**, each person takes charge of their own agent: from that moment they answer for it, and the agent works
only on their computer. Then:

1. **The account manager** launches their agent: it reads the tender site, makes a first filter (the nature of the call for tenders and the time
   to respond) and writes the **search**. For each call for tenders worth a round it proposes a «Start the round on …» button.
2. The account manager approves the search and **presses the button** of the call for tenders. If an agent has more than one owner (a team),
   they choose there who will do its sheet. From this moment the hand-offs are done by MdExplorer: nobody assigns anyone by hand.
3. **Each lead** finds their sheet «to start» in the mailbox, with the assignment. They start it (with their own directions,
   if they want), decline it saying why, or pass it to a colleague in the same team.
4. The agent writes the sheet; **the lead** checks it and approves it, or rejects it and restarts it.
5. When the three sheets are approved, **the synthesis starts by itself** on the account manager's computer, with the files of the
   three sheets. The account manager approves it.
6. **The account manager decides**: in the mailbox they find «Decide whether to bid», with the synthesis, and press «We bid»
   or «We do not bid». The decision stays written in the round's log.

Every step and every gesture stays written in the **round's log**, in git, on a separate branch (`mde/giri`): each computer
reads it and does the steps of its people, without needing a server to coordinate. In the demo the four people are you,
one after the other, on a single computer.

## The files

| File | What it is |
|---|---|
| [nordica-portal/tenders.md](nordica-portal/tenders.md) | **simulates** the client's tender site: three open procedures, with the tender document attached in `nordica-portal/documents/` (the Nordica Crediti tender, ATLANTE project, rewritten and shortened) |
| [tender-register.md](tender-register.md) | the calls for tenders Pentagroup has already seen |
| [pentagroup-profile.md](pentagroup-profile.md) | who Pentagroup is, one chapter per lead, and the criteria for deciding whether to bid |
| `searches/` | the result of each search of the account manager on the portal |
| `tender-documents/` | the tender documents the account manager downloads from the portal for the compatible calls for tenders: the leads work on these |
| `tools/` | the program that downloads a tender document, run by the account manager |
| `sheets/` | the three sheets of the leads and the synthesis: the agents write them |

The agents are in [.github/agents](../../.github/agents/account-manager.agent.md): markdown files like the others. The
`a2a:` block at the top says who they are, what they do and which buttons they can propose; the text below says how they work.

## What the agents do not do

- **They do not decide and they do not pass the work to each other.** They propose; every step starts from a person's gesture (a button,
  a start, an approval) or from what the workflow says, never from an agent writing to another.
- **They do not write into the project by themselves.** Every document stays in a separate copy of the agent until you approve it.
- **They do not make things up.** If a piece of information is not in the specification or in the profile they write «to clarify»; every statement
  cites the section of the specification, so you can check it.
- **They do not run commands.** They only have the tools to read and to write their own files.

> **An honest warning.** The tender site is a project file: in a company the agent would read it with a browsing
> tool, which is not available here. The rest of the work (reading, comparison, sheets, synthesis) is the real thing.

[Back to the section](../README.md)
