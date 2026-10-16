---
title: Enable the agents
---

# Trial 2: enable the agents

## TL;DR

An agent is a text file in the project: anyone can change it, even after you have read it. That is why no
agent starts until you **enable** it, one by one, after reading what it does and what it can do on your computer. In
MdExplorer this gesture is called «Trust».

- First you say **whose they are**: an agent works only for the person who answers for it, and without an owner it does not start.
- Then you enable them from the **registry** (the two-people icon), reading for each one a window with two separate blocks.
- One block is written by the **author** (not verified), the other is **computed by the app**; if the card changes, the enablement **expires**.

## Open the registry

Click the two-people icon, «City of agents». The list of the agents found in the project opens. For
this case four rows matter, all «Not trusted»:

| Agent | What it does, in one sentence |
|---|---|
| `account-manager` | finds the calls for tenders, starts the round, writes the synthesis |
| `technical-lead` | writes the technical feasibility sheet |
| `legal-lead` | writes the contract sheet |
| `delivery-lead` | writes the team and plan sheet |

Under each name you read, in orange, **«Nobody answers for it: it does not start»**.

## First of all: whose they are

Each agent works for one person: it runs only on that person's computer, and it is that person who judges what the agent writes. In a real company the
four agents would belong to four different people, and each one would enable their own from their own computer. Here you play
all the parts.

![The registry: four agents with no owner and the «They are all mine» button](../presentation/assets/schermate/registro-responsabili.png)

1. At the top of the registry you read who you are for this project: it is your **git email**.
2. Below, an orange line says that four agents have no owner. Click **They are all mine**.
3. Now under each name you read, in green, **«Answers to you: it works on this computer»**, and the «Trust» button appears.

What happened: MdExplorer wrote four lines, with your name, in the document
[Who answers for which agent](../tender/responsibilities.md). It is a project file, and you see it open behind the window. Until an
agent appears there it does not start and cannot be enabled; if it belonged to a colleague, it would work on the colleague's computer and not on yours.

> The document now contains your name and your email, and shows up as «to commit». In the project created with «Create demo project»
> it stays on your computer.

## What each row shows

Each row shows the role, a summary of two or three lines and the declared tools. The tools that change
things (`edit`, `shell`) are **in red**. The other agents you see in the list are not part of this trial.

## Read an agent's window

On `technical-lead` click **Trust**. «Trust this agent?» opens, with two blocks.

**«What it does»**, with the orange label *written by the author, not verified*. It is the summary the author
put in the card: it tells you what it produces and for whom. The app cannot check it, which is why it tells you to read it
with your own head.

**«What it can do on your computer»**, with the green label *computed by the app*. A list of yeses and nos derived from
the declared tools, the only ones the app enforces:

| Item | For `technical-lead` |
|---|---|
| Reads the project's files | yes |
| Searches the project's documents | no |
| Creates and edits files in the project | **yes**, in red: *its deliveries go through your approval* |
| Runs commands on the computer | **no** |
| Can write to other agents and to you | yes |
| When you approve its work you can hand it over to | `account-manager` |

Below, a note says that the app limits commands and file writing, but that other engine tools (for example
the network) depend on the engine you chose.

## Why you need this window

Look at the tools: this agent **cannot run commands**, and everything it writes stays in a separate copy
until you approve it. Its worst mistake, then, is a wrong sheet: and you read that before it enters
the project. That is why you can enable it with peace of mind, and why the real control, in the rest of the case, will be your
check of what it writes.

An agent with `shell` would be another story: it could do damage **while it works**, before you see a single
result. The window would write it in red.

## Enable them

Click **I trust it** and repeat for the other three agents. When you are done each row says «Trusted» and the button
becomes «Revoke trust».

## Change one word and see what happens

1. Open `.github/agents/technical-lead.agent.md` and, in the summary (`summary:`), change one word. Save.
2. Go back to the registry and press **Refresh**.

`technical-lead` is no longer trusted: you read one description, you find another, and the app makes you do it again. This applies to
everything inside `a2a:` and to the tools (`tools:`): if they change, the enablement expires. If instead you change the text
**below** the block at the top (the instructions), it stays valid.

Put the word back as it was and enable it again before going on. If the row says «Not trusted» instead of «Trust expired»,
it is the same effect: it depends on who noticed first.

## And if nothing happens

- **You do not see the four agents.** Wait a few seconds for the project to finish indexing and press **Refresh**.
- **«Trust» does not respond.** Close and reopen the registry.

[Trial 3: the account manager finds the call for tenders](03-the-account-manager-finds-the-tender.md) · [Trial 1](01-turn-on-the-city.md) · [Section index](../README.md)
