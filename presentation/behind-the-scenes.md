---
title: Behind the scenes
document_type: slides
reveal:
  theme: white
  config:
    width: 1280
    height: 720
    slideNumber: c/t
    transition: fade
    pdfSeparateFragments: false
---

<!-- .slide: data-background-color="#0f1b2d" data-background-image="assets/sfondo-spazio.svg" -->

<img src="assets/razzo.svg" alt="The MdExplorer rocket" width="200">

# Behind the scenes

How MdExplorer is built

Note:
This presentation opens from a link of the main one. The trail at the top left takes you back to the
slide you left from.

---

<!-- .slide: data-background-image="assets/sfondo-chiaro.svg" -->

## The numbers

| Fact | Value |
|---|---|
| Lines of C# code | about 150,000 |
| Lines of TypeScript code | about 43,000 |
| Projects in the solution | 22 |
| Automated tests | more than 1,300 |
| Commits since March 2021 | 1,311 |
| Sprint plans | 54 |

Measured on the repository on 1 October 2026.

---

<!-- .slide: data-background-image="assets/sfondo-chiaro.svg" -->

## Six years, one acceleration

<div style="width:860px; margin:24px auto 0; font-size:26px; text-align:left">
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2021</span><span style="display:inline-block; height:30px; width:135px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">149</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2022</span><span style="display:inline-block; height:30px; width:111px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">122</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2023</span><span style="display:inline-block; height:30px; width:57px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">63</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2024</span><span style="display:inline-block; height:30px; width:85px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">94</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2025</span><span style="display:inline-block; height:30px; width:200px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">221</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2026</span><span style="display:inline-block; height:30px; width:600px; background:#1a73e8; border-radius:0 4px 4px 0"></span><span style="margin-left:12px"><b>662</b></span></div>
</div>

Commits per year. In 2026, up to 1 October, 638 out of 662 are co-signed with an AI agent.

Note:
The jump does not come from more hours of work. It comes from the method on the next slide.

---

<!-- .slide: data-background-image="assets/sfondo-chiaro.svg" -->

## The method

```plantuml
@startuml
!theme plain
skinparam backgroundColor transparent
scale 1.5
left to right direction
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam rectangle {
  BackgroundColor<<Centre>> #E8F0FE
  BorderColor<<Centre>> #1A73E8
}
hide stereotype

rectangle "Sprint plan\nin markdown" as P <<Centre>>
rectangle "The agent carries out\na phase" as A
rectangle "Trial in the\nreal app" as V
rectangle "Commit" as C

P --> A
A --> V
V --> C
C --> P : the plan is updated
@enduml
```

The plan is a living document: decisions, phases, what has been tried and what remains.

Note:
Every function seen today has its sprint plan, written and read inside MdExplorer.
The person decides and checks, the agent carries out and documents.

---

<!-- .slide: data-background-image="assets/sfondo-chiaro.svg" -->

## How it is made

```plantuml
@startuml
!theme plain
skinparam backgroundColor transparent
scale 1.5
left to right direction
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam DatabaseBackgroundColor #F1F3F4
skinparam DatabaseBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam rectangle {
  BackgroundColor<<Centre>> #E8F0FE
  BorderColor<<Centre>> #1A73E8
}
hide stereotype

rectangle "Desktop application\nWindows and Linux" as E
rectangle "Angular\ninterface" as UI
rectangle ".NET 8\nservice" as S <<Centre>>
database "Index and settings\nSQLite, on the computer" as DB
rectangle "Git" as G
rectangle "MCP server" as MCP
rectangle "AI engine\nchosen by the project" as AI

E --> UI
UI --> S
S --> DB
S --> G
S --> AI
AI --> MCP
MCP --> S
@enduml
```

---

<!-- .slide: data-background-image="assets/sfondo-chiaro.svg" -->

## Three lessons learned

1. **The written plan is worth more than the request.** An agent with a clear plan works for hours without getting lost <!-- .element: class="fragment" -->
2. **Verify first, change after.** The agent tries things in the real application, it does not assume <!-- .element: class="fragment" -->
3. **Memory is made of documents.** What the agent learns stays written, and a person can read it too <!-- .element: class="fragment" -->

Note:
They are the same three things a company adopting AI needs: written knowledge, verification, shared rules.
