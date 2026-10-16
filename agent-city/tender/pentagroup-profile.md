---
title: Pentagroup profile
author: Pentagroup sales office
---

# Pentagroup profile

## TL;DR

Pentagroup is a managed services company with 220 people, used to working for financial institutions. This document says who
it is, what it can do today, where its standards differ from those of a very demanding client, and which criteria it uses to
decide whether to bid on a call for tenders.

- Each lead reads **their own chapter**: technical, contracts, delivery and people.
- The criteria for deciding whether to bid on a call for tenders are at the end, and the account manager uses them.
- All the data here is **made up**: it serves the demo, it does not describe any real company.

> **Working date: 8 March 2027.** It is the «today» of this story: deadlines are counted from here.

## Who we are

Pentagroup S.r.l. designs, builds and runs SaaS platforms for banks, financial intermediaries and public administration. It has
220 people, its head office in Milan and an operations office in Bologna. It has completed three projects with financial
institutions in the last four years:

| Project | Client (sector) | Year | Nature |
|---|---|---|---|
| Claims management platform | insurance | 2023 | financial platform, 14 months |
| Payments portal for local authorities | public administration | 2024 | digital public administration, 11 months |
| Data platform for consumer credit | financial intermediary | 2025 | data platform, 16 months |

Pentagroup **has never handled the enforced collection of taxes**: the closest experience is the payments portal.

## Technical

*For the technical lead.*

| Topic | Pentagroup's status |
|---|---|
| Hosting | European cloud provider with ACN qualification for the infrastructure (IaaS) and for the application platform (PaaS). **The managed data lakehouse is not yet ACN qualified**: the qualification is expected in the fourth quarter of 2027. |
| Historical availability | 99.5% monthly on core services, measured over the last 24 months, maintenance windows excluded. |
| Continuity | RPO 30 minutes, RTO 4 hours, with one disaster recovery test per year. |
| Service | help desk and monitoring 5x8; on-call 24 hours a day, 7 days a week **not included** in the standard offer (it is a paid option). |
| Security | ISO/IEC 27001 certified. **ISO/IEC 22301 not yet obtained**: certification audit planned for September 2027. |
| Regulation | DORA register of information filled in for two clients; compliant as an «important entity» under the NIS2 directive. |
| Architecture | API-first, events on Kafka, canonical data model already used in two projects, proprietary low-code workflow engine. |
| AI agents | agent framework with an action log and human review, used in production by one client. |
| Integrations | standard integrations with PagoPA already built; with SEND never built. |
| Penetration tests | carried out by an external supplier, twice a year. |

## Contracts

*For the legal and commercial lead.*

Pentagroup's standard terms, the ones it proposes when it does not negotiate:

| Topic | Standard term |
|---|---|
| Ownership | Pentagroup **keeps ownership of the reusable components** (framework, libraries, models); it grants the client a perpetual and irrevocable licence to use them. The rest, as a rule, belongs to the client. |
| Data | the data stays the client's; Pentagroup processes it as data processor and **does not accept clauses that prevent it from using anonymised and aggregated data** to improve its own services. |
| Liability | cap equal to the annual fee; unlimited liability is not accepted. |
| Penalties | overall cap of 10% of the annual fee. |
| Termination | the client can terminate with six months' notice **paying compensation** equal to the services performed plus 10% of the remaining ones. |
| Incidents | notification of major incidents within **24 hours**. |
| Audit | the client and the authorities can carry out audits with **fifteen working days' notice**. |
| Exit | transition support for **six months** after the end of the contract. |
| Subcontractors | the cloud provider is the only critical subcontractor; **it accepts indirect audits** (through Pentagroup) but not direct inspections by the client. |

## Delivery and people

*For the delivery lead.*

| Topic | Pentagroup's status |
|---|---|
| People available | for a project of this size, up to **28 people** at full capacity, of whom 4 seniors (at least 7 years of experience) free **from June 2027**. Seniors are 28% of the 220 in total, but only the free ones count for the project. |
| Comparable experience | every free senior has at least three years on financial platforms or digital public administration; none on tax collection. |
| Method | agile by default; it can work waterfall when required, with an estimated coordination cost 10-15% higher. |
| Timing | **the first wave of a project of this kind takes about 9 months from signature**, including a six-week initial analysis. A second wave takes another 6 months. |
| Contract signature | as a rule three to four weeks after the award. |
| Programme management | two project managers with PMO experience; one principal architect, **free from September 2027**. |
| Support after release | four weeks of hypercare included; beyond that, at a fixed price. |

## Evaluation criteria for a call for tenders

*For the account manager.* A call for tenders is assessed with five criteria, in this order.

1. **Sector and nature**: Pentagroup sells managed services and platforms, it does not resell licences or do building work.
2. **Competence**: its experience and products cover most of what is asked.
3. **Feasibility of the timing**: the delivery window required is compatible with the timing in the chapter «Delivery and people».
4. **Contract risk**: the terms required are acceptable without major waivers of the standard terms.
5. **Time to respond**: there are at least **21 days** from the working date to the offer deadline.

A call for tenders that fails criterion 1 or criterion 5 is not assessed further. The other three are weighed together: the
recommendation is **bid**, **bid with conditions** (if the problems can be solved with a clarification or a waiver) or
**do not bid**.
