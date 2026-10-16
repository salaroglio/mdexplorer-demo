---
title: Turn on the city
---

# Trial 1: turn on the city

## TL;DR

The agent city is off in every project until you turn it on. You turn it on with a checkbox in the project
settings, and it changes the project in one place only: two lines in the `.development.yml` file.
This trial makes you turn it on and see what has changed.

- The checkbox is in «Project Settings», in the «Agent City / Federation» section.
- Once it is on, the toolbar shows four new icons.
- The project becomes «to commit»: **do not commit that file** in this demo.

## Turn it on

1. Open the **recent projects** page: it is the one you see when you start MdExplorer.
2. On this project's card click the gear: «Project Settings» opens. It may take a moment.
3. Scroll down to the **Agent City / Federation** section.
4. Tick «Enable the agent city for this project».
5. Close the window and reopen the project by clicking its card.

## What you see

In the toolbar, next to the icons that were there before, four new icons appear:

| Icon | It is called | What it is for |
|---|---|---|
| the two people | «City of agents» | the registry: who lives in the project and whom you trust |
| the person in a circle | the identity | who you are for the city; the federation needs it |
| the head with the light bulb | the agents' memory | it needs one more component, we do not use it |
| the speech bubble | «Agent messages» | the mailbox, the conversations and the work to review |

## What has changed in the project

At the top right the badge says «1 to commit». The changed file is `.development.yml`, in the project
folder, and it has two new lines:

```yaml
agentCity:
  enabled: true
  roomSecret: <a random key, generated on your computer>
```

- `enabled` is the switch you have just ticked.
- `roomSecret` is a random key that MdExplorer generates the first time. It is only needed for the federation between
  cities of different people, which is not used here; but it is a **credential**, because in a real team it ends up in the
  repository together with everything else.

> **Do not commit `.development.yml` in this demo.** The repository is public: the key must not end up there.
> To go back to how you were, restore the file with git: `git checkout .development.yml`.

## Where the agents deliver

The agents of this case **write documents**, and a document written by an agent never enters your
folder by itself: the agent delivers it on a separate branch and you approve it. To deliver, the agent needs a
repository it can write to, which in git's language is called `origin`.

- If you created the project with **«Create demo project»**, MdExplorer has already prepared everything: next to the
  project folder there is a `<name>.origin.git` folder, and the demo's public repository has stayed as `upstream`.
  You do not have to do anything, and it does not spoil any other project: it does this only for the demo clone.
- If instead you cloned the demo by hand, `origin` is the public repository, which you cannot write to: the delivery
  fails and you get a message that says so. First make a **fork** on your account and work on that.

To know what really happens, read the [technical note on the local repository](../guide/technical-note-local-repository.md).

## Why it is off to begin with

A city that is on can wake AI agents and make them talk, and every wake-up uses up your subscription. That is why
it is an explicit choice, **of the project**: it lives in a file the team shares.

[Trial 2: enable the agents](02-enable-the-agents.md) · [Section index](../README.md)
