---
title: La gara di Nordica
---

# La gara di Nordica: quattro persone, quattro agenti

## TL;DR

Pentagroup, un'azienda di servizi gestiti, riceve un invito a una gara di Nordica Crediti: un capitolato di molte pagine, da
leggere con occhi diversi (tecnici, legali, di delivery) prima di decidere se partecipare. Ogni persona ha un agente che
prepara la sua scheda; lei la verifica e decide se passarla avanti; alla fine l'account manager ha una sintesi.

- Quattro persone e quattro agenti: l'account manager e tre responsabili (tecnico, legale, delivery).
- **Gli agenti preparano, le persone decidono**: nessun lavoro passa al passo dopo senza la tua approvazione.
- Tutto è inventato: l'azienda, il committente, la gara (derivata da un capitolato reale, riscritto) e il sito dei bandi.

## Chi c'è

| Persona | Il suo agente | Cosa prepara | Dove |
|---|---|---|---|
| **Account manager** | `account-manager` | cerca i bandi nuovi e archivia la ricerca, avvia il giro, scrive la sintesi finale | `ricerche/ricerca-<data>.md`, `schede/sintesi.md` |
| **Responsabile tecnico** | `responsabile-tecnico` | la fattibilità tecnica: requisiti coperti e non | `schede/tecnica.md` |
| **Responsabile legale** | `responsabile-legale` | le clausole: accettabili, da negoziare, critiche | `schede/contrattuale.md` |
| **Responsabile delivery** | `responsabile-delivery` | il team e le date: se i tempi reggono | `schede/delivery.md` |

Nel demo **le quattro parti le fai tu**, una dopo l'altra: è il modo più rapido per vedere come passa il lavoro. In
un'azienda ciascuna sarebbe una persona diversa, sul proprio computer.

**Ogni agente risponde a una persona.** Lavora solo sul computer di quella persona, ed è lei a valutare ciò che l'agente
scrive; finché un agente non ha un responsabile, non parte. Chi risponde di chi sta scritto in
[Chi risponde di quale agente](responsabilita.md): all'inizio la tabella è vuota, e la riempi tu con «Sono tutti miei».

**Ogni agente produce due cose.** Il **documento** (la colonna «Dove»), che leggi e approvi, e un **messaggio** di poche
righe nella posta, con gli indicatori e il percorso del documento. Il messaggio dice dove guardare, non sostituisce il documento.

## Come gira

```plantuml
@startuml
!theme plain
skinparam ActivityBackgroundColor #F1F3F4
skinparam ActivityBorderColor #5F6368
skinparam ArrowColor #5F6368

|#F1F3F4|Sito dei bandi|
start
:Pubblica il bando\n(simulato);

|#F1F3F4|Account manager|
:Cerca i bandi nuovi,\nscrive la ricerca\ne propone la gara;

|#FEF7E0|Tu|
:Leggi la ricerca\ne avvia l'analisi;

fork
  |#F1F3F4|Tecnico|
  :Valuta gli aspetti tecnici;
fork again
  |#F1F3F4|Legale|
  :Valuta gli aspetti legali;
fork again
  |#F1F3F4|Delivery|
  :Valuta la fattibilità;
end fork

|#FEF7E0|Tu|
:Approva ciascun contributo;

|#F1F3F4|Account manager|
:Prepara la sintesi;

|#FEF7E0|Tu|
:Approva la sintesi;
stop
@enduml
```

1. L'agente dell'account manager **legge il sito dei bandi**, fa un primo filtro (la natura del bando e il tempo per
   rispondere) e scrive la **ricerca**: quali bandi sono nuovi, e quali meritano il giro. Non avvia niente da solo.
2. Tu leggi la ricerca e gli dici di avviare il giro: lui incarica i tre responsabili. La ricerca la approvi quando vuoi.
3. Ognuno **legge il capitolato con i suoi occhi** e scrive la sua scheda, che arriva da approvare.
4. Quando **approvi** una scheda, scegli tu di passare il lavoro all'account manager: è il tuo gesto che lo avvisa.
5. Quando ha le tre schede, l'account manager scrive la **sintesi** con i suoi indicatori. Anche quella la approvi tu.

## I file

| File | Cos'è |
|---|---|
| [capitolato.md](capitolato.md) | la gara di Nordica Crediti (Progetto ATLANTE), riscritta e abbreviata |
| [portale-nordica/bandi.md](portale-nordica/bandi.md) | **simula** il sito dei bandi del committente: tre procedure in corso |
| [registro-bandi.md](registro-bandi.md) | i bandi che Pentagroup ha già visto |
| [profilo-pentagroup.md](profilo-pentagroup.md) | chi è Pentagroup, un capitolo per responsabile, e i criteri per decidere se partecipare |
| `ricerche/` | l'esito di ogni ricerca dell'account manager sul portale |
| `schede/` | le tre schede dei responsabili e la sintesi: le scrivono gli agenti |

Gli agenti stanno in [.github/agents](../../.github/agents/account-manager.agent.md): file markdown come gli altri. Il blocco
`a2a:` in alto dice chi sono, che cosa fanno e a chi possono passare il lavoro; il testo sotto dice come lavorano.

## Cosa non fanno gli agenti

- **Non decidono.** Propongono; ogni passaggio al passo successivo è un tuo gesto.
- **Non scrivono nel progetto da soli.** Ogni documento resta in una copia a parte dell'agente finché non lo approvi.
- **Non inventano.** Se un'informazione non c'è nel capitolato o nel profilo scrivono «da chiarire»; ogni affermazione
  cita la sezione del capitolato, così puoi controllarla.
- **Non eseguono comandi.** Hanno solo gli strumenti per leggere e per scrivere i propri file.

> **Un'avvertenza onesta.** Il sito dei bandi è un file del progetto: in azienda l'agente lo leggerebbe con uno strumento
> di navigazione, che qui non c'è. Il resto del lavoro (lettura, confronto, schede, sintesi) è quello vero.

[Torna alla sezione](../README.md)
