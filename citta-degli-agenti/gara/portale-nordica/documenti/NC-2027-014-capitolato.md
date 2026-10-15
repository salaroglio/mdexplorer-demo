---
title: Capitolato tecnico – Piattaforma master del Progetto ATLANTE
author: Nordica Crediti S.p.A. – Patrimonio Destinato
---

# Capitolato tecnico – Piattaforma master del Progetto ATLANTE

## TL;DR

Nordica Crediti cerca un fornitore che progetti, sviluppi, metta in esercizio e gestisca per 36 mesi la piattaforma
«master» con cui il suo Patrimonio Destinato coordina la riscossione coattiva dei tributi degli Enti Locali. Il
documento dice cosa deve fare la piattaforma, con quali vincoli tecnici e di servizio, e cosa deve contenere
l'offerta.

- Il servizio parte entro il **01/01/2028**, a ondate, dopo un pilota con 1-2 Enti e 1-2 concessionari.
- L'offerta è in **due allegati separati** (tecnico ed economico) da consegnare entro il **30/04/2027, ore 15:00**.
- Il fornitore è una **Terza Parte ICT** ai sensi di DORA: SLA, notifica incidenti in 4 ore e piano di uscita sono obblighi.

> **Nota sul documento.** Questo capitolato è un testo di fantasia, derivato da un capitolato reale e riscritto:
> nomi, date e cifre sono inventati e il testo è abbreviato. Serve solo come materiale di lavoro per la demo.

## Indice

1. [Introduzione](#1-introduzione)
2. [Contesto e obiettivi](#2-contesto-e-obiettivi)
3. [Oggetto della fornitura e perimetro](#3-oggetto-della-fornitura-e-perimetro)
4. [Processi end-to-end da supportare](#4-processi-end-to-end-da-supportare)
5. [Requisiti funzionali](#5-requisiti-funzionali)
6. [Requisiti tecnici](#6-requisiti-tecnici)
7. [Modalità di realizzazione del progetto](#7-modalità-di-realizzazione-del-progetto)
8. [Servizi di esercizio, manutenzione e supporto](#8-servizi-di-esercizio-manutenzione-e-supporto)
9. [Modalità di presentazione dell'offerta](#9-modalità-di-presentazione-dellofferta)
10. [Allegati](#10-allegati)

## 1. Introduzione

La Legge di Bilancio 2027 attribuisce a Nordica Crediti, per il tramite di operatori specializzati iscritti a un
apposito albo (gli operatori «ex art. 53»), un ruolo attivo nella riscossione coattiva dei tributi degli Enti
Locali. Nordica opererà con un ruolo di **orchestrazione, monitoraggio e rendicontazione**, avvalendosi di operatori
ex art. 53, scelti con gara, per l'esecuzione materiale delle attività di riscossione.

Per questo è stato avviato il **Progetto ATLANTE**, che ha l'obiettivo di costituire il Patrimonio Destinato
(«Nordica PD»), la struttura interna incaricata di questa attività, e di definirne modello operativo, processi e
strumenti. Il governo del processo sarà abilitato da una **piattaforma «master»**, da sviluppare ex novo, che
dovrà dialogare con i sistemi gestionali dei concessionari tramite API, tracciati e meccanismi di sincronizzazione.

Il documento è la base per la selezione del provider incaricato di progettazione, sviluppo, messa in esercizio e
gestione della piattaforma. Descrive il processo da supportare, i punti di integrazione, i principali vincoli
tecnici e funzionali, i livelli di servizio (SLA/OLA) e lo schema del contratto, allegato a parte e oggetto di
definizione tra le parti dopo l'aggiudicazione.

### 1.1. Definizioni e acronimi

| Termine | Definizione |
|---|---|
| Nordica PD | Patrimonio Destinato di Nordica Crediti: orchestrazione, monitoraggio e rendicontazione della riscossione coattiva |
| Piattaforma master | Piattaforma centrale che abilita l'integrazione con i concessionari e con le piattaforme pubbliche |
| Operatore ex art. 53 / Concessionario / Servicer | Operatore iscritto all'albo di cui all'art. 53 del D.lgs. 446/1997, incaricato delle attività operative di riscossione |
| Ente Locale (EL) | Comune, Unione di Comuni o altro Ente che affida i crediti a Nordica PD |
| Pratica | Singola posizione debitoria: unità minima di lavorazione |
| Lista di carico | Insieme di pratiche trasmesso dall'Ente; 4-5 liste all'anno per i 5 anni dell'affidamento |
| Discarico | Restituzione o chiusura formale delle pratiche non lavorabili o non recuperabili |
| SEND | Servizio Notifiche Digitali, piattaforma nazionale per la notifica degli atti |
| PagoPA | Sistema nazionale dei pagamenti verso la Pubblica Amministrazione |
| Sistema slave | Applicativo del concessionario usato per la riscossione |
| Affidamento primario / secondario | Affidamento diretto delle entrate di un Ente / delega di un affidamento già in corso, in continuità |

## 2. Contesto e obiettivi

### 2.1. Inquadramento generale

Nordica PD opera come «master» di processo, con le funzioni di acquisizione e onboarding dei portafogli dagli
Enti, assegnazione delle pratiche ai concessionari, monitoraggio di lavorazioni e performance, gestione dei flussi
informativi e finanziari (incassi, riconciliazioni, riversamenti) e rendicontazione verso Enti e istituzioni.
Le attività operative di recupero restano in capo ai concessionari, nel rispetto delle regole di ingaggio definite
da Nordica PD.

### 2.2. Ruoli e attori

| Attore | Ruolo |
|---|---|
| Nordica PD | Orchestrazione e controllo; presidio di dati e performance; flussi finanziari e rendicontazione |
| Enti Locali | Affidano crediti e pratiche; collaborano su anomalie e discarichi; usano report e cruscotti |
| Operatori ex art. 53 | Eseguono la riscossione; rendicontano lavorazioni e incassi; gestiscono le richieste dei debitori (I livello) |
| Debitori | Pagano tramite i canali abilitati; presentano istanze; eventuale contenzioso |
| PSP / canali di incasso | Gestiscono i pagamenti (PagoPA e altri) e il riversamento sui conti di incasso |
| Piattaforme pubbliche | SEND e altre banche dati per integrazioni e arricchimento dei dati |

### 2.3. Principi guida

- **Centralità e neutralità**: nessuna discriminazione tra operatori.
- **Standardizzazione**: API e tracciati standard, modello dati canonico.
- **Tracciabilità end-to-end**: audit trail, riconciliazione e controlli.
- **Segregazione e accessi**: dati e operazioni separati per Ente e per operatore, con IAM e logging.
- **ICT security e ICT operation**: cifratura, vulnerability e patch management, rilevazione di attività anomale,
  incident management, hardening, SSDLC, separazione degli ambienti, capacity management.
- **Compliance**: GDPR e requisiti di resilienza (inclusi i presìdi DORA).
- **Continuità operativa e scalabilità**: backup, DR, restart, rollback e recovery.

### 2.4. Obiettivi della piattaforma master

1. Ridurre tempi e complessità di onboarding di Enti e portafogli, migliorando la qualità dei dati in ingresso.
2. Assegnare le pratiche ai concessionari con regole oggettive e basate sulle performance.
3. Dare una vista unica e tempestiva su lavorazioni e incassi, con KPI e alerting.
4. Quadrare e riconciliare i flussi finanziari (PagoPA, bonifici, altri canali) con pratiche e rendicontazioni.
5. Produrre gli input per fatturazione e riversamenti agli Enti, con controlli e audit trail.
6. Abilitare una rendicontazione strutturata verso Enti e istituzioni.

### 2.5. Assunzioni e vincoli di progetto

- La piattaforma comprende almeno una componente di orchestrazione, monitoraggio e rendicontazione e una **data
  platform** per l'analisi delle performance.
- Tutti i deliverable (analisi, documentazione, configurazioni, codice, personalizzazioni, integrazioni, evoluzioni)
  sono di **esclusiva titolarità di Nordica**.
- Tutti i dati e le informazioni trattati o generati (inclusi log e output applicativi) sono e restano di Nordica. Il
  fornitore li tratta **solo** per erogare i servizi e secondo le istruzioni di Nordica, con divieto di uso per
  finalità proprie o di comunicazione a terzi non autorizzati.
- L'avvio degli sviluppi e l'aggiudicazione possono essere subordinati a passaggi normativi e societari
  (decreto attuativo, costituzione del Patrimonio Destinato, autorizzazioni).
- L'aggiudicatario collabora con Nordica per la documentazione necessaria alla segnalazione della soluzione
  all'Autorità di vigilanza.
- Integrazione con i concessionari tramite interfacce standard e con le piattaforme pubbliche (PagoPA, SEND).

## 3. Oggetto della fornitura e perimetro

### 3.1. Oggetto della fornitura

La realizzazione della piattaforma master: progettazione funzionale e tecnica, sviluppo, architettura dati e rete,
configurazione e messa in esercizio, integrazione con sistemi esterni, migrazione dati ove applicabile, collaudo,
formazione e avvio operativo (hypercare). Il fornitore adotta un approccio industriale (DevSecOps, CI/CD, quality
gate, test automation) con piena tracciabilità di modifiche e decisioni. La piattaforma non deve vincolare
all'uso dei sistemi dei concessionari né creare concentrazione di rischio: richieste e aggiornamenti si accumulano
e si eseguono in modo asincrono rispetto alla disponibilità del master.

### 3.2. Perimetro funzionale (macro-moduli)

- anagrafiche e convenzioni degli Enti; portale e area riservata dell'Ente;
- onboarding delle liste di carico, controlli di qualità, gestione di scarti e anomalie;
- clustering, rating e dispatching delle pratiche (assegnazione iniziale e ribilanciamenti);
- monitoraggio di lavorazioni, KPI e SLA, alerting e solleciti;
- case management e ticketing (I e II livello): il master gestisce i ticket Enti-Nordica PD e concessionari-Nordica
  PD; i ticket debitori-concessionari restano negli applicativi dei concessionari ma ne rendicontano stato ed esito;
- gestione incassi, riconciliazione con gli estratti conto, incassi non abbinati;
- supporto a fatturazione e riversamenti, con workflow approvativi;
- pre-discarico e discarico delle pratiche;
- reporting e rendicontazione istituzionale, con esportazioni e cruscotti.

### 3.3. Perimetro tecnico

- architettura applicativa modulare, con integrazione via API e tracciati standard (Integration Layer);
- data platform (DWH o data lakehouse) e strumenti di BI per il monitoraggio;
- sicurezza: IAM, RBAC, SSO, segregazione dati, cifratura, logging e audit trail, hardening;
- osservabilità e rilevazione di attività anomale, con integrazione a eventuali SIEM;
- ambienti di sviluppo, test, pre-produzione e produzione; pipeline CI/CD e Infrastructure as Code;
- documentazione tecnica, manuali utente e runbook operativi;
- **cloud provider certificato ACN**. Il fornitore dichiara (i) eventuali dipendenze da servizi managed proprietari
  non sostituibili, (ii) il livello di portabilità di dati e codice, (iii) l'impegno a esportare tutti i dati in
  formato aperto.

### 3.4. Principi di design non funzionale

Sezione **obbligatoria** per la definizione della soluzione e per la proposta progettuale.

- **API-first**: API standard, documentate e versionate.
- **Event-driven e near realtime**, con gestione asincrona degli eventi.
- **Data model canonico**, documentato, interrogabile, con viste multidimensionali (Ente, pratica, soggetto, servicer).
- **Workflow low-code/no-code**: processi configurabili dal cliente con interventi minimi.
- **Architettura agentic-ready**: predisposta all'integrazione futura con sistemi di AI/ML e framework agentici. Il
  fornitore descrive use case e prerequisiti, senza impegno di attivazione immediata; è un elemento **premiale**, non
  obbligatorio.
- **Scalabilità elastica**, **security e compliance by design**, **osservabilità end-to-end**, **modularità**.
- **Portabilità e anti lock-in**: standard aperti e piena trasferibilità di infrastruttura e gestione applicativa.

### 3.5. Principi di operabilità

**Operabilità IT**

1. *Automation-first governabile*: ogni automazione è sotto controllo del team IT (fornitore e Nordica) e consente
   l'intervento umano.
2. *Self-healing con override umano*: il personale può sempre sovrascrivere le azioni automatiche.
3. *Osservabilità indipendente dal vendor*.
4. *Runbook codificati e trasferibili* al team IT di Nordica.
5. *Event-driven operations standardizzate*.

**Operabilità Business**

1. *Supervisione per eccezione*.
2. *Decisioni automatizzate ma spiegabili*: ogni azione automatica è tracciabile, giustificabile e ricostruibile.
3. *Configurabilità autonoma dei processi* da parte del business.
4. *Vista operativa unificata end-to-end*.
5. *Agentic operations*: architettura aperta a piattaforme AI di mercato, con l'AI come «agente intelligente» che
   affianca gli operatori.

### 3.6. Deliverable attesi

Analisi di dettaglio e backlog dei requisiti con matrice di tracciabilità (RTM); solution blueprint e architettura
target; specifiche di integrazione (API, tracciati, mapping, errori, idempotenza); software e configurazioni,
inclusi data platform e reporting; piani e casi di test (unit, integration, UAT, performance, security) con
evidenze; piano di migrazione e cut-over, piano di esercizio (AM/OPS) e **piano di uscita** (exit strategy, DORA);
formazione e knowledge transfer verso Nordica.

### 3.7. Normativa e regolamentazione di riferimento

GDPR (Reg. UE 2016/679); DORA (Reg. UE 2022/2554) per quanto applicabile a sistemi ICT, servizi digitali critici e
fornitori terzi; disposizioni di vigilanza della Banca d'Italia per gli intermediari finanziari; Direttiva NIS2
(UE 2022/2555); ISO/IEC 27001 e famiglia 27000; ISO/IEC 22301 (business continuity).

### 3.8. Esclusioni, dipendenze e assunzioni

Le attività non incluse o dipendenti da decisioni di programma (tracciati finali, scelte di infrastruttura, notifiche
e canali di incasso non standard) vanno **esplicitate nell'offerta**. Sono esclusi, salvo diversa indicazione, gli
applicativi proprietari dei concessionari e la gestione operativa delle lavorazioni.

### 3.9. Durata del contratto e opzioni di rinnovo

Il contratto dura **36 mesi** dalla sottoscrizione, con tacito rinnovo di 12 mesi. Nordica ha la facoltà di rinnovare
per ulteriori 36 + 12 mesi, con preavviso di sei mesi. La **mancata pubblicazione del decreto attuativo entro il
31/07/2027** dà a Nordica la facoltà di **recedere senza penali né indennizzi**, salvo il pagamento delle prestazioni
della prima fase di analisi regolarmente eseguite.

## 4. Processi end-to-end da supportare

### 4.1. Visione di insieme

La piattaforma master è il punto di orchestrazione dei flussi tra Enti Locali e concessionari: onboarding delle
pratiche, affido, raccolta dei dati di lavorazione (tracciato uniforme), rendicontazione e riconciliazione degli
incassi, input per la fatturazione, reportistica istituzionale, colloquio con gli Enti, monitoraggio di performance
e livelli di servizio.

Il processo parte da un affidamento **volontario** dell'Ente o da un affidamento **obbligatorio** previsto dalla
norma, in funzione di soglie di performance. Il debitore paga tramite PagoPA o bonifico; le somme confluiscono su
conti dedicati di Nordica PD (**uno per concessionario**) e sono riconciliate: per i bonifici la riconciliazione è
manuale, a cura del concessionario, che poi la rendiconta al master.

| Fase | Output atteso | Attore primario |
|---|---|---|
| 0. Attivazione e ingaggio dell'Ente | Elenco Enti target, opportunità aperte | Nordica PD |
| 1. Convenzionamento e set-up | Convenzione attiva, anagrafica, profili utente, scadenziario | Ente Locale e Nordica PD |
| 2. Onboarding liste di carico | Lotto validato, scarti gestiti, conferma di presa in carico | Ente Locale, poi Nordica PD |
| 3. Clustering e dispatching | Pratiche assegnate, log decisionale, notifica al concessionario | Nordica PD |
| 4. Lavorazione e monitoraggio | Stati aggiornati, timeline degli eventi, evidenze | Concessionario; Nordica PD monitora |
| 5. Incassi, rendicontazione, riconciliazione | Incassi abbinati, anomalie gestite, quadrature | Concessionario e Nordica PD |
| 6. Fatturazione e riversamenti | Prospetti mensili, workflow approvativi, ordini di riversamento | Nordica PD |
| 7. Pre-discarico e discarico | Liste approvate dall'Ente, chiusura della pratica | Concessionario (proposta), Nordica PD (governo), Ente (validazione) |

### 4.2. Attori coinvolti e responsabilità

Gli **Enti Locali** usano un portale per convenzionamento, upload delle liste, gestione di scarti e anomalie e
download di prospetti. Le **funzioni core di Nordica PD** configurano anagrafiche e assegnazioni, monitorano i KPI,
gestiscono i ticket, validano fatture e autorizzano i riversamenti. I **concessionari** si integrano per ricevere
le pratiche, inviare stati, rendicontare incassi, spese e competenze e gestire ticket. I **debitori** non
interagiscono con il master: pagano sui canali abilitati e le loro richieste vanno ai contact center dei
concessionari.

Il master gestisce i flussi informativi e il tracciamento degli eventi; **non esegue** le attività operative di
riscossione.

### 4.3. Macro-fasi del processo end-to-end

**4.3.1. Promozione e relazione con gli Enti.** Onboarding *inbound* (l'Ente si registra da solo) e *outbound* (serve
attività commerciale): la piattaforma gestisce elenchi di Enti target e pianificazione dei contatti, anagrafiche e
referenti, documenti di convenzione con versioning e tracciabilità delle firme, scadenziario con alert, comunicazioni
strutturate (da valutare mail e PEC con tracciatura).

**4.3.2. Onboarding liste di carico e gestione anomalie.** Ricezione (portale, API o canali concordati) con
protocollazione e versioning; controlli sintattici e semantici, anche su banche dati esterne; arricchimenti e
normalizzazioni; scarti con motivazione restituiti all'Ente; cicli di correzione fino al lotto pronto. Stati minimi:
lista ricevuta, validata, rifiutata.

**4.3.3. Clustering e affido ai concessionari.** Algoritmo di assegnazione configurabile e versionato (in primo luogo
l'ordine di assegnazione del lotto definito dal bando; poi area geografica, tributo, annualità, dimensione dell'Ente),
capacità e vincoli dei concessionari, generazione dell'affido e notifica, ribilanciamento nel continuo con log
decisionale e approvazioni. Output: lotto, operatore, data e ora, regola applicata, evidenza di presa in carico.

**4.3.4. Avvio lavorazione e monitoraggio.** Timeline completa per pratica, con stati configurabili: presa in carico,
emissione atto, notifica (SEND, PEC, raccomandata) e decorrenza dei termini, pagamento totale o parziale,
rateizzazione, sospensione, azioni cautelari ed esecutive, contenzioso, proposta di discarico, chiusura.

**4.3.5. Recupero forzoso e contenzioso.** Svolti dai concessionari; il master presidia con la raccolta degli stati e
delle azioni, e conserva le evidenze (per esempio le sentenze, che determinano chi sostiene certe spese). Lo scambio
informativo e l'aggiornamento degli stati avviene **almeno ogni settimana**.

**4.3.6. Richieste e assistenza (ticketing).** Richieste di Enti, debitori, terzi e concessionari con categorie,
priorità, SLA, assegnazione, storico e collegamento alla pratica; ingresso da portale, e-mail, PEC, call center o
API; escalation dal I livello (concessionario) al II (Nordica PD); report su volumi, tempi e backlog.

**4.3.7. Incassi, rendicontazione e riconciliazione.** Rendicontazioni dei concessionari **almeno giornaliere**,
abbinamento incasso-pratica (automatico dove possibile), worklist degli incassi non abbinati, quadratura con gli
estratti conto, ticket di anomalia, audit trail dei controlli.

**4.3.8. Fatturazione, competenze e riversamenti.** Calcolo delle spettanze e prospetti mensili per Ente e per
operatore; fatturazione passiva dei concessionari (spese postali, notifiche, legali, cautelari) con controlli massivi;
workflow approvativi e deleghe; integrazione con i sistemi amministrativo-contabili; calcolo del valore da riversare
all'Ente per compensazione tra incassi e rimborsi spese; gestione di fatture contestate.

**4.3.9. Pre-discarico e discarico.** Proposta dal concessionario con azioni svolte e motivazioni, liste di
pre-discarico e discarico con allegati, richieste di chiarimento, esito (approvato, respinto, follow-up), lista
finale, aggiornamento degli stati e archiviazione delle evidenze.

**4.3.10. Governance, reporting e ottimizzazione.** Cruscotti operativi e finanziari con drill-down per Ente,
operatore, lotto, tributo e periodo; alerting su scostamenti; report periodici e ad hoc con API di consultazione;
supporto ai controlli di II livello (audit, campionamento, azioni correttive).

### 4.4. Oggetti informativi e dati minimi

Anagrafiche (Enti, operatori, utenti e ruoli, debitori, terzi); pratica (identificativi, tributo e annualità, importi,
stato, atti, storico); incassi e movimenti (pagamenti, riconciliazioni, sospesi, rimborsi, spese e competenze);
documenti ed evidenze (convenzioni, liste di carico, atti e notifiche, relazioni di discarico); dataset per KPI.

### 4.5. KPI, reporting e monitoraggio

In prima istanza: performance di riscossione (tassi di recupero per tributo e annualità); efficienza operativa (tempi
medi, volumi, backlog, scarti); qualità e compliance (evidenze di notifica, completezza dei dati); incassi e flussi
(riconciliazioni, sospesi, tempi di riversamento); SLA su ticketing (presa in carico e risoluzione). Il set di KPI
sarà consolidato in un documento dedicato.

## 5. Requisiti funzionali

I requisiti di dettaglio (business requirements) sono **esclusi** dalla gara: li fornirà Nordica all'appaltatore nella
fase di avvio. Qui si riportano quelli di alto livello, utili a dimensionare e qualificare la soluzione.

### 5.1. Capabilities previste

| Ambito | Capability | Descrizione |
|---|---|---|
| Canali | Promozione verso gli Enti | Pubblicazione di esiti, rendiconti e comunicazioni, con tracciabilità di consegna |
| Canali | Onboarding Enti e pratiche | Censimento e attivazione; import massivi o puntuali con controlli minimi |
| Canali | Autenticazione e autorizzazione | Ruoli, segregazione delle funzioni, permessi per Ente, audit degli accessi |
| Position keeping | Anagrafe unica | «Golden record» di Enti, debitori, controparti e pratiche, con deduplica |
| Position keeping | Incarichi, contratti e commesse | Ciclo di vita, scadenze, condizioni, collegamento a lotti |
| Position keeping | Pratiche | Dati e stato end-to-end: eventi, esiti, motivazioni, allegati, storico |
| Position keeping | Condizioni e competenze | Regole economiche e calcolo delle competenze, con differenze caso per caso in base all'offerta di gara |
| Position keeping | Incassi | Registrazione puntuale o massiva, allocazione, eccezioni |

### 5.2. Catalogo dei requisiti (estratto)

| ID | Requisito | Priorità |
|---|---|---|
| FR-ONB-01 | Caricamento di una lista di carico con controlli sincroni su completezza e coerenza | Obbligatorio |
| FR-ONB-02 | Restituzione all'Ente degli scarti con motivazione standard | Obbligatorio |
| FR-DSP-01 | Assegnazione automatica dei lotti con algoritmo versionato e log decisionale | Obbligatorio |
| FR-MON-01 | Timeline per pratica con eventi dei concessionari, aggiornata almeno ogni settimana | Obbligatorio |
| FR-INC-01 | Abbinamento incasso-pratica con worklist dei casi non abbinati | Obbligatorio |
| FR-FAT-01 | Prospetti mensili per Ente e per operatore con workflow di approvazione | Obbligatorio |
| FR-DIS-01 | Liste di pre-discarico e discarico con motivazioni e allegati | Obbligatorio |
| FR-REP-01 | Cruscotti KPI con drill-down per Ente, operatore, lotto, tributo | Obbligatorio |
| FR-AGT-01 | Predisposizione all'integrazione con agenti AI, con registro delle azioni | Premiale |

### 5.3. Focus: processi di contabilità

Gli incassi sono accentrati su conti dedicati a Nordica PD. Il master calcola per ogni Ente il valore da riversare
(incassi meno rimborsi spese), produce le disposizioni di riversamento e ne traccia l'esecuzione. Ogni calcolo,
approvazione e disposizione deve lasciare un audit trail verificabile.

## 6. Requisiti tecnici

### 6.1. High-level architecture

Cinque livelli: **User Journeys** (portali per Enti, concessionari e funzioni interne); **Integration Layer** (API,
eventi, tracciati batch, gestione di errori e idempotenza); **Business Logic** (workflow configurabili, regole di
assegnazione e di calcolo); **Data Platform** (modello canonico, ETL, storage, qualità del dato); **Reporting e
Monitoraggio** (cruscotti, KPI, alerting).

### 6.2. Integrazioni e gestione dati

- **Piattaforme dei concessionari**: da 6 a 10 integrazioni, con interfacce standard e sincronizzazione dei dati.
- **Garanzie tecniche**: idempotenza, riprocessabilità, gestione dei picchi e dell'indisponibilità del master.
- **Segregazione dei flussi**: ogni concessionario e ogni Ente vedono solo i propri dati.
- **Dati di arricchimento**: interrogazione centralizzata di banche dati, con log di accessi e motivazioni.
- **Dati di quadratura** e **sistemi di sintesi**: estratti conto e flussi verso la contabilità di Nordica.

### 6.3. Sicurezza by design

Cifratura dei dati a riposo e in transito, gestione di identità e accessi (SSO, RBAC, MFA), gestione di chiavi e
segreti, segregazione per Ente e per operatore, logging e audit trail centralizzati, SAST e DAST nella pipeline,
hardening degli ambienti.

### 6.4. Governance di sicurezza, architettura dati e rete

Il fornitore descrive come verifica e governa nel tempo sicurezza, architettura dei dati e rete, con riesami
periodici e gestione in esercizio.

### 6.5. Dimensionamento operativo ipotizzato

Scenario «base»: solo gli Enti sotto soglia soggetti all'obbligo di affidamento (circa 1.400); sono esclusi i circa
7.000 Enti sopra soglia, che hanno solo la facoltà di affidare.

| Driver | 2028 | 2029 | 2030 | 2031+ |
|---|---|---|---|---|
| Pratiche caricate a sistema | 4 mln | 7 mln | 10 mln | 10 mln |
| Liste di carico complessive | 70.000 | 120.000 | 170.000 | 170.000 |
| Nuovi Enti onboardati | 450 | 450 | 450 | da definire |
| Enti totali gestiti | 450 | 900 | 1.350 | da definire |
| Piattaforme concessionari integrate | 6 (max 10) | 6 (max 10) | 6 (max 10) | 6 (max 10) |
| Documenti contrattuali emessi | 1.500 | 2.500 | 3.000 | 3.000 |
| Documenti a valenza legale in conservazione | 2.500 | 3.500 | 4.500 | 4.500 |

*Dati indicativi, basati sulla conoscenza del perimetro e della normativa a una data di riferimento.*

La piattaforma garantisce operatività **5x8** per le funzioni front-end e il supporto agli Enti, e gestione tecnica
dei flussi dati **5x24**.

### 6.6. Altri requisiti non funzionali

| ID | Requisito | Metrica |
|---|---|---|
| NFR-AVL-001 | Disponibilità dei servizi front-end in orario d'ufficio (5x8) | ≥ 99,8% mensile, escluse le finestre di manutenzione concordate |
| NFR-AVL-002 | Disponibilità dei servizi core del master (5x24) | ≥ 99,8% mensile, escluse le finestre di manutenzione concordate |
| NFR-AVL-003 | Manutenzioni programmabili con impatto controllato | Finestre configurabili, preavviso ≥ 5 giorni lavorativi |
| NFR-AVL-004 | Degrado controllato in caso di guasto di componenti non critici | Nessuna perdita di dati |
| NFR-PRF-001 | Tempi di risposta della UI | p95 ≤ 2 s sulle consultazioni standard |
| NFR-PRF-002 | Tempi di risposta delle API sincrone core | p95 ≤ 800 ms |
| NFR-PRF-003 | Import massivi entro finestre definite | Esempio: 1 milione di record per notte |
| NFR-SCL-001 | Scalabilità orizzontale | Scale-out senza downtime, ove possibile |
| NFR-SCL-002 | Capacity planning | Report, soglie di saturazione, trend mensile |
| NFR-DR-001 | Continuità operativa per dati e servizi core | **RPO ≤ 15 minuti; RTO ≤ 4 ore** |
| NFR-DR-002 | Test di DR periodici | ≥ 1 test all'anno, con report e remediation |
| NFR-DR-003 | Backup e restore | Restore test periodici |

## 7. Modalità di realizzazione del progetto

### 7.1. Piano di progetto

Il fornitore presenta un piano di lavoro sostenibile, che rispetti le tempistiche, con fasi e milestone.

### 7.2. Gruppo di lavoro

Ai fini di una valutazione positiva si richiede:

- un piano di lavoro sostenibile e la descrizione dell'organizzazione del team;
- una componente **senior non inferiore al 20%** del gruppo. Per «senior» si intende almeno **7 anni** di esperienza
  nell'IT, di cui almeno **3 in progetti comparabili** per complessità (riscossione tributi o recupero crediti,
  piattaforme finanziarie, PA digitale). I CV dei senior sono allegati in forma anonima, con i progetti comparabili;
  Nordica può chiedere colloqui tecnici di verifica prima della firma;
- profili specifici per il coordinamento, inclusi i responsabili del PMO;
- le soluzioni per garantire la **stabilità del team** e gestire le emergenze;
- il grado e le modalità di coinvolgimento attesi dei referenti di Nordica;
- un **profilo architetturale** che definisca standard di sviluppo e documentazione, governi l'architettura, garantisca
  qualità di produzione e collaudo, fornisca linee guida e assistenza agli sviluppatori ed esegua la code review.

### 7.3. Deliverable previsti

Requisiti e disegno (backlog con RTM, solution blueprint, specifiche di integrazione, checklist delle misure di
sicurezza); sviluppo e configurazione (codice, data platform, reporting); test ed evidenze (piani, casi, report,
difettologia); attivazione ed esercizio (cut-over plan, piano AM/OPS, formazione, documentazione e runbook).

### 7.4. Fasi progettuali previste

Il fornitore sceglie come declinare il piano, con una **preferenza per un approccio waterfall**. Fasi: consolidamento
del perimetro; progettazione, analisi e sviluppo; System Integration Test; Stress e Performance Test; User
Acceptance Test; Security Test; attivazione; hypercare; operatività a regime e gestione dei change.

- **7.4.1. Consolidamento del perimetro.** Nelle prime settimane si validano requisiti funzionali e tecnici, si
  definiscono perimetro dati e flussi, si produce il piano di progetto con la lista dei deliverable.
- **7.4.2. Progettazione e sviluppo.** Modello dati canonico, architettura applicativa, interfacce online (API),
  a eventi (Kafka) e batch, ETL, dati di monitoraggio e KPI, standard di versioning e backward compatibility, presìdi
  di qualità del dato.
- **7.4.3. SIT.** Il fornitore **coordina tutta la fase**, dialoga con gli altri fornitori, definisce ed esegue i test
  di integrazione con la piattaforma centrale di Nordica, gli Enti, i concessionari e i sistemi esterni.
- **7.4.4. Stress e performance.** Scenari di carico sui volumi dichiarati, come il caricamento massivo delle pratiche
  e il picco di Enti che caricano la lista l'ultimo giorno del mese; il fornitore predispone l'architettura di test.
- **7.4.5. UAT.** Strategia di test, piano complessivo, preparazione dei dati, gestione delle anomalie, reporting
  giornaliero.
- **7.4.6. Security test.** Vulnerability assessment e penetration test, SAST, DAST, security integration test,
  verifica di autenticazione, autorizzazione e segregazione, scansioni periodiche.
- **7.4.7. Attivazione in produzione.** Il servizio deve essere attivo **entro e non oltre il 01/01/2028**. Il fornitore
  può rilasciare **a ondate** (wave), garantendo l'operatività minima alla prima data. Precede un **pilota** con 1 o
  massimo 2 Enti di alta maturità e 1 o massimo 2 concessionari in fase avanzata di integrazione; dopo l'esito
  positivo il servizio si estende a tutti gli Enti.
- **7.4.8. Supporto post-rilascio.** Presidio continuativo sulle componenti già rilasciate, senza ostacolare gli
  sviluppi in parallelo.
- **7.4.9. Application maintenance e change request.** Il fornitore gestisce una **quota predefinita concordata** di
  richieste di modifica, per adeguamenti normativi ed esigenze evolutive o correttive, con un processo di Request e
  Change Management.

## 8. Servizi di esercizio, manutenzione e supporto

### 8.1. Modello di erogazione del servizio SaaS

Accesso tramite connessione sicura, utilizzo in modalità multi-tenant o single-tenant secondo l'offerta, conservazione
e gestione dei dati conformi alla normativa, aggiornamenti applicativi e tecnologici trasparenti, modello orientato
alla resilienza.

### 8.2. Qualificazione del servizio come Terza Parte ICT

Il servizio è qualificato come **Terza Parte di servizi ICT** a supporto di funzioni essenziali o importanti ai sensi
di DORA; il fornitore è responsabile del trattamento dei dati personali ai sensi del GDPR. L'esternalizzazione non
trasferisce le responsabilità istituzionali o decisionali, che restano a Nordica. Il fornitore garantisce:

- diritti di audit e ispezione delle autorità competenti, con preavviso di 5 giorni lavorativi;
- **notifica degli incidenti ICT rilevanti entro 4 ore**;
- **piano di exit** con supporto alla transizione per almeno 12 mesi;
- la propria Policy di gestione del rischio ICT e l'ultima valutazione di sicurezza disponibile, allegate all'offerta.

### 8.3. Ruoli e responsabilità del Fornitore e dell'Istituzione

Nel modello SaaS il fornitore è responsabile per l'intera durata del contratto di aggiornamento applicativo,
manutenzione correttiva ed evolutiva e gestione delle componenti. Nordica mantiene le responsabilità di governo e di
decisione.

### 8.4. Subfornitura e catena dei fornitori

Il ricorso a subfornitori non trasferisce le responsabilità di governo, controllo e coordinamento. I subfornitori
adottano misure di sicurezza coerenti con la criticità dei servizi e accettano clausole di audit, ispezione e
controllo a favore di Nordica. Il fornitore mantiene una mappatura aggiornata della catena di fornitura e compila il
registro delle informazioni DORA per sé e per i subfornitori.

### 8.5. Modello di servizio e organizzazione

Il fornitore presenta una **matrice RACI** (Nordica, fornitore, terze parti) per tutte le attività di servizio.

### 8.6. Service Management

Processi di Incident, Problem, Change e Request coerenti con le buone pratiche (per esempio ITIL), con
tracciabilità end-to-end delle richieste.

### 8.7. Supporto applicativo e funzionale

Presidio applicativo e funzionale completo: workflow, aggiornamento degli stati, rendicontazioni, riconciliazioni.

### 8.8. Help Desk Tecnico e assistenza applicativa

Un Help Desk Tecnico dedicato, con classificazione degli incidenti per gravità.

| Gravità | Descrizione | Presa in carico | Diagnosi | Risoluzione |
|---|---|---|---|---|
| P1 | Blocco del servizio o dei flussi critici | ≤ 15 minuti | ≤ 1 ora | ≤ 4 ore |
| P2 | Malfunzionamento rilevante | ≤ 1 ora | — | ≤ 8 ore |

Inoltre: monitoraggio di core e integrazioni critiche in **5x8**; reporting mensile su ticket, SLA, MTTR e backlog;
analisi delle cause radice (RCA) per P1 e P2.

### 8.9. Supporto infrastrutturale e componenti trasversali

Se le componenti di infrastruttura e piattaforma sono nel perimetro del fornitore, ne descrive in modo puntuale e
verificabile gestione, patching e finestre di manutenzione; se sono di Nordica o di terzi, descrive il proprio ruolo
di coordinamento.

### 8.10. Manutenzione correttiva, adeguativa ed evolutiva

Correzione dei difetti, adeguamenti normativi ed evoluzioni, entro la quota di change request concordata.

### 8.11. Monitoraggio, osservabilità e gestione proattiva

Monitoraggio, alerting e logging centralizzato, gestione proattiva degli eventi, con osservabilità non dipendente
dal solo fornitore.

### 8.12. Sicurezza operativa (Security Operations)

- **8.12.1.** Gestione delle vulnerabilità e patching.
- **8.12.2.** Gestione di credenziali e segreti.
- **8.12.3.** Monitoraggio degli eventi di sicurezza e incident response.
- **8.12.4.** Gestione degli accessi amministrativi.
- **8.12.5.** Logging, audit trail ed evidenze.
- **8.12.6.** Integrazione con il modello di resilienza operativa.

### 8.13. Continuità operativa, backup e disaster recovery

- **8.13.1. Backup e restore**, con restore test periodici.
- **8.13.2. RPO e RTO.** Il fornitore dichiara i valori garantiti per servizi core e non critici, coerenti con
  NFR-DR-001, li allinea all'architettura proposta (replica dati, alta disponibilità, multi-AZ) e ne dimostra il
  rispetto con report e test periodici.
- **8.13.3. Piano di DR.** Runbook per guasti applicativi, infrastrutturali, di rete e dei fornitori esterni;
  attivazione del sito secondario con trigger e responsabilità; failback; replica geografica dei dati; test almeno
  annuali con evidenze e azioni correttive.
- **8.13.4. Dipendenze esterne.** Gestione dell'indisponibilità di PagoPA, SEND, banche dati e concessionari.

### 8.14. Governance del servizio e reporting

Comitati periodici, report mensili su SLA, incidenti, change e capacity.

### 8.15. Documentazione, runbook e knowledge transfer

Documentazione aggiornata, runbook trasferibili al team di Nordica e piano di trasferimento delle conoscenze.

### 8.16. Piano di transizione del servizio (Service Transition)

Passaggio ordinato dalla fase di progetto all'esercizio, con criteri di accettazione e di avvio.

### 8.17. Servizio «as-a-service»

Il servizio è erogato come SaaS: il canone comprende esercizio, manutenzione e supporto descritti in questo capitolo.

## 9. Modalità di presentazione dell'offerta

L'offerta deve essere coerente con questo capitolato e includere un pricing coerente con perimetro e modalità di
erogazione. Il Concorrente trasmette una **Proposta Tecnica** in formato testuale (per esempio PDF), eventualmente
con slide di sintesi, che comprende almeno:

- la descrizione della Società, con struttura organizzativa e operatività in Italia;
- le credenziali pertinenti, in particolare con istituzioni finanziarie e attività di assistenza in quegli ambiti;
- la **piramide del team** dedicato e i relativi CV;
- la **Proposta Economica**, compilando l'Allegato B – Schema di Offerta Economica.

I chiarimenti si chiedono compilando l'Allegato C – Richiesta di chiarimento, da presentare il giorno dell'incontro
tecnico indicato nella Lettera di Invito: è **l'unico canale** per ottenere risposte. Le risposte sono condivise in
forma aggregata e anonima, per e-mail, a tutti i concorrenti.

L'offerta arriva con **due allegati separati** (tecnico ed economico), via e-mail a
`procedura@nordica-crediti.example`, entro le **ore 15:00 del 30/04/2027**. Nordica può chiedere approfondimenti e
integrazioni dopo l'analisi dell'offerta.

## 10. Allegati

- **10.1.** Overview del progetto ATLANTE: modello Nordica per la riscossione coattiva dei tributi degli Enti Locali.
- **10.2.** Macro-processo di riscossione coattiva dei tributi.
- **10.3.** Template di contratto standard IT di Nordica (allegato a parte).
