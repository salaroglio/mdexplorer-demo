---
mde_type: workflow
title: Come si passano il lavoro
workflow: gara.workflow.json
---

# Come si passano il lavoro

## TL;DR

Questo documento dice come le persone della gara e i loro agenti si passano il lavoro: chi incarica chi, chi avvia ogni
agente, chi aspetta chi. Il piano sta in [gara.workflow.json](gara.workflow.json): MdExplorer lo legge e lo esegue, e il
diagramma qui sotto lo disegna da lì, quindi non va mai aggiornato a mano.

- Il giro lo comincia l'account manager: lancia la ricerca e preme «Avvia il giro» sul bando; le tre schede le avvia
  ciascun responsabile (se un agente ha un team, chi preme il pulsante sceglie chi la fa).
- La sintesi parte da sola quando tutte e tre le schede sono approvate, sul computer dell'account manager.
- Una scheda rifiutata si rifà quando la persona preme «Fai ripartire», senza un limite di volte.

## Il giro

```plantuml(@workflow, ./gara.workflow.json)
```

Ogni riquadro è un turno di lavoro di un agente: il nome in grassetto è il passo, sotto c'è l'agente. Un clic sul riquadro
apre la scheda dell'agente, un clic su un file apre l'artefatto.

## Chi decide e chi scrive

| Cosa | Dove sta |
|---|---|
| Chi risponde di quale agente | [responsabilita.md](responsabilita.md) |
| Come si passano il lavoro (questo documento) | [gara.workflow.json](gara.workflow.json) |
| Come ogni agente fa il suo lavoro | la sua scheda, in `.github/agents/` |
| Che cosa è successo in ogni giro | il registro dei giri, sul ramo `mde/giri` del repository |

[Il caso della gara](README.md) · [Indice della sezione](../README.md)
