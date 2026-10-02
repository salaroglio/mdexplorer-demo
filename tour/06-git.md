---
title: Git without the terminal
---

# Git without the terminal

## TL;DR

Git is what makes working with AI controllable: every change has an author and a date, and no version is
ever lost. MdExplorer puts it within reach of people who do not use the terminal. This page shows where you
see what changed and how you save and share.

- The bar always says how many changes are to be saved, downloaded and published.
- The "Changes" tab shows line by line what changed, whoever wrote it.
- The AI proposes the commit message, the person approves it.

## What changed

On the right of the document bar there are three counters: "to commit", "to pull", "to push".
Moving the mouse over them opens a panel with one row for each repository of the project.

At the bottom of the left panel, the "Changes" tab lists the changed files. A click on a file shows
the lines removed and the lines added.

## To try

1. Open [Living documents](01-living-documents.md) and correct the typo with a right click.
2. Look at the "to commit" counter: it now counts your correction too.
3. Open the "Changes" tab and read the changed line.
4. Open the "To commit" panel and press "Commit".
5. In the "Commit Message" window press "Generate with AI", read the proposal and confirm.

The commit stays on your computer. "Push" sends it to the remote repository, if you have permission.

## The history of the project

The button with the name of the branch opens a menu. "History" shows all the commits, as a table or as a
graph. "Branch" shows the branches and lets you switch.

## Why it matters when an agent works

| Question | Where the answer is |
|---|---|
| What did the agent change? | the "Changes" tab, before the commit |
| Who approved the change? | the author of the commit, in "History" |
| When did it happen, and why? | date and message of the commit, in "History" |
| Can you go back? | yes: git keeps every version of every file |

## What you need

Git installed. To download and publish you need the network and access to the remote repository.
"Generate with AI" needs an AI engine: see [MarkAgent](03-markagent.md).

Next: [Rules, skills and MCP](07-rules-skills-mcp.md) · Back: [Word, PDF and site](05-word-pdf-site.md) · [Back to the start](../README.md)
