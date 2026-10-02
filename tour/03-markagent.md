---
title: MarkAgent
---

# MarkAgent

## TL;DR

MarkAgent is the AI agent of MdExplorer: a conversation that reads and writes the documents of the open
project. It uses the engine the project has chosen and the rules the project carries with it. This page
says where it is, how the engine is chosen and what to ask it about the case study.

- It lives in the "Mark Agent" tab, at the bottom of the left panel.
- The engine is chosen **once, per project**: GitHub Copilot, Claude Code or opencode.
- What it writes is a change in the files: you see it in the "Changes" tab before you accept it.

## Where it is

At the bottom of the left panel there are four tabs: "Project docs", "Changes", "Mark Search"
and "Mark Agent". The "Mark Agent" tab appears when the project is a git repository, like this one.

In the tab you find the "Ask Mark Agent..." box, the "Model" drop-down and the
"New chat session" button.

## Choosing the engine

On the projects page, the gear on the project card opens "Project Settings".
There, in the "AI & RAG" tab, is the "Agent environment" box.

| Choice | Where MdExplorer writes rules and skills |
|---|---|
| GitHub Copilot | the `.github/` folder |
| Claude Code | the `.claude/` folder and the `CLAUDE.md` file |
| opencode | the `.opencode/` folder and the `AGENTS.md` file |

The choice is written in a file of the project, so it holds for the whole team. Every AI function
of MdExplorer uses that engine: the conversation, the explanation of diagrams, the commit message,
the tests.

## What to ask it about the case study

The [case study](../case-study/README.md) is a small project written for this purpose. Copy a request
into MarkAgent's box.

**Understand quickly**

> Read the documents in the case-study folder and tell me in five lines what the project is about and
> where it stands.

**Find what does not add up**

> Compare requirements, architecture, plan and minutes of the case study. Which inconsistencies do you find?
> For each one, cite the document and the place.

There are three inconsistencies placed in the documents on purpose. Does it find them all?

**Put things in order**

> Update requirements, plan and data file of the case study with decisions D2 and D3 of the minutes.

Then open the "Changes" tab: every changed line is there, to read before you commit.

**Prepare a meeting**

> Add to the presentation case-study/committee-slides.md a slide with the three main risks of the plan.

Open the [committee presentation](../case-study/committee-slides.md): the new slide is already there.

## The other doors to the same agent

| Where | What it does |
|---|---|
| the "Mark Search" tab | searches the documents of the project and answers citing its sources |
| right click on a diagram, "💬 Ask to MarkAgent" | explains the element |
| right click on a point of a slide, "💬 Ask MarkAgent" | explains that point with the documents of the project |
| a text selection, the "✨ Usa AI" button | rewrites the selected piece, with your approval |
| the commit window, "Generate with AI" | proposes the commit message |

## Where the data goes

The documents stay on the computer and in the git repository. When you ask MarkAgent something, the text it
needs goes to the provider of the chosen engine, under the terms of the contract your company has with that
provider. Search in the documents and the index are local.

## What you need

- The project must be a git repository.
- The command line of the chosen engine, installed and signed in: `copilot`, `claude` or `opencode`.
- The network.

Next: [Presentations](04-presentations.md) · Back: [Diagrams](02-diagrams.md) · [Back to the start](../README.md)
