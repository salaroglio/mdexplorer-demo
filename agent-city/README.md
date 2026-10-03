---
title: The agent city
---

# The agent city

## TL;DR

In MdExplorer, AI agents are not just a conversation: they can live in a project, each with a name, a role and a
document to look after, and write to each other. You decide whom to trust, you see what they say to each other
and you get the result in your inbox. This section lets you try it all with your own hands, on a case study that
contains three inconsistencies.

- Six trials, in order, about half an hour in total.
- The agents of the demo **do not modify any file**: they read, write to each other and report to you.
- You need an AI engine already set up (GitHub Copilot, Claude Code or opencode) and a network connection.

## The presentation

Ten minutes to grasp the idea, before touching anything: [The agent city](presentation/agent-city.md),
17 slides with the three keepers, the Alpina scene and flying messages. It opens as a presentation, from the
**Present** button.

## The path

| # | Page | What you try | Time |
|---|---|---|---|
| 1 | [Turn on the city](trials/01-turn-on-the-city.md) | a checkbox in the settings, and what changes in the project | 3 min |
| 2 | [The registry and trust](trials/02-registry-and-trust.md) | who lives in the city and whom you trust | 5 min |
| 3 | [The first agent at work](trials/03-the-first-agent.md) | you launch an agent and read the result in your inbox | 5 min |
| 4 | [The dialogue between two agents](trials/04-the-dialogue.md) | two agents write to each other to find the inconsistencies | 8 min |
| 5 | [Trust that expires](trials/05-trust-that-expires.md) | you change an agent's card and the trust disappears | 5 min |
| 6 | [Work that goes through your approval](trials/06-work-and-review.md) | an agent that edits files, and how you review it | 5 min |

## The case study

The agents work on the documents of the Alpina Servizi pilot, the same [case study](../case-study/README.md) as the rest
of the demo. [The city of Alpina](alpina/README.md) says who the three agents are, how they talk and what they must find:
read it before starting.

## Before you start

- Open this project in MdExplorer: it is a git repository, like the others.
- The city is **off** until you turn it on (trial 1). The agents are already there, in `.github/agents/`.
- Every agent calls the AI engine chosen for the project: each trial uses a bit of your subscription.
- If you use opencode, also write a model in the agent's card (`runtime: model:`): without it, the free tier is
  not enough.

## What you will not see here

The federation between cities of different people, the memory of the agents and the automatic merge of their work
into `main` need things a public repository cannot give (a room key, a relay, an extra component, a repository
you can write to). They are shown live; the [case study page](alpina/README.md) says what they are and why they are missing.

[Back to the start](../README.md)
