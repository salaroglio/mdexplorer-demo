---
title: MdExplorer, il progetto demo
author: Mark
description: Progetto demo di MdExplorer. Una presentazione, otto prove da fare con le proprie mani e un caso di studio su cui far lavorare l'agente AI.
---

# MdExplorer, il progetto demo

> **TL;DR** — Questo progetto mostra cosa fa MdExplorer usando MdExplorer. C'è una presentazione da
> guardare, un percorso di otto prove da fare, e un caso di studio su cui far lavorare MarkAgent, l'agente AI.
> Tutto ciò che vedi è un file markdown dentro un repository git.

MdExplorer è il posto dove persone e agenti AI lavorano sugli stessi documenti. Le persone leggono,
correggono e presentano. Gli agenti leggono, scrivono e verificano. Il formato è uno solo, il markdown, e la
cronologia è una sola, git.

## Da dove partire

| Se hai | Apri | Cosa trovi |
|---|---|---|
| dieci minuti | [La presentazione](presentazione/mdexplorer.md) | l'idea, in venti slide |
| mezz'ora | [Il percorso: prova tu](tour/01-documenti-vivi.md) | otto prove da fare |
| un'ora | [Il caso di studio](caso-studio/README.md) | un progetto su cui far lavorare l'AI |
| mezz'ora in più | [La città degli agenti](citta-degli-agenti/README.md) | gli agenti AI che abitano il progetto e si scrivono tra loro |

## Il percorso: prova tu

| # | Pagina | Cosa provi |
|---|---|---|
| 1 | [Documenti vivi](tour/01-documenti-vivi.md) | file inclusi, comandi che si eseguono, testo che si corregge sul posto |
| 2 | [Diagrammi che rispondono](tour/02-diagrammi.md) | un clic accende le relazioni, con un colore per tipo |
| 3 | [MarkAgent](tour/03-markagent.md) | l'agente AI che legge e scrive i documenti del progetto |
| 4 | [Presentazioni](tour/04-presentazioni.md) | slide scritte in markdown, corrette dalla slide stessa |
| 5 | [Word, PDF e sito](tour/05-word-pdf-sito.md) | i formati di consegna, rigenerati quando serve |
| 6 | [Git senza terminale](tour/06-git.md) | cosa è cambiato, chi l'ha cambiato, come si salva |
| 7 | [Regole, skill e MCP](tour/07-regole-skill-mcp.md) | come si insegna all'agente il modo di lavorare di casa |
| 8 | [Test scritti in italiano](tour/08-test-e2e.md) | l'agente controlla un sito e lascia le prove |

## La città degli agenti

Gli agenti AI possono anche **abitare** il progetto: ognuno con un nome, un ruolo e un documento da presidiare, e con
la possibilità di scriversi tra loro. Tu decidi di chi fidarti e ricevi il risultato nella posta.
[Sei prove](citta-degli-agenti/README.md) per vederlo con le tue mani, sul caso di studio di Alpina Servizi, e una
[presentazione](citta-degli-agenti/presentazione/citta-degli-agenti.md) di dieci minuti.

## Il caso di studio

[Alpina Servizi](caso-studio/README.md) è un'azienda inventata che prova un assistente AI per il suo help
desk. Nella cartella ci sono i requisiti, l'architettura, il piano, un verbale e una presentazione.
Nei documenti sono nascoste **tre incongruenze**: chiedi a MarkAgent di trovarle.

## Un esempio in più: il wiki che si mantiene da solo

La cartella [llm-wiki](llm-wiki/README.md) mostra un altro modo di usare un progetto MdExplorer: un wiki che
un agente AI tiene aggiornato, secondo lo schema proposto da Andrej Karpathy.

## Come è fatto questo progetto

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
* Progetto demo
** presentazione
***_ la presentazione di MdExplorer
***_ dietro le quinte
** tour
***_ otto prove da fare
left side
** caso-studio
***_ requisiti, architettura, piano
***_ verbale e slide del comitato
** llm-wiki
***_ un wiki mantenuto dall'AI
@endmindmap
```

---

*Questo repository fa parte di [MdExplorer](https://github.com/salaroglio/MdExplorer), software libero con
licenza MIT. In MdExplorer si apre con la guida di Mark, voce «Crea progetto demo». La versione inglese di questo
demo è nel ramo `en` dello stesso repository: Mark scarica quella della lingua impostata in MdExplorer.*
