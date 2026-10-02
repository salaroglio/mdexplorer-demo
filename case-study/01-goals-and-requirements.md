---
title: Goals and requirements of the pilot
author: Giulia Ferraris
---

# Goals and requirements of the pilot

## TL;DR

Alpina Servizi wants to try an AI assistant that prepares draft replies to help desk tickets.
This document says why, what the assistant must do, and what it must never do. The decision to
send a reply always stays with the operator.

- The assistant **proposes**, the operator **decides**: no reply goes out on its own.
- The pilot lasts **8 weeks** and involves **20 operators** of the day shift.
- No customer personal data leaves the company network (requirement R6).

## The context

Alpina Servizi runs heating systems for apartment buildings and small companies. The help desk receives
about 1,900 tickets a month: service requests, questions about bills, fault reports.

Today an operator takes more than four hours on average to give the first reply. A large part of that time
goes into searching: the right answer almost always exists, but it is scattered across manuals, old tickets
and the memory of the most experienced colleagues.

## The goals

| # | Goal | How it is measured |
|---|---|---|
| O1 | Reduce the time to the first reply | from 4 h 10 min to 1 h 30 min |
| O2 | Solve more tickets at the first contact | from 58% to 70% |
| O3 | Improve customer satisfaction | from 3.9 to at least 4.2 out of 5 |
| O4 | Find out whether operators trust the drafts | at least 40% accepted without changes |

The starting values and the targets are in the data file, which is the single source also for the
[architecture](02-architecture.md) and for the [plan](03-pilot-plan.md):

```text(./data/target-metrics.json)
```

## The requirements

| # | Requirement | Priority |
|---|---|---|
| R1 | For every new ticket the assistant prepares a **draft reply** within 30 seconds | high |
| R2 | Every draft **cites the sources** it used: knowledge base articles or closed tickets | high |
| R3 | The draft is **never sent** without an operator approving it | high |
| R4 | If confidence is below the threshold, the assistant **proposes nothing** and says so | high |
| R5 | The operator rates every draft: accepted, edited, discarded | medium |
| R6 | **No personal data** of customers leaves the company network | high |
| R7 | Every draft stays traceable: who approved it, which sources, which model | medium |
| R8 | The pilot involves **20 operators** of the day shift for **8 weeks** | medium |

## What stays out

- Automatic replies to customers, without an operator.
- Tickets about contracts and disputes: they stay with the legal office.
- The phone channel: the pilot covers written tickets only.

## Who decides

| Role | Person | Decides on |
|---|---|---|
| Sponsor | Marta Colombo, operations | start, stop, extension |
| Pilot lead | Giulia Ferraris, help desk | scope and metrics |
| Security and privacy | Paolo Gentile, DPO | requirement R6 |
| Architecture | Luca Bianchi, information systems | technical choices |

The decisions taken so far are in the [minutes of the steering committee](minutes/2026-09-18-steering-committee.md).
