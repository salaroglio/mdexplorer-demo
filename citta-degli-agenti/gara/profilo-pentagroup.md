---
title: Profilo di Pentagroup
author: Ufficio commerciale Pentagroup
---

# Profilo di Pentagroup

## TL;DR

Pentagroup è un'azienda di servizi gestiti con 220 persone, abituata a lavorare per istituzioni finanziarie. Questo documento dice
chi è, che cosa sa fare oggi, dove i suoi standard differiscono da quelli di un committente molto esigente e con quali criteri
decide se partecipare a un bando.

- Ogni responsabile legge **il proprio capitolo**: tecnica, contratti, delivery e persone.
- I criteri per decidere se partecipare a un bando stanno in fondo, e li usa l'account manager.
- Tutti i dati qui sono **inventati**: servono al demo, non descrivono nessuna azienda reale.

> **Data di lavoro: 8 marzo 2027.** È il «oggi» di questa storia: le scadenze si calcolano da qui.

## Chi siamo

Pentagroup S.r.l. progetta, realizza e gestisce piattaforme in modalità SaaS per banche, intermediari finanziari e pubblica
amministrazione. Ha 220 persone, sede a Milano e una sede operativa a Bologna. Ha concluso tre progetti con istituzioni
finanziarie negli ultimi quattro anni:

| Progetto | Cliente (settore) | Anno | Natura |
|---|---|---|---|
| Piattaforma di gestione sinistri | assicurazioni | 2023 | piattaforma finanziaria, 14 mesi |
| Portale incassi per enti locali | pubblica amministrazione | 2024 | PA digitale, 11 mesi |
| Data platform per il credito al consumo | intermediario finanziario | 2025 | data platform, 16 mesi |

Pentagroup **non ha mai gestito la riscossione coattiva di tributi**: l'esperienza più vicina è il portale incassi.

## Tecnica

*Per il responsabile tecnico.*

| Tema | Stato di Pentagroup |
|---|---|
| Hosting | provider cloud europeo con qualificazione ACN per l'infrastruttura (IaaS) e per la piattaforma applicativa (PaaS). **Il data lakehouse gestito non è ancora qualificato ACN**: la qualificazione è attesa nel quarto trimestre 2027. |
| Disponibilità storica | 99,5% mensile sui servizi core, misurata sugli ultimi 24 mesi, finestre di manutenzione escluse. |
| Continuità | RPO 30 minuti, RTO 4 ore, con un test di disaster recovery all'anno. |
| Servizio | help desk e monitoraggio 5x8; reperibilità 24 ore su 7 giorni **non inclusa** nell'offerta standard (è un'opzione a pagamento). |
| Sicurezza | certificata ISO/IEC 27001. **ISO/IEC 22301 non ancora ottenuta**: audit di certificazione previsto a settembre 2027. |
| Normativa | registro delle informazioni DORA compilato per due clienti; conforme come «soggetto importante» alla direttiva NIS2. |
| Architettura | API-first, eventi su Kafka, modello dati canonico già usato in due progetti, motore di workflow low-code proprietario. |
| Agenti AI | framework di agenti con registro delle azioni e verifica umana, usato in produzione da un cliente. |
| Integrazioni | integrazioni standard con PagoPA già realizzate; con SEND mai realizzate. |
| Penetration test | eseguiti da un fornitore esterno, due volte all'anno. |

## Contratti

*Per il responsabile legale e commerciale.*

Le condizioni standard di Pentagroup, quelle che propone quando non negozia:

| Tema | Condizione standard |
|---|---|
| Proprietà | Pentagroup **conserva la proprietà dei componenti riusabili** (framework, librerie, modelli); concede al cliente una licenza perpetua e irrevocabile d'uso. Il resto, di norma, è del cliente. |
| Dati | i dati restano del cliente; Pentagroup li tratta come responsabile del trattamento e **non accetta clausole che le impediscano di usare dati anonimizzati e aggregati** per migliorare i propri servizi. |
| Responsabilità | tetto pari al corrispettivo annuo; non si accettano responsabilità illimitate. |
| Penali | tetto complessivo del 10% del corrispettivo annuo. |
| Recesso | il cliente può recedere con preavviso di sei mesi **pagando un indennizzo** pari alle prestazioni svolte più il 10% di quelle residue. |
| Incidenti | comunicazione degli incidenti rilevanti entro **24 ore**. |
| Audit | il cliente e le autorità possono fare audit con **preavviso di quindici giorni lavorativi**. |
| Uscita | supporto alla transizione per **sei mesi** dopo la fine del contratto. |
| Subfornitori | il provider cloud è l'unico subfornitore critico; **accetta audit indiretti** (tramite Pentagroup) ma non ispezioni dirette del committente. |

## Delivery e persone

*Per il responsabile delivery.*

| Tema | Stato di Pentagroup |
|---|---|
| Persone disponibili | per un progetto di questa dimensione, fino a **28 persone** a regime, di cui 4 senior (almeno 7 anni di esperienza) liberi **da giugno 2027**. I senior sono il 28% dei 220 totali, ma solo quelli liberi contano per il progetto. |
| Esperienza comparabile | ogni senior libero ha almeno tre anni su piattaforme finanziarie o PA digitale; nessuno su riscossione tributi. |
| Metodo | agile per default; sa lavorare a cascata (waterfall) quando richiesto, con un costo di coordinamento stimato del 10-15% in più. |
| Tempi | **la prima ondata di un progetto di questo tipo richiede circa 9 mesi dalla firma**, analisi iniziale di sei settimane compresa. Una seconda ondata altri 6 mesi. |
| Firma del contratto | di norma tre-quattro settimane dopo l'aggiudicazione. |
| Gestione del programma | due project manager con esperienza di PMO; un architetto principale, **libero da settembre 2027**. |
| Supporto dopo il rilascio | quattro settimane di hypercare incluse; oltre, a corpo. |

## Criteri di valutazione di un bando

*Per l'account manager.* Un bando si valuta con cinque criteri, in quest'ordine.

1. **Settore e natura**: Pentagroup vende servizi gestiti e piattaforme, non rivende licenze né fa lavori edili.
2. **Competenza**: l'esperienza e i prodotti coprono la maggior parte di ciò che si chiede.
3. **Fattibilità dei tempi**: la finestra di consegna richiesta è compatibile con i tempi del capitolo «Delivery e persone».
4. **Rischio contrattuale**: le condizioni richieste sono accettabili senza deroghe importanti alle condizioni standard.
5. **Tempo per rispondere**: ci sono almeno **21 giorni** dalla data di lavoro alla scadenza dell'offerta.

Un bando che non supera il criterio 1 o il criterio 5 non si valuta oltre. Gli altri tre si pesano insieme: la raccomandazione è
**andare**, **andare a condizioni** (se i problemi sono risolvibili con un chiarimento o una deroga) oppure **non andare**.
