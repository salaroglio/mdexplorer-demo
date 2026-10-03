---
title: Turn on the city
---

# Trial 1: turn on the city

## TL;DR

The agent city is off in every project until you turn it on. It is turned on with a checkbox in the project
settings and it changes the project in one place only: two lines in the `.development.yml` file. This trial lets you
turn it on and see what changed.

- The checkbox is in «Project Settings», in the «Agent City / Federation» section.
- Once on, the toolbar shows four new icons.
- The project becomes «to commit»: **do not commit that file** in this demo.

## Turn it on

1. Open the page of the **recent projects**: it is the one you see when you start MdExplorer.
2. On the card of this project click the cogwheel: «Project Settings» opens. It may take a moment.
3. Scroll to the **Agent City / Federation** section.
4. Tick «Enable the agent city for this project».
5. Close the window and reopen the project by clicking its card.

## What you see

In the toolbar, next to the icons from before, four new icons appear:

| Icon | It is called | What it is for |
|---|---|---|
| the two people | «City of agents» | the registry: who lives in the project and whom you trust |
| the person in a circle | the identity | who you are for the city; used by the federation |
| the head with a light bulb | the memory of the agents | it needs one more component, we do not use it |
| the speech bubble | «Agent messages» | the inbox, the conversations and the work to review |

## What changed in the project

At the top right the badge says «1 to commit». The changed file is `.development.yml`, in the folder of the
project, and it has two new lines:

```yaml
agentCity:
  enabled: true
  roomSecret: <a random key, generated on your computer>
```

- `enabled` is the switch you have just ticked.
- `roomSecret` is a random key that MdExplorer generates the first time. It is only used by the federation between
  cities of different people, which we do not use here; but it is a **credential**, because in a real team it ends up
  in the repository with everything else.

> **Do not commit `.development.yml` in this demo.** The repository is public: the key must not end up there.
> To go back as you were, restore the file with git: `git checkout .development.yml`.

## Why it is off to begin with

A city that is on can wake AI agents and make them talk, and every wake-up uses your subscription. That is why it is
an explicit choice, **per project**: it lives in a file the team shares.

[Trial 2: the registry and trust](02-registry-and-trust.md) · [Section index](../README.md)
