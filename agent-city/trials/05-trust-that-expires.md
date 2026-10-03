---
title: Trust that expires
---

# Trial 5: trust that expires

## TL;DR

The trust you give to an agent holds for the card you read, not for the agent in the abstract. If someone changes
the tools the agent declares or who may write to it, the trust **expires** and you have to confirm it again. This
trial shows it to you by changing one line.

- You change `tools:` in the card of `plan-keeper` and it goes back to «Not trusted».
- The same happens if you change the `a2a:` block, for example who may write to it.
- The body of the card, that is the instructions, can be changed without losing trust.

## Why it exists

A card is a file in the repository, and the repository is edited by several people. Without this rule, whoever wants to
give an agent one more permission could write `shell` in the card and count on the fact that you already trusted it.
This way the new permission goes through you.

## Try it

1. Open `.github/agents/plan-keeper.agent.md` with a text editor. At the top, between the two `---`, you find the card.
2. Change this line:

   ```yaml
   tools: [read, search]
   ```

   into this one:

   ```yaml
   tools: [read, search, shell]
   ```

3. Save the file.
4. Go back to MdExplorer, open the registry (the two-people icon) and click **Refresh**.

## What you see

- `plan-keeper` is back to **«Not trusted»**.
- Among its tools `shell` appears, in red with a triangle.
- The other two agents stay trusted: the expiry only concerns the changed card.

If you click **Trust**, the window lists the tools it asks for, `shell` included: you are giving one more permission and
you do it with your eyes open.

## Put everything back

Bring the line back as it was (`tools: [read, search]`), save and click **Refresh**. The agent stays «Not trusted»: the
expired trust does not come back by itself. Click **Trust** to give it again.

## A second change: who may write to it

The `a2a:` block has an `accepts_messages_from` line, the list of who may write to that agent. Add or remove a name from
that list and the result is the same: card changed, trust expired.

## What does not make the trust expire

The text under the card, that is the instructions the agent follows, can be edited without losing trust. It is a
choice: instructions change often and give no new permissions. That is why what an agent can do lives in the card and
not in the text.

## Are the declared tools really a limit?

Yes, with GitHub Copilot and in the versions of MdExplorer after 3 October 2026: what the agent does not declare
(running commands, writing files) the engine **refuses** («Permission to run this tool was denied», says the agent
itself if it tries). Before that date the `tools:` were a written intention, not a ban: if you have an older version,
update it before relying on this line.

[Trial 6: work that goes through your approval](06-work-and-review.md) · [Section index](../README.md)
