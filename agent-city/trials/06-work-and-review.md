---
title: Work that goes through your approval
---

# Trial 6: work that goes through your approval

## TL;DR

The agents of this demo only read. An agent that **modifies files** never works in your folder: it works on a separate
copy, signs its commits with a name of its own and leaves you a branch to approve. This page shows what that path looks
like and how to try it, because trying it needs a repository you can write to.

- The agent works in an isolated copy (`.worktrees/`) and signs `name@agents.mde`.
- Its work arrives as a request in «Agent messages» → «Agent work»: **Approve**, **Take it over** or **Reject**.
- «Approve» merges the branch into `main` **and publishes it on the remote repository**: that is why it is not in the demo.

## Why it is not a trial of the demo

This project is a clone of a public repository: you probably do not have permission to write to the `origin` remote. The
work of an agent that modifies files is **published on `origin`** as a branch, and «Approve» also writes to `main`.
Whoever has that permission, like the author of the demo, would change the public `main`.

If `origin` is not writable, MdExplorer does not lose the work and does not pretend it went well: in your inbox you
get a message from the agent saying **why** it could not publish and where its work is. In the versions of MdExplorer
before 3 October 2026 that error only stayed in the log of the service and nothing appeared in the window.

## The agent

An agent that modifies files declares `edit` among its tools. This is the card of an agent that brings the pilot plan in
line with the minutes:

```markdown
---
description: Aligns the pilot plan with the committee decisions
tools: [read, edit]
a2a:
  name: plan-aligner
  role: Aligner of the pilot plan
  skills:
    - id: align-plan
      description: Brings the plan in line with the decisions approved in the minutes
  accepts_messages_from: ["*"]
mde: {origin: user, version: 1}
---

You are the aligner of the plan of the Alpina Servizi pilot (folder `case-study/`).

How you work:
1. Read the files directly with the file-reading tool.
2. Modify only `case-study/03-pilot-plan.md`, and only what the committee minutes decided.
3. Sum up in two lines what you changed.
```

## How to try it on your repository

1. Make a **repository of your own** from the demo: a fork, or a new repository you can write to. Clone it and open it
   in MdExplorer.
2. Save the card above in `.github/agents/plan-aligner.agent.md`.
3. Turn the city on ([trial 1](01-turn-on-the-city.md)) and trust the agent ([trial 2](02-registry-and-trust.md)).
   The trust window says it asks for `edit`.
4. Launch the agent from the robot icon on its file, leaving **«Work in an isolated workplace»** ticked, with the
   request: «The minutes approve 6 weeks: update the plan.».
5. After about a minute open «Agent messages» → **Agent work**.

## What you see

A request with the name of the agent, the branch (`agent/<your name>/plan-aligner/...`), the number of touched files and
their list, for example `case-study/03-pilot-plan.md`. Three buttons:

| Button | What it does |
|---|---|
| **Approve** | merges the branch into `main` and publishes it on `origin`. The commit is the agent's |
| **Take it over** | opens its work in a copy so you correct it yourself, and puts the agent back in the queue |
| **Reject** | merges nothing; the branch stays, it is not destroyed |

In the git history the commit of the agent is signed `plan-aligner <plan-aligner@agents.mde>`: where it put its hands you
see with `git blame`, you do not have to ask anyone.

## What must stay true

- **An agent that changes nothing opens no request.** The three keepers of trial 4 also work in an isolated copy, but
  without changes they publish nothing.
- **The work of the agent does not touch your folder** until you approve it.
- **The decision is yours, for every delivery.** There is no automatic merge: the choice to merge by themselves was
  withdrawn.

[Section index](../README.md) · [Back to the start](../../README.md)
