---
title: Pilot plan
author: Giulia Ferraris
---

# Pilot plan

## TL;DR

The pilot goes through four phases, from a silent trial to real use with the operators. Every phase has
a condition to move to the next one and a condition to stop. The plan covers eight weeks, from Monday
5 October to Friday 27 November 2026.

- It starts in **shadow** mode: the assistant writes drafts but nobody sees them.
- A phase is left only if the metrics hold; two criteria stop everything.
- The final decision is for the steering committee, on the numbers collected.

## The phases

```plantuml
@startuml
!theme plain
skinparam ActivityBackgroundColor #F1F3F4
skinparam ActivityBorderColor #5F6368
skinparam ActivityDiamondBackgroundColor #FEF7E0
skinparam ActivityDiamondBorderColor #F29900
skinparam ArrowColor #5F6368

start
:Prepare the knowledge base;
:Run the assistant in shadow mode;
if (Do the drafts cite the right sources?) then (yes)
  :Show the drafts to five operators;
else (no)
  -[#D93025]->
  #FCE8E6:Fix the knowledge base;
  stop
endif
if (Has a stop criterion fired?) then (no)
  :Extend to all the operators of the pilot;
  :Collect the metrics;
  :Bring the numbers to the steering committee;
else (yes)
  -[#D93025]->
  #FCE8E6:Stop the pilot and warn the sponsor;
endif
stop
@enduml
```

## The calendar

| Phase | Weeks | What happens | Move on if |
|---|---|---|---|
| 1. Preparation | 1-2 | Knowledge base articles tidied up and indexed | 300 articles ready |
| 2. Shadow | 3 | The assistant writes drafts nobody sees | 8 drafts out of 10 cite the right source |
| 3. Small group | 4-5 | Five operators see and rate the drafts | no stop criterion |
| 4. Whole group | 6-8 | All the operators of the pilot | it closes with the numbers |

## The metrics

```plantuml
@startmindmap
!theme plain
<style>
mindmapDiagram {
  node {
    BackgroundColor #F1F3F4
    LineColor #5F6368
    RoundCorner 8
    Padding 6
  }
  :depth(0) {
    BackgroundColor #E8F0FE
    LineColor #1A73E8
    LineThickness 2
    FontStyle bold
  }
  boxless {
    FontColor #5F6368
  }
}
</style>
* Pilot metrics
** Speed
***_ time to the first reply
***_ time to prepare the draft
** Quality
***_ tickets solved at the first contact
***_ customer satisfaction
left side
** Trust
***_ drafts accepted without changes
***_ drafts discarded, with the reason
** Safety
***_ personal data in the drafts
***_ replies without a source
@endmindmap
```

## The risks

| Risk | Likelihood | Effect | What we do |
|---|---|---|---|
| The knowledge base is old | high | wrong but convincing drafts | phase 1 dedicated to it, sources always cited |
| Operators do not trust it | medium | the drafts are ignored | small group first, one-click rating |
| Personal data sent outside | medium | breach of R6 | to be settled with the DPO before phase 3 |
| The model changes behaviour | low | metrics cannot be compared | model pinned for the whole duration |

## A check that runs from the document

The block below has a button to run it: it counts the metrics that have a target in the data file.

```bash
echo "Metrics with a target in the data file:"
grep -c '"target"' case-study/data/target-metrics.json
```

See also the [requirements](01-goals-and-requirements.md), the [architecture](02-architecture.md) and the
[minutes of the steering committee](minutes/2026-09-18-steering-committee.md).
