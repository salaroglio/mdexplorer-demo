---
title: Technical specification – Master platform of the ATLANTE project
author: Nordica Crediti S.p.A. – Ring-fenced Fund
---

# Technical specification – Master platform of the ATLANTE project

## TL;DR

Nordica Crediti is looking for a supplier to design, develop, put into operation and run for 36 months the "master"
platform with which its Ring-fenced Fund coordinates the enforced collection of Local Authority taxes. This
document states what the platform must do, under which technical and service constraints, and what the bid must
contain.

- The service starts by **01/01/2028**, in waves, after a pilot with 1-2 Authorities and 1-2 concessionaires.
- The bid consists of **two separate attachments** (technical and economic), to be delivered by **30/04/2027, 15:00**.
- The supplier is an **ICT Third Party** under DORA: SLAs, incident notification within 4 hours and an exit plan are obligations.

> **Note on this document.** This specification is a fictional text, derived from a real specification and rewritten:
> names, dates and figures are invented and the text is shortened. It is only meant as working material for the demo.

## Contents

1. [Introduction](#1-introduction)
2. [Context and objectives](#2-context-and-objectives)
3. [Subject and scope of the supply](#3-subject-and-scope-of-the-supply)
4. [End-to-end processes to be supported](#4-end-to-end-processes-to-be-supported)
5. [Functional requirements](#5-functional-requirements)
6. [Technical requirements](#6-technical-requirements)
7. [Project delivery approach](#7-project-delivery-approach)
8. [Operation, maintenance and support services](#8-operation-maintenance-and-support-services)
9. [How to submit the bid](#9-how-to-submit-the-bid)
10. [Annexes](#10-annexes)

## 1. Introduction

The 2027 Budget Law assigns Nordica Crediti, through specialised operators entered in a dedicated register (the
"Art. 53" operators), an active role in the enforced collection of Local Authority taxes. Nordica will act in a role of
**orchestration, monitoring and reporting**, relying on Art. 53 operators, selected by tender, for the actual
execution of the collection activities.

For this purpose the **ATLANTE project** has been launched. Its objective is to set up the Ring-fenced Fund
("Nordica PD"), the internal structure in charge of this activity, and to define its operating model, processes and
tools. The process will be governed through a **"master" platform**, to be developed from scratch, which
shall communicate with the concessionaires' management systems through APIs, file layouts and synchronisation mechanisms.

This document is the basis for selecting the provider in charge of the design, development, commissioning and
operation of the platform. It describes the process to be supported, the integration points, the main technical and
functional constraints, the service levels (SLA/OLA) and the outline of the contract, which is attached separately and
will be finalised between the parties after the award.

### 1.1. Definitions and acronyms

| Term | Definition |
|---|---|
| Nordica PD | Ring-fenced Fund of Nordica Crediti: orchestration, monitoring and reporting of enforced collection |
| Master platform | Central platform that enables integration with the concessionaires and with the public platforms |
| Art. 53 operator / Concessionaire / Servicer | Operator entered in the register under Art. 53 of Legislative Decree 446/1997, in charge of the operational collection activities |
| Local Authority (LA) | Municipality, Union of Municipalities or other Authority that entrusts its receivables to Nordica PD |
| Case | Single debt position: the smallest unit of work |
| Collection list | Set of cases sent by the Authority; 4-5 lists per year for the 5 years of the assignment |
| Write-off | Formal return or closure of cases that cannot be worked or cannot be recovered |
| SEND | Digital Notification Service, the national platform for serving official documents |
| PagoPA | National system for payments to the Public Administration |
| Slave system | Concessionaire's application used for collection |
| Primary / secondary assignment | Direct assignment of an Authority's revenues / delegation of an assignment already in progress, in continuity |

## 2. Context and objectives

### 2.1. General framework

Nordica PD acts as process "master", with the functions of acquiring and onboarding portfolios from the
Authorities, assigning cases to the concessionaires, monitoring work and performance, managing information and
financial flows (collections, reconciliations, transfers) and reporting to Authorities and institutions.
The operational recovery activities remain the responsibility of the concessionaires, in compliance with the rules of
engagement defined by Nordica PD.

### 2.2. Roles and actors

| Actor | Role |
|---|---|
| Nordica PD | Orchestration and control; oversight of data and performance; financial flows and reporting |
| Local Authorities | Entrust receivables and cases; cooperate on anomalies and write-offs; use reports and dashboards |
| Art. 53 operators | Carry out collection; report work and collections; handle debtors' requests (1st level) |
| Debtors | Pay through the enabled channels; submit requests; possible litigation |
| PSPs / collection channels | Handle payments (PagoPA and others) and the transfer to the collection accounts |
| Public platforms | SEND and other databases for integration and data enrichment |

### 2.3. Guiding principles

- **Centrality and neutrality**: no discrimination between operators.
- **Standardisation**: standard APIs and file layouts, canonical data model.
- **End-to-end traceability**: audit trail, reconciliation and controls.
- **Segregation and access**: data and operations separated by Authority and by operator, with IAM and logging.
- **ICT security and ICT operation**: encryption, vulnerability and patch management, detection of anomalous activity,
  incident management, hardening, SSDLC, separation of environments, capacity management.
- **Compliance**: GDPR and resilience requirements (including the DORA safeguards).
- **Business continuity and scalability**: backup, DR, restart, rollback and recovery.

### 2.4. Objectives of the master platform

1. Reduce the time and complexity of onboarding Authorities and portfolios, improving the quality of incoming data.
2. Assign cases to the concessionaires with objective, performance-based rules.
3. Provide a single, timely view of work and collections, with KPIs and alerting.
4. Balance and reconcile financial flows (PagoPA, bank transfers, other channels) with cases and reports.
5. Produce the inputs for invoicing and for transfers to the Authorities, with controls and audit trail.
6. Enable structured reporting to Authorities and institutions.

### 2.5. Project assumptions and constraints

- The platform includes at least an orchestration, monitoring and reporting component and a **data
  platform** for performance analysis.
- All deliverables (analysis, documentation, configurations, code, customisations, integrations, enhancements)
  are the **exclusive property of Nordica**.
- All data and information processed or generated (including logs and application output) are and remain Nordica's. The
  supplier processes them **only** to deliver the services and according to Nordica's instructions; using them for its own
  purposes or disclosing them to unauthorised third parties is forbidden.
- The start of development and the award may be subject to regulatory and corporate steps
  (implementing decree, establishment of the Ring-fenced Fund, authorisations).
- The awarded supplier cooperates with Nordica on the documentation needed to notify the solution
  to the Supervisory Authority.
- Integration with the concessionaires through standard interfaces and with the public platforms (PagoPA, SEND).

## 3. Subject and scope of the supply

### 3.1. Subject of the supply

The delivery of the master platform: functional and technical design, development, data and network architecture,
configuration and commissioning, integration with external systems, data migration where applicable, acceptance testing,
training and operational start-up (hypercare). The supplier adopts an industrial approach (DevSecOps, CI/CD, quality
gates, test automation) with full traceability of changes and decisions. The platform must not create a dependency
on the use of the concessionaires' systems nor a concentration of risk: requests and updates are queued
and executed asynchronously with respect to the availability of the master.

### 3.2. Functional scope (macro-modules)

- Authority master data and agreements; Authority portal and reserved area;
- onboarding of collection lists, quality checks, handling of rejects and anomalies;
- clustering, rating and dispatching of cases (initial assignment and rebalancing);
- monitoring of work, KPIs and SLAs, alerting and reminders;
- case management and ticketing (1st and 2nd level): the master handles the Authority-Nordica PD and concessionaire-Nordica
  PD tickets; the debtor-concessionaire tickets stay in the concessionaires' applications, which report their status and outcome;
- collection management, reconciliation with bank statements, unmatched collections;
- support for invoicing and transfers, with approval workflows;
- pre-write-off and write-off of cases;
- institutional reporting, with exports and dashboards.

### 3.3. Technical scope

- modular application architecture, with integration through APIs and standard file layouts (Integration Layer);
- data platform (DWH or data lakehouse) and BI tools for monitoring;
- security: IAM, RBAC, SSO, data segregation, encryption, logging and audit trail, hardening;
- observability and detection of anomalous activity, with integration with any SIEM;
- development, test, pre-production and production environments; CI/CD pipelines and Infrastructure as Code;
- technical documentation, user manuals and operational runbooks;
- **ACN-certified cloud provider**. The supplier declares (i) any dependency on proprietary managed services
  that cannot be replaced, (ii) the level of portability of data and code, (iii) its commitment to export all data in
  an open format.

### 3.4. Non-functional design principles

This section is **mandatory** for the definition of the solution and for the design proposal.

- **API-first**: standard, documented and versioned APIs.
- **Event-driven and near real-time**, with asynchronous event handling.
- **Canonical data model**, documented, queryable, with multidimensional views (Authority, case, party, servicer).
- **Low-code/no-code workflows**: processes the customer can configure with minimal intervention.
- **Agentic-ready architecture**: prepared for future integration with AI/ML systems and agentic frameworks. The
  supplier describes use cases and prerequisites, with no commitment to immediate activation; this is an **award
  criterion**, not a mandatory one.
- **Elastic scalability**, **security and compliance by design**, **end-to-end observability**, **modularity**.
- **Portability and no lock-in**: open standards and full transferability of infrastructure and application management.

### 3.5. Operability principles

**IT operability**

1. *Governable automation-first*: every automation is under the control of the IT team (supplier and Nordica) and allows
   human intervention.
2. *Self-healing with human override*: staff can always override automatic actions.
3. *Vendor-independent observability*.
4. *Codified, transferable runbooks* for Nordica's IT team.
5. *Standardised event-driven operations*.

**Business operability**

1. *Supervision by exception*.
2. *Automated but explainable decisions*: every automatic action is traceable, justifiable and reconstructable.
3. *Autonomous configurability of processes* by the business.
4. *Unified end-to-end operational view*.
5. *Agentic operations*: architecture open to market AI platforms, with AI as an "intelligent agent" that
   works alongside the operators.

### 3.6. Expected deliverables

Detailed analysis and requirements backlog with a requirements traceability matrix (RTM); solution blueprint and target
architecture; integration specifications (APIs, file layouts, mapping, errors, idempotency); software and configurations,
including data platform and reporting; test plans and test cases (unit, integration, UAT, performance, security) with
evidence; migration and cut-over plan, operations plan (AM/OPS) and **exit plan** (exit strategy, DORA);
training and knowledge transfer to Nordica.

### 3.7. Applicable laws and regulations

GDPR (EU Reg. 2016/679); DORA (EU Reg. 2022/2554) as far as it applies to ICT systems, critical digital services and
third-party providers; Bank of Italy supervisory provisions for financial intermediaries; NIS2 Directive
(EU 2022/2555); ISO/IEC 27001 and the 27000 family; ISO/IEC 22301 (business continuity).

### 3.8. Exclusions, dependencies and assumptions

Activities that are not included or that depend on programme decisions (final file layouts, infrastructure choices,
non-standard notifications and collection channels) must be **stated explicitly in the bid**. Unless otherwise stated, the
concessionaires' proprietary applications and the operational handling of the work are excluded.

### 3.9. Contract term and renewal options

The contract lasts **36 months** from signature, with tacit renewal for 12 months. Nordica has the option to renew
for a further 36 + 12 months, with six months' notice. **If the implementing decree is not published by
31/07/2027**, Nordica has the right to **withdraw without penalties or compensation**, except for payment of the
services of the first analysis phase that have been duly performed.

## 4. End-to-end processes to be supported

### 4.1. Overview

The master platform is the orchestration point of the flows between Local Authorities and concessionaires: onboarding of
cases, assignment, collection of work data (uniform file layout), reporting and reconciliation of
collections, input for invoicing, institutional reporting, dialogue with the Authorities, monitoring of performance
and service levels.

The process starts from a **voluntary** assignment by the Authority or from a **mandatory** assignment required by
law, depending on performance thresholds. The debtor pays through PagoPA or bank transfer; the amounts flow into
dedicated Nordica PD accounts (**one per concessionaire**) and are reconciled: for bank transfers reconciliation is
manual, carried out by the concessionaire, which then reports it to the master.

| Phase | Expected output | Primary actor |
|---|---|---|
| 0. Activation and engagement of the Authority | List of target Authorities, open opportunities | Nordica PD |
| 1. Agreement and set-up | Active agreement, master data, user profiles, schedule of deadlines | Local Authority and Nordica PD |
| 2. Onboarding of collection lists | Validated batch, rejects handled, confirmation of acceptance | Local Authority, then Nordica PD |
| 3. Clustering and dispatching | Cases assigned, decision log, notification to the concessionaire | Nordica PD |
| 4. Work and monitoring | Updated statuses, event timeline, evidence | Concessionaire; Nordica PD monitors |
| 5. Collections, reporting, reconciliation | Collections matched, anomalies handled, balancing | Concessionaire and Nordica PD |
| 6. Invoicing and transfers | Monthly statements, approval workflows, transfer orders | Nordica PD |
| 7. Pre-write-off and write-off | Lists approved by the Authority, closure of the case | Concessionaire (proposal), Nordica PD (governance), Authority (validation) |

### 4.2. Actors involved and responsibilities

The **Local Authorities** use a portal for agreements, uploading lists, handling rejects and anomalies and
downloading statements. The **core functions of Nordica PD** configure master data and assignments, monitor KPIs,
handle tickets, validate invoices and authorise transfers. The **concessionaires** integrate to receive
cases, send statuses, report collections, costs and fees and handle tickets. The **debtors** do not
interact with the master: they pay on the enabled channels and their requests go to the concessionaires' contact
centers.

The master manages the information flows and the tracking of events; it **does not perform** the operational
collection activities.

### 4.3. Macro-phases of the end-to-end process

**4.3.1. Promotion and relationship with the Authorities.** *Inbound* onboarding (the Authority registers itself) and *outbound*
onboarding (sales activity is needed): the platform manages lists of target Authorities and contact planning, master data and
contact persons, agreement documents with versioning and traceability of signatures, a schedule of deadlines with alerts, structured
communications (e-mail and certified e-mail (PEC) with tracking to be evaluated).

**4.3.2. Onboarding of collection lists and handling of anomalies.** Receipt (portal, API or agreed channels) with
registration and versioning; syntactic and semantic checks, also against external databases; enrichment and
normalisation; rejects with reasons returned to the Authority; correction cycles until the batch is ready. Minimum statuses:
list received, validated, rejected.

**4.3.3. Clustering and assignment to the concessionaires.** Configurable and versioned assignment algorithm (first of all
the batch assignment order defined by the call for tenders; then geographical area, tax, tax year, size of the Authority),
capacity and constraints of the concessionaires, generation of the assignment and notification, continuous rebalancing with a
decision log and approvals. Output: batch, operator, date and time, rule applied, evidence of acceptance.

**4.3.4. Start of work and monitoring.** Complete timeline per case, with configurable statuses: acceptance,
issue of the deed, service (SEND, certified e-mail, registered mail) and running of time limits, full or partial payment,
instalment plan, suspension, precautionary and enforcement actions, litigation, write-off proposal, closure.

**4.3.5. Enforced recovery and litigation.** Carried out by the concessionaires; the master oversees them by collecting statuses and
actions, and keeps the evidence (for example judgments, which determine who bears certain costs). Information exchange
and status updates take place **at least once a week**.

**4.3.6. Requests and assistance (ticketing).** Requests from Authorities, debtors, third parties and concessionaires with categories,
priorities, SLAs, assignment, history and link to the case; intake from portal, e-mail, certified e-mail, call center or
API; escalation from 1st level (concessionaire) to 2nd level (Nordica PD); reports on volumes, times and backlog.

**4.3.7. Collections, reporting and reconciliation.** Concessionaires' reports **at least daily**,
collection-to-case matching (automatic where possible), worklist of unmatched collections, balancing with
bank statements, anomaly tickets, audit trail of the checks.

**4.3.8. Invoicing, fees and transfers.** Calculation of amounts due and monthly statements per Authority and per
operator; incoming invoices from the concessionaires (postal, notification, legal and precautionary costs) with bulk checks;
approval workflows and delegations; integration with the administrative and accounting systems; calculation of the amount to be
transferred to the Authority by offsetting collections against cost refunds; handling of disputed invoices.

**4.3.9. Pre-write-off and write-off.** Proposal by the concessionaire with the actions carried out and the reasons,
pre-write-off and write-off lists with attachments, requests for clarification, outcome (approved, rejected, follow-up), final
list, status update and archiving of the evidence.

**4.3.10. Governance, reporting and optimisation.** Operational and financial dashboards with drill-down by Authority,
operator, batch, tax and period; alerting on deviations; periodic and ad hoc reports with query APIs;
support for 2nd-level controls (audit, sampling, corrective actions).

### 4.4. Information objects and minimum data

Master data (Authorities, operators, users and roles, debtors, third parties); case (identifiers, tax and tax year, amounts,
status, deeds, history); collections and movements (payments, reconciliations, suspense items, refunds, costs and fees);
documents and evidence (agreements, collection lists, deeds and notifications, write-off reports); datasets for KPIs.

### 4.5. KPIs, reporting and monitoring

In the first instance: collection performance (recovery rates by tax and tax year); operational efficiency (average
times, volumes, backlog, rejects); quality and compliance (evidence of service, data completeness); collections and flows
(reconciliations, suspense items, transfer times); ticketing SLAs (acceptance and resolution). The KPI set
will be consolidated in a dedicated document.

## 5. Functional requirements

The detailed requirements (business requirements) are **excluded** from the tender: Nordica will provide them to the contractor in the
start-up phase. This section lists the high-level ones, useful to size and qualify the solution.

### 5.1. Expected capabilities

| Area | Capability | Description |
|---|---|---|
| Channels | Promotion to the Authorities | Publication of outcomes, reports and communications, with traceability of delivery |
| Channels | Onboarding of Authorities and cases | Registration and activation; bulk or individual imports with minimum checks |
| Channels | Authentication and authorisation | Roles, segregation of duties, permissions per Authority, access audit |
| Position keeping | Single master register | "Golden record" of Authorities, debtors, counterparties and cases, with deduplication |
| Position keeping | Mandates, contracts and orders | Life cycle, deadlines, conditions, link to batches |
| Position keeping | Cases | End-to-end data and status: events, outcomes, reasons, attachments, history |
| Position keeping | Conditions and fees | Economic rules and calculation of fees, with case-by-case differences based on the tender bid |
| Position keeping | Collections | Individual or bulk registration, allocation, exceptions |

### 5.2. Requirements catalogue (extract)

| ID | Requirement | Priority |
|---|---|---|
| FR-ONB-01 | Upload of a collection list with synchronous checks on completeness and consistency | Mandatory |
| FR-ONB-02 | Return of rejects to the Authority with a standard reason | Mandatory |
| FR-DSP-01 | Automatic assignment of batches with a versioned algorithm and a decision log | Mandatory |
| FR-MON-01 | Timeline per case with the concessionaires' events, updated at least once a week | Mandatory |
| FR-INC-01 | Collection-to-case matching with a worklist of unmatched items | Mandatory |
| FR-FAT-01 | Monthly statements per Authority and per operator with an approval workflow | Mandatory |
| FR-DIS-01 | Pre-write-off and write-off lists with reasons and attachments | Mandatory |
| FR-REP-01 | KPI dashboards with drill-down by Authority, operator, batch, tax | Mandatory |
| FR-AGT-01 | Readiness for integration with AI agents, with a log of actions | Award criterion |

### 5.3. Focus: accounting processes

Collections are centralised on accounts dedicated to Nordica PD. For each Authority the master calculates the amount to be transferred
(collections minus cost refunds), produces the transfer instructions and tracks their execution. Every calculation,
approval and instruction must leave a verifiable audit trail.

## 6. Technical requirements

### 6.1. High-level architecture

Five layers: **User Journeys** (portals for Authorities, concessionaires and internal functions); **Integration Layer** (APIs,
events, batch file layouts, error handling and idempotency); **Business Logic** (configurable workflows, assignment and
calculation rules); **Data Platform** (canonical model, ETL, storage, data quality); **Reporting and
Monitoring** (dashboards, KPIs, alerting).

### 6.2. Integrations and data management

- **Concessionaires' platforms**: from 6 to 10 integrations, with standard interfaces and data synchronisation.
- **Technical guarantees**: idempotency, reprocessability, handling of peaks and of the unavailability of the master.
- **Segregation of flows**: each concessionaire and each Authority sees only its own data.
- **Enrichment data**: centralised querying of databases, with a log of accesses and reasons.
- **Balancing data** and **summary systems**: bank statements and flows to Nordica's accounting.

### 6.3. Security by design

Encryption of data at rest and in transit, identity and access management (SSO, RBAC, MFA), management of keys and
secrets, segregation by Authority and by operator, centralised logging and audit trail, SAST and DAST in the pipeline,
hardening of the environments.

### 6.4. Governance of security, data architecture and network

The supplier describes how it verifies and governs security, data architecture and network over time, with periodic
reviews and management during operation.

### 6.5. Assumed operational sizing

"Base" scenario: only the Authorities below the threshold that are subject to mandatory assignment (about 1,400); the roughly
7,000 Authorities above the threshold, which only have the option to assign, are excluded.

| Driver | 2028 | 2029 | 2030 | 2031+ |
|---|---|---|---|---|
| Cases loaded into the system | 4 m | 7 m | 10 m | 10 m |
| Total collection lists | 70,000 | 120,000 | 170,000 | 170,000 |
| New Authorities onboarded | 450 | 450 | 450 | to be defined |
| Total Authorities managed | 450 | 900 | 1,350 | to be defined |
| Concessionaire platforms integrated | 6 (max 10) | 6 (max 10) | 6 (max 10) | 6 (max 10) |
| Contract documents issued | 1,500 | 2,500 | 3,000 | 3,000 |
| Legally binding documents in long-term archiving | 2,500 | 3,500 | 4,500 | 4,500 |

*Indicative figures, based on knowledge of the scope and of the legislation at a reference date.*

The platform guarantees **5x8** operation for the front-end functions and support to the Authorities, and **5x24**
technical management of the data flows.

### 6.6. Other non-functional requirements

| ID | Requirement | Metric |
|---|---|---|
| NFR-AVL-001 | Availability of front-end services during office hours (5x8) | ≥ 99.8% monthly, excluding agreed maintenance windows |
| NFR-AVL-002 | Availability of the master's core services (5x24) | ≥ 99.8% monthly, excluding agreed maintenance windows |
| NFR-AVL-003 | Schedulable maintenance with controlled impact | Configurable windows, notice ≥ 5 working days |
| NFR-AVL-004 | Controlled degradation in case of failure of non-critical components | No data loss |
| NFR-PRF-001 | UI response times | p95 ≤ 2 s on standard queries |
| NFR-PRF-002 | Response times of the core synchronous APIs | p95 ≤ 800 ms |
| NFR-PRF-003 | Bulk imports within defined windows | Example: 1 million records per night |
| NFR-SCL-001 | Horizontal scalability | Scale-out without downtime, where possible |
| NFR-SCL-002 | Capacity planning | Reports, saturation thresholds, monthly trend |
| NFR-DR-001 | Business continuity for core data and services | **RPO ≤ 15 minutes; RTO ≤ 4 hours** |
| NFR-DR-002 | Periodic DR tests | ≥ 1 test per year, with report and remediation |
| NFR-DR-003 | Backup and restore | Periodic restore tests |

## 7. Project delivery approach

### 7.1. Project plan

The supplier presents a sustainable work plan that meets the timeline, with phases and milestones.

### 7.2. Project team

For a positive evaluation the following are required:

- a sustainable work plan and a description of how the team is organised;
- a **senior share of no less than 20%** of the team. "Senior" means at least **7 years** of experience
  in IT, of which at least **3 in projects of comparable** complexity (tax collection or debt recovery,
  financial platforms, digital public administration). The CVs of the senior staff are attached in anonymous form, with the comparable projects;
  Nordica may request technical verification interviews before signature;
- specific profiles for coordination, including the PMO leads;
- the measures to ensure **team stability** and to handle emergencies;
- the expected degree and manner of involvement of Nordica's contact persons;
- an **architect profile** that defines development and documentation standards, governs the architecture, ensures
  production and acceptance-test quality, provides guidelines and support to the developers and performs code review.

### 7.3. Expected deliverables

Requirements and design (backlog with RTM, solution blueprint, integration specifications, checklist of security
measures); development and configuration (code, data platform, reporting); tests and evidence (plans, cases, reports,
defect management); activation and operation (cut-over plan, AM/OPS plan, training, documentation and runbooks).

### 7.4. Expected project phases

The supplier chooses how to structure the plan, with a **preference for a waterfall approach**. Phases: consolidation
of the scope; design, analysis and development; System Integration Test; Stress and Performance Test; User
Acceptance Test; Security Test; activation; hypercare; steady-state operation and change management.

- **7.4.1. Consolidation of the scope.** In the first weeks the functional and technical requirements are validated, the
  data scope and flows are defined, and the project plan with the list of deliverables is produced.
- **7.4.2. Design and development.** Canonical data model, application architecture, online (API), event-based (Kafka)
  and batch interfaces, ETL, monitoring data and KPIs, versioning and backward compatibility standards, data
  quality safeguards.
- **7.4.3. SIT.** The supplier **coordinates the whole phase**, works with the other suppliers, defines and runs the
  integration tests with Nordica's central platform, the Authorities, the concessionaires and the external systems.
- **7.4.4. Stress and performance.** Load scenarios on the declared volumes, such as the bulk loading of cases
  and the peak of Authorities uploading their list on the last day of the month; the supplier sets up the test architecture.
- **7.4.5. UAT.** Test strategy, overall plan, data preparation, anomaly management, daily
  reporting.
- **7.4.6. Security test.** Vulnerability assessment and penetration test, SAST, DAST, security integration test,
  verification of authentication, authorisation and segregation, periodic scans.
- **7.4.7. Go-live.** The service must be live **no later than 01/01/2028**. The supplier
  may release **in waves**, ensuring minimum operation at the first date. It is preceded by a **pilot** with 1 or
  at most 2 high-maturity Authorities and 1 or at most 2 concessionaires at an advanced stage of integration; after a positive
  outcome the service is extended to all Authorities.
- **7.4.8. Post-release support.** Continuous oversight of the components already released, without hindering
  parallel development.
- **7.4.9. Application maintenance and change requests.** The supplier handles a **predefined, agreed quota** of
  change requests, for regulatory adjustments and for evolutionary or corrective needs, through a Request and
  Change Management process.

## 8. Operation, maintenance and support services

### 8.1. SaaS service delivery model

Access through a secure connection, use in multi-tenant or single-tenant mode according to the bid, storage
and management of data in compliance with the law, transparent application and technology updates, a model oriented
to resilience.

### 8.2. Qualification of the service as an ICT Third Party

The service qualifies as an **ICT Third-Party Service** supporting critical or important functions under
DORA; the supplier is the processor of personal data under the GDPR. Outsourcing does not
transfer the institutional or decision-making responsibilities, which remain with Nordica. The supplier guarantees:

- audit and inspection rights for the competent authorities, with 5 working days' notice;
- **notification of major ICT incidents within 4 hours**;
- an **exit plan** with transition support for at least 12 months;
- its own ICT Risk Management Policy and the latest available security assessment, attached to the bid.

### 8.3. Roles and responsibilities of the Supplier and of the Institution

In the SaaS model the supplier is responsible, for the whole term of the contract, for application updates,
corrective and evolutionary maintenance and management of the components. Nordica retains the governance and
decision-making responsibilities.

### 8.4. Subcontracting and supply chain

The use of subcontractors does not transfer the responsibilities of governance, control and coordination. Subcontractors
adopt security measures consistent with the criticality of the services and accept audit, inspection and
control clauses in favour of Nordica. The supplier keeps an up-to-date map of the supply chain and fills in the
DORA register of information for itself and for its subcontractors.

### 8.5. Service model and organisation

The supplier presents a **RACI matrix** (Nordica, supplier, third parties) for all service activities.

### 8.6. Service Management

Incident, Problem, Change and Request processes consistent with good practice (for example ITIL), with
end-to-end traceability of requests.

### 8.7. Application and functional support

Complete application and functional support: workflows, status updates, reports, reconciliations.

### 8.8. Technical Help Desk and application support

A dedicated Technical Help Desk, with classification of incidents by severity.

| Severity | Description | Acceptance | Diagnosis | Resolution |
|---|---|---|---|---|
| P1 | Service or critical flows blocked | ≤ 15 minutes | ≤ 1 hour | ≤ 4 hours |
| P2 | Significant malfunction | ≤ 1 hour | — | ≤ 8 hours |

In addition: **5x8** monitoring of the core and of the critical integrations; monthly reporting on tickets, SLAs, MTTR and backlog;
root cause analysis (RCA) for P1 and P2.

### 8.9. Infrastructure support and cross-cutting components

If the infrastructure and platform components are within the supplier's scope, the supplier describes their management,
patching and maintenance windows in a precise and verifiable way; if they belong to Nordica or to third parties, it describes its
coordination role.

### 8.10. Corrective, adaptive and evolutionary maintenance

Correction of defects, regulatory adjustments and enhancements, within the agreed quota of change requests.

### 8.11. Monitoring, observability and proactive management

Monitoring, alerting and centralised logging, proactive event management, with observability that does not depend
on the supplier alone.

### 8.12. Security Operations

- **8.12.1.** Vulnerability management and patching.
- **8.12.2.** Management of credentials and secrets.
- **8.12.3.** Monitoring of security events and incident response.
- **8.12.4.** Management of administrative access.
- **8.12.5.** Logging, audit trail and evidence.
- **8.12.6.** Integration with the operational resilience model.

### 8.13. Business continuity, backup and disaster recovery

- **8.13.1. Backup and restore**, with periodic restore tests.
- **8.13.2. RPO and RTO.** The supplier declares the guaranteed values for core and non-critical services, consistent with
  NFR-DR-001, aligns them with the proposed architecture (data replication, high availability, multi-AZ) and demonstrates
  compliance with reports and periodic tests.
- **8.13.3. DR plan.** Runbooks for application, infrastructure, network and external supplier failures;
  activation of the secondary site with triggers and responsibilities; failback; geographical replication of data; tests at least
  once a year with evidence and corrective actions.
- **8.13.4. External dependencies.** Handling of the unavailability of PagoPA, SEND, databases and concessionaires.

### 8.14. Service governance and reporting

Periodic committees, monthly reports on SLAs, incidents, changes and capacity.

### 8.15. Documentation, runbooks and knowledge transfer

Up-to-date documentation, runbooks transferable to Nordica's team and a knowledge transfer plan.

### 8.16. Service Transition plan

Orderly transition from the project phase to operation, with acceptance and start-up criteria.

### 8.17. "As-a-service" delivery

The service is delivered as SaaS: the fee includes the operation, maintenance and support described in this chapter.

## 9. How to submit the bid

The bid must be consistent with this specification and include pricing consistent with the scope and the delivery
model. The Bidder submits a **Technical Proposal** in text format (for example PDF), possibly
with summary slides, which includes at least:

- a description of the Company, with its organisational structure and operations in Italy;
- relevant credentials, in particular with financial institutions and support activities in those areas;
- the **pyramid of the dedicated team** and the related CVs;
- the **Economic Proposal**, by filling in Annex B – Economic Bid Form.

Clarifications are requested by filling in Annex C – Request for clarification, to be submitted on the day of the technical
meeting indicated in the Letter of Invitation: it is **the only channel** for obtaining answers. Answers are shared in
aggregated and anonymous form, by e-mail, with all bidders.

The bid is delivered as **two separate attachments** (technical and economic), by e-mail to
`procedura@nordica-crediti.example`, by **15:00 on 30/04/2027**. Nordica may request further details and
additions after analysing the bid.

## 10. Annexes

- **10.1.** Overview of the ATLANTE project: Nordica's model for the enforced collection of Local Authority taxes.
- **10.2.** Macro-process of enforced tax collection.
- **10.3.** Nordica's standard IT contract template (attached separately).
