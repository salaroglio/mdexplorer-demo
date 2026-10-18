---
mde_type: ownership
title: Who answers for which agent
---

# Who answers for which agent

## TL;DR

Every agent of the tender works for a person: it runs only on that person's computer, and that person assesses what the agent
writes. This table says who. At the start it has the four **roles** but no person: until an agent has an owner, it does
not start.

- The roles are the ones the workflow names: whoever decides whether to bid is the «Account manager», whoever that is.
- In this demo you take all the roles, with one click: MdExplorer writes your name and email in the four lines.
- The person is recognised by their git email; several people with the same role are a team.

## The table

| Role | Owner | Git Email | Agents |
|------|-------|-----------|--------|
| Account manager | | | account-manager |
| Technical lead | | | technical-lead |
| Legal lead | | | legal-lead |
| Delivery lead | | | delivery-lead |

## How it gets filled in

1. Open **City of agents** (the two people in the toolbar).
2. At the top you read who you are for this project: it is your git email.
3. Click **They are all mine**: MdExplorer writes your name and email in the four lines.

From that moment the four agents answer to you and you can enable them.

## Why it exists

An agent writes documents that someone has to read and approve. If it is not clear who, nobody answers for them. This is why
MdExplorer applies three rules:

| Whose the agent is | What happens |
|---|---|
| Yours | it works on your computer |
| A colleague's | it works on the colleague's computer, never on yours |
| Nobody's | it does not start, and it tells you |

## With four real people

Each person declares their own agent from their own computer, and the table becomes this (the names are made up):

```text
| Role            | Owner         | Git Email                   | Agents          |
| Account manager | Anna Rossi    | anna.rossi@pentagroup.it    | account-manager |
| Technical lead  | Marco Bianchi | marco.bianchi@pentagroup.it | technical-lead  |
| Legal lead      | Sara Verdi    | sara.verdi@pentagroup.it    | legal-lead      |
| Delivery lead   | Luca Neri     | luca.neri@pentagroup.it     | delivery-lead   |
```

## More people for the same agent

An agent can answer to a **team**: one line per person is enough, with the same agent. For example two technical leads (the
names are made up):

```text
| Technical lead | Marco Bianchi | marco.bianchi@pentagroup.it | technical-lead |
| Technical lead | Paolo Gialli  | paolo.gialli@pentagroup.it  | technical-lead |
```

The agent works on the computer of both, but **each piece of work belongs to one person only**: when the account manager presses
«Start the round», they choose which of the two will write the technical sheet, and from then on that person answers for it
(even if the sheet has to be redone). Whoever received it can pass it to a team colleague with «Pass to a colleague», for
example before going on holiday.

The document is a file of the project: it is in git, the whole group sees it and every change has an author.

[The tender case](README.md) · [Section index](../README.md)
