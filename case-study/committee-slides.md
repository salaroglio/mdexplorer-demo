---
title: Steering committee of 23 October
document_type: slides
reveal:
  theme: white
  config:
    width: 1280
    height: 720
    slideNumber: c/t
    transition: fade
---

# AI assistant for the help desk

Steering committee · 23 October 2026

Note:
Sample presentation of the case study. It is a markdown file like the others: it is corrected from the page
with "Edit", and MarkAgent can add slides by reading the documents in the folder.

---

## Where we are

- Pilot approved on 18 September
- Knowledge base tidied up: 300 articles
- Assistant at work in shadow mode for a week

Note:
The details are in the pilot plan. The full calendar is in the table of the phases.

---

## The path of a draft

```plantuml
@startuml
!theme plain
scale 1.5
skinparam ActivityBackgroundColor #F1F3F4
skinparam ActivityBorderColor #5F6368
skinparam ActivityDiamondBackgroundColor #FEF7E0
skinparam ActivityDiamondBorderColor #F29900
skinparam ArrowColor #5F6368

start
:A ticket arrives;
:Search the sources;
:Write the draft;
if (Enough confidence?) then (yes)
  :Show the draft to the operator;
else (no)
  -[#D93025]->
  #FCE8E6:Propose nothing;
endif
stop
@enduml
```

---

## What we decide today

1. Move on to the small group of operators
2. Model in the cloud with anonymisation, or model in the company
3. Date of the next committee

---

## To go deeper

- [Goals and requirements](01-goals-and-requirements.md)
- [Architecture](02-architecture.md)
- [Pilot plan](03-pilot-plan.md)
- [The prototype of the panel](mockup/operator-panel.html)
