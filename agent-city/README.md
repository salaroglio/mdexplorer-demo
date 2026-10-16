---
title: The agent city
---

# The agent city

## TL;DR

In MdExplorer, AI agents can live in a project, each with a name, a role and a person's job. This section lets you try
**how you work with them**: each person has their own agent, the agent prepares, the person checks and approves; who works
after whom is set by the project's workflow, and MdExplorer starts it. The case is a tender of a made-up company, Pentagroup.

- Six trials, in order, about an hour in all (most of it is waiting).
- The agents **write sheets**, but no sheet enters the project without your approval.
- You need an AI engine already set up (GitHub Copilot, Claude Code or opencode) and the network.

## The case

Pentagroup receives an invitation to a tender from Nordica Crediti: a long specification, to be read through different eyes
before deciding whether to bid. [The Nordica tender](tender/README.md) says who the four agents are, what each one does and how
the work flows: read it before you start.

## The presentations

- [An assistant for every person](presentation/agent-city.md): the idea, in eighteen slides.
- [The tender, step by step](presentation/step-by-step-guide.md): what to do and where to click, in three parts and nine
  gestures, with screenshots of today's app: the full-screen mailbox, the document opened from the agent copy, the archive.

## For those who want to know what is underneath

- [The agents' mailbox](guide/the-agents-mailbox.md). Where you read the messages, open the documents and approve the work.
- [Working in an agent copy](guide/working-in-an-agent-copy.md). How you fix what an agent wrote yourself, before approving it.
- [Who answers for which agent](tender/responsibilities.md). The table of responsibilities: an agent works only for the person
  who answers for it (or for the team).
- [How they pass the work on](tender/workflow.md). The tender workflow: who starts after whom, drawn by MdExplorer from the
  plan it runs.
- [Technical note: where the agents' work ends up](guide/technical-note-local-repository.md). Why the round never touches the
  public demo on GitHub.

## The path

| # | Page | What you try | Time |
|---|---|---|---|
| 1 | [Turn on the city](trials/01-turn-on-the-city.md) | a checkbox in the settings, and where the agents deliver | 3 min |
| 2 | [Enable the agents](trials/02-enable-the-agents.md) | read what each agent does and what it can do, then enable it | 7 min |
| 3 | [The account manager finds the call for tenders](trials/03-the-account-manager-finds-the-tender.md) | launch the first agent and check what it proposes | 5 min |
| 4 | [Start the round and read the sheets](trials/04-start-the-round.md) | press «Start the round», start the three sheets, follow the round and read them before approving them | 12 min |
| 5 | [Approve, and the round moves on](trials/05-approve-and-pass-the-work.md) | approve three sheets: after the third one the synthesis starts by itself | 8 min |
| 6 | [The synthesis and your decision](trials/06-the-synthesis-and-your-decision.md) | read the synthesis, look for where the sheets talk to each other, decide | 8 min |

## Before you start

- Open this project in MdExplorer. The simplest way is **«Create demo project»**: it prepares everything, including the
  repository the agents deliver to.
- The city is **off** until you turn it on (trial 1). The agents are already there, in `.github/agents/`.
- Each agent calls the AI engine chosen for the project: the whole path makes about ten calls and uses up a little of
  your subscription.
- If you use opencode, also write a model in the agent card (`runtime: model:`): without one, the free tier is not enough.

## What you will not see here

The federation between cities of different people, the agents' memory and the work of several people on different
computers need things a public repository cannot give (a room key, a relay, one more component). They are shown
live. In this case the four people are all you.

[Back to the start](../README.md)
