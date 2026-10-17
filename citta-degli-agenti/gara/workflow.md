---
mde_type: workflow
title: Come si passano il lavoro
workflow: gara.workflow.json
---

# Come si passano il lavoro

## TL;DR

Questo documento dice come le persone della gara e i loro agenti si passano il lavoro: chi avvia ogni agente, che cosa
riceve, chi approva e chi decide. Il piano sta in [gara.workflow.json](gara.workflow.json) e le schede degli agenti dicono
che cosa ogni lavoro riceve, legge e consegna: MdExplorer li unisce, li esegue e disegna il diagramma qui sotto.

- Il giro lo comincia l'account manager: lancia la ricerca e preme «Avvia il giro» sul bando; le tre schede le avvia
  ciascun responsabile, con il documento di gara e la ricerca nell'incarico.
- La sintesi parte da sola quando le tre schede sono approvate; poi l'account manager decide se partecipare, con un pulsante.
- Una scheda rifiutata si rifà quando la persona preme «Fai ripartire», senza un limite di volte.

## Il giro

```plantuml(@workflow, ./gara.workflow.json)
```

Ogni riquadro è un turno di lavoro: il nome in grassetto è il passo, sotto c'è l'agente; il riquadro bianco con la
persona è la decisione dell'account manager. Gli omini sono i ruoli di [responsabilita.md](responsabilita.md), con che cosa
fanno: lanciano, avviano, approvano. In verde i documenti che un lavoro legge, in lilla quelli che consegna; un esagono è
un pulsante, un esito o un'attesa. Un clic sul riquadro apre la scheda dell'agente, uno su un file il documento.

Il diagramma non si disegna a mano: se cambiano il piano, una scheda o i ruoli, MdExplorer lo ridisegna.

## Chi decide e chi scrive

| Cosa | Dove sta |
|---|---|
| Chi risponde di quale agente | [responsabilita.md](responsabilita.md) |
| Come si passano il lavoro (questo documento) | [gara.workflow.json](gara.workflow.json) |
| Che cosa ogni lavoro riceve, legge e consegna | la sua scheda, in `.github/agents/` (blocco `a2a:`) |
| Come ogni agente fa il suo lavoro | la sua scheda, il testo sotto il blocco |
| Che cosa è successo in ogni giro | il registro dei giri, sul ramo `mde/giri` del repository |

[Il caso della gara](README.md) · [Indice della sezione](../README.md)
