---
title: The registry and trust
---

# Trial 2: the registry and trust

## TL;DR

The registry is the list of agents that live in the project: for each one it says who it is, what it can do and
which tools it declares. An agent does not take part in any conversation until you give it **trust**. This trial lets
you read the cards and give trust to the three agents of the case study.

- The registry opens from the two-people icon in the toolbar.
- Every agent starts «Not trusted»: trust is your explicit confirmation, agent by agent.
- The riskiest tools (writing, running commands) are highlighted in red.

## Open the registry

Click the two-people icon, «City of agents». A window opens with the list of agents found in the project. There are
four:

| Agent | Type | What it is |
|---|---|---|
| `a2a-ping` | ALGORITHMIC | an agent that uses no model: it answers «pong» to whatever you write. It proves the channel works and it is in every project |
| `plan-keeper` | LLM | looks after the pilot plan |
| `requirements-keeper` | LLM | looks after the pilot requirements |
| `minutes-keeper` | LLM | looks after the committee decisions |

«LLM» means there is a language model behind it, the one of the AI engine you chose for the project.

## Read a card

Every row is the **card** of the agent, written in its file in `.github/agents/`. For `plan-keeper` you read:

- the **role**: «Keeper of the pilot plan»;
- the **skill**: `check-plan`, what it can do in one line;
- the **tools**: `read` and `search`. They are the tools the agent declares it uses: reading and searching. If an
  agent declared `write` or `shell` you would see the word **in red with a triangle**, because they are the two that
  change things.

## Give trust

1. On `plan-keeper` click **Trust**.
2. The window asks «Trust this agent?» and says that the agent will be able to take part in conversations inside this
   project, and which tools it asks for.
3. If it looks right, click **I trust it**. If not, **Cancel**.
4. Repeat for `requirements-keeper` and `minutes-keeper`. Leave `a2a-ping` out, we do not need it.

Afterwards the card of the agent says «Trusted» and the button becomes **Revoke trust**: you can withdraw the trust
whenever you like.

## What «trust» means

- It is **yours**, on your computer: nobody can trust on your behalf, and a new clone of the project starts from zero.
- It is **per agent**: trusting one does not make you trust the others.
- It is **tied to the card**: if someone changes the `a2a:` block or the `tools:` of an agent, the trust expires and has
  to be given again. You will see it in [trial 5](05-trust-that-expires.md).

Without trust an agent can be launched by hand, but **it cannot be asked anything by its colleagues**: in
[trial 4](04-the-dialogue.md) the exchange starts only if the agents are trusted.

[Trial 3: the first agent at work](03-the-first-agent.md) · [Section index](../README.md)
