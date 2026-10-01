---
title: Presentazioni
---

# Presentazioni

## TL;DR

Una presentazione di MdExplorer è un file markdown con una riga in più nell'intestazione. Si scrive come un
documento, si proietta dall'applicazione e si corregge dalla slide stessa. Questa pagina mostra come si
presenta, come si modifica e come si collegano più presentazioni fra loro.

- Le slide si separano con una riga `---`: tutto il resto è markdown normale.
- Sulla slide c'è una barra: «Presenta», «Modifica», schermo intero, penna per annotare.
- Un link porta a un'altra presentazione o a un documento, e una traccia in alto riporta indietro.

## Le presentazioni di questo progetto

| Presentazione | Cosa mostra |
|---|---|
| [MdExplorer](../presentazione/mdexplorer.md) | la presentazione del prodotto |
| [Dietro le quinte](../presentazione/dietro-le-quinte.md) | i numeri e il metodo, collegata alla prima |
| [Comitato guida](../caso-studio/slide-comitato.md) | cinque slide del caso di studio |

## Com'è fatta

L'intestazione del file dice che è una presentazione. Poi ogni slide è un pezzo di markdown.

```markdown
---
title: Comitato guida del 23 ottobre
document_type: slides
---

# Assistente AI per l'help desk

---

## Dove siamo

- Pilota approvato il 18 settembre
- Assistente al lavoro in ombra da una settimana
```

Per crearne una: «crea nuovo documento» nella barra, e nella finestra «Nuovo documento» il tipo «Slides».
Oppure chiedila a MarkAgent, che conosce le regole dalla skill `mde-slide`.

## La barra sulla slide

Apri [la presentazione del comitato](../caso-studio/slide-comitato.md): la barra è in alto a destra.

| Pulsante | Cosa fa |
|---|---|
| «Presenta» | la presentazione com'è, con i link che funzionano |
| «Modifica» | un clic su un testo lo corregge; la maniglia ⋮⋮ sposta una voce di elenco |
| 🎬 | in «Modifica», sceglie la transizione di questa slide o di tutte |
| ⛶ | mette la presentazione a schermo intero |
| 🖍 | annota la slide mentre presenti: penna, evidenziatore, gomma |

Le correzioni fatte in «Modifica» finiscono nel file markdown. Le annotazioni no: restano sulla slide finché
non ricarichi la pagina.

Sopra un diagramma, al passaggio del mouse, compaiono lo zoom e l'occhio 👁, che lo mostra a tutta pagina.

## Da provare

1. Apri [la presentazione del comitato](../caso-studio/slide-comitato.md).
2. Premi «Modifica» e correggi una parola del titolo con un clic.
3. Torna su «Presenta», premi 🖍 e cerchia un punto.
4. Vai all'ultima slide e segui un link: in alto a sinistra compare la traccia per tornare.
5. Tasto destro su un punto di elenco, poi «💬 Chiedi a MarkAgent»: la spiegazione usa i documenti del progetto.

## Collegare le presentazioni

Un link markdown verso un'altra presentazione la apre, e la traccia in alto a sinistra riporta alla slide di
partenza. Anche le frecce **←** e **→** della barra blu ricordano la slide.

| Link | Cosa apre |
|---|---|
| `[Numeri](dietro-le-quinte.md)` | tutta la presentazione |
| `[Numeri](dietro-le-quinte.md?pages=2-)` | dalla seconda slide in poi |
| `[Requisiti](../caso-studio/01-obiettivi-e-requisiti.md)` | un documento |
| `[Prototipo](../caso-studio/mockup/pannello-operatore.html)` | una pagina HTML del progetto |

## Cosa serve

Niente oltre a MdExplorer. «Chiedi a MarkAgent» richiede un motore AI: vedi [MarkAgent](03-markagent.md).

Avanti: [Word, PDF e sito](05-word-pdf-sito.md) · Indietro: [MarkAgent](03-markagent.md) · [Torna all'inizio](../README.md)
