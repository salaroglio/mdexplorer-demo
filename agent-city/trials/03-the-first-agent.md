---
title: The first agent at work
---

# Trial 3: the first agent at work

## TL;DR

Launching an agent is like giving a task to a colleague: you write what you want, it works on its own and writes to you
when it is done. This trial lets you launch `minutes-keeper`, the simplest of the three, and read the result in your
inbox.

- You launch it with the robot icon on the `.agent.md` file, in the left panel.
- It works in an isolated copy of the project and uses the AI engine chosen for the project.
- The result arrives as a message: it does **not** appear in the list of executions, which only shows status and time.

## Launch it

1. In the left panel open the `.github` folder and then `agents`. You see the files of the agents, each with a small
   robot icon on the right.
2. On the row of `minutes-keeper.agent.md` click the robot icon, «Launch agent». If the panel is narrow the icon may
   be cut off: widen the panel a little.
3. «Launch agent — minutes-keeper.agent.md» opens. In the «Launch prompt» box write:

   > Tell me what the committee decided.

4. Look at the options below, without changing them:

   | Option | What it does |
   |---|---|
   | Engine | «Claude Code», «Copilot» or «opencode»: which AI engine does the work. The preselected one is the project's |
   | Model | leave it empty: the engine chooses |
   | «Work in an isolated workplace» | the agent works in a copy of the project, not in your folder |

5. Click **Launch now**.

The window closes and a message says the agent was started in the background.

## Wait

After about half a minute a notice appears: «🤖 Agente "minutes-keeper.agent.md" completato.» (that text is in Italian
whatever the language of the app), and on the «Agent messages» speech bubble in the toolbar a number appears: an
unread message.

## Read the result

Click the speech bubble. The **Inbox** tab has a message from `minutes-keeper` that starts with **`[RESULT]`**:

```text
[RESULT]
- D1 — The pilot is approved — line 37.
- D2 — It lasts 6 weeks — line 38.
- D3 — 12 operators of the day shift take part — line 39.
- D4 — No ticket text leaves the network without being anonymised — line 40.
- D5 — Drafts are rated with one click: accepted, edited, discarded — line 41.
```

The words may change, because there is a model behind it: the five decisions and the lines, no. Check them in the
[minutes](../../case-study/minutes/2026-09-18-steering-committee.md).

## What happened

- `minutes-keeper` read the minutes, and only those: they are its document.
- Then it wrote the result **to you**, with a tool of the city called `send_agent_message`. It is the only way an
  agent writes to you: if it wrote it only in its reply, it would stay in the log of the service and you would not
  see it.
- It did not modify any file: nothing changed in the folder of the project.

## If nothing happens

- **No notice after two minutes.** The AI engine does not answer: check that the command line (`copilot`, `claude` or
  `opencode`) is installed and logged in, or choose another engine in the launch window.
- **The speech bubble has no number.** Open the «Inbox» tab and click **Refresh**.

[Trial 4: the dialogue between two agents](04-the-dialogue.md) · [Section index](../README.md)
