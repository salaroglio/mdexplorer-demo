---
title: La gara di Nordica
---

# La gara di Nordica: quattro persone, quattro agenti

## TL;DR

Pentagroup, un'azienda di servizi gestiti, riceve un invito a una gara di Nordica Crediti: un capitolato di molte pagine, da
leggere con occhi diversi (tecnici, legali, di delivery) prima di decidere se partecipare. Ogni persona ha un agente che
prepara la sua scheda; lei la verifica e la approva; alla fine l'account manager ha una sintesi. Chi lavora dopo chi lo
dice il workflow del progetto, e lo fa partire MdExplorer.

- Quattro persone e quattro agenti: l'account manager e tre responsabili (tecnico, legale, delivery).
- **Gli agenti preparano, le persone decidono**: nessun lavoro passa al passo dopo senza l'approvazione di chi ne risponde;
  i passaggi li fa MdExplorer, seguendo il workflow.
- Tutto è inventato: l'azienda, il committente, la gara (derivata da un capitolato reale, riscritto) e il sito dei bandi.

## Chi c'è

| Persona | Il suo agente | Cosa prepara | Dove |
|---|---|---|---|
| **Account manager** | `account-manager` | cerca i bandi nuovi e archivia la ricerca, scrive la sintesi finale | `ricerche/ricerca-<data>.md`, `schede/sintesi.md` |
| **Responsabile tecnico** | `responsabile-tecnico` | la fattibilità tecnica: requisiti coperti e non | `schede/tecnica.md` |
| **Responsabile legale** | `responsabile-legale` | le clausole: accettabili, da negoziare, critiche | `schede/contrattuale.md` |
| **Responsabile delivery** | `responsabile-delivery` | il team e le date: se i tempi reggono | `schede/delivery.md` |

Nel demo **le quattro parti le fai tu**, una dopo l'altra: è il modo più rapido per vedere come passa il lavoro. In
un'azienda ciascuna sarebbe una persona diversa, sul proprio computer.

**Ogni agente risponde a una persona, o a un team.** Lavora solo sul computer di chi ne risponde, ed è quella persona a
valutare ciò che l'agente scrive; finché un agente non ha un responsabile, non parte. Chi risponde di chi sta scritto in
[Chi risponde di quale agente](responsabilita.md): all'inizio la tabella è vuota, e la riempi tu con «Sono tutti miei».

**Ogni agente produce due cose.** Il **documento** (la colonna «Dove»), che leggi e approvi, e un **messaggio** di poche
righe nella posta, con gli indicatori e il percorso del documento. Il messaggio dice dove guardare, non sostituisce il documento.

## Come gira

Il giro lo disegna MdExplorer dal [workflow della gara](workflow.md): è lo stesso piano che esegue, quindi il disegno non
va mai aggiornato a mano. Un clic su un riquadro apre la scheda dell'agente, un clic su un file apre il documento.

```plantuml(@workflow, ./gara.workflow.json)
```

**Prima di cominciare**, ogni persona prende in carico il proprio agente: da quel momento ne risponde, e l'agente lavora
solo sul suo computer. Poi:

1. **L'account manager** lancia il suo agente: legge il sito dei bandi, fa un primo filtro (la natura del bando e il tempo
   per rispondere) e scrive la **ricerca**. Per ogni bando che merita il giro propone un pulsante «Avvia il giro su …».
2. L'account manager approva la ricerca e **preme il pulsante** del bando. Se un agente ha più responsabili (un team),
   sceglie lì chi farà la sua scheda. Da questo momento i passaggi li fa MdExplorer: nessuno incarica nessuno a mano.
3. **Ogni responsabile** trova nella posta la sua scheda «da avviare», con l'incarico. La avvia (con le sue indicazioni,
   se vuole), la rifiuta dicendo perché, o la passa a un collega dello stesso team.
4. L'agente scrive la scheda; **il responsabile** la verifica e la approva, o la rifiuta e la fa ripartire.
5. Quando le tre schede sono approvate, **la sintesi parte da sola** sul computer dell'account manager, con i file delle
   tre schede. L'account manager la legge e decide se partecipare.

Ogni passo e ogni gesto restano scritti nel **registro del giro**, in git, su un ramo a parte (`mde/giri`): ogni computer
lo legge e fa i passi delle sue persone, senza bisogno di un server che coordini. Nel demo le quattro persone sei tu,
una dopo l'altra, su un computer solo.

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
`a2a:` in alto dice chi sono, che cosa fanno e quali pulsanti possono proporre; il testo sotto dice come lavorano.

## Cosa non fanno gli agenti

- **Non decidono e non si passano il lavoro.** Propongono; ogni passo parte da un gesto di una persona (un pulsante,
  un avvio, un'approvazione) o da ciò che il workflow dice, mai da un agente che scrive a un altro.
- **Non scrivono nel progetto da soli.** Ogni documento resta in una copia a parte dell'agente finché non lo approvi.
- **Non inventano.** Se un'informazione non c'è nel capitolato o nel profilo scrivono «da chiarire»; ogni affermazione
  cita la sezione del capitolato, così puoi controllarla.
- **Non eseguono comandi.** Hanno solo gli strumenti per leggere e per scrivere i propri file.

> **Un'avvertenza onesta.** Il sito dei bandi è un file del progetto: in azienda l'agente lo leggerebbe con uno strumento
> di navigazione, che qui non c'è. Il resto del lavoro (lettura, confronto, schede, sintesi) è quello vero.

[Torna alla sezione](../README.md)
