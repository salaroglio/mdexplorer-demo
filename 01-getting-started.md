---
title: Primi passi in MdExplorer
order: 1
---

# 🧭 Primi passi

Mark ti ha appena aperto questo progetto. Ottimo, vuol dire che il **clone è andato a buon fine** e MdExplorer ha indicizzato i file `.md` automaticamente.

## L'albero a sinistra

Sulla colonna di sinistra vedi l'**albero del progetto**. Ogni file `.md` è un nodo cliccabile. Le cartelle si espandono, e MdExplorer ricorda quali avevi aperto la volta scorsa.

## Navigare tra file

Quando un file `.md` linka un altro `.md` con sintassi standard:

```markdown
[Vai alle basi del markdown](02-markdown-basics.md)
```

…MdExplorer non apre il browser, **naviga internamente** mantenendo il context. Provalo qui:

➡️ [Vai alle basi del markdown](02-markdown-basics.md)
➡️ [Apri lo schema di architettura](docs/architecture.md)

## Tornare indietro

In alto, nella title-bar, ci sono le frecce ⬅️ ➡️ per **back/forward** — esattamente come in un browser. Mark ricorda l'ordine in cui hai aperto i file.

## E se voglio modificare?

Cliccando su un file con il **double-click** apri l'editor inline. Ogni modifica salva automaticamente, e MdExplorer notifica tutti gli altri tab aperti dello stesso file via SignalR.

---

**Prossimo passo**: [Sintassi markdown + esempi runnable](02-markdown-basics.md)
