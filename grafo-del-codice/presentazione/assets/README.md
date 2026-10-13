---
title: Gli asset della presentazione sul grafo del codice
---

# Gli asset della presentazione sul grafo del codice

## TL;DR

Gli sfondi e l'illustrazione della copertina della presentazione [Il codice, spiegato dal codice](../grafo-del-codice.md)
sono file a sé, in questa cartella. Le slide li richiamano per nome: per cambiarne uno basta sostituire il file, senza
toccare le slide. Le schermate dell'app, invece, stanno con le prove, in `../../prove/assets/schermate/`.

- Due sfondi SVG animati, uno scuro per l'apertura e la chiusura e uno chiaro per le altre slide, e l'illustrazione animata della copertina.
- Un ritaglio della pagina del grafo, fatto apposta per la slide «Il grafo, a cascata».
- Le animazioni stanno **dentro** ogni SVG; nessuna immagine contiene testo, quindi valgono per ogni lingua.

## I file

| File | Cosa mostra | Misure | Dove è usato |
|---|---|---|---|
| `grafo-sfondo.svg` | un cielo di notte con una rete di file e simboli in basso e negli angoli; gli archi dedotti scorrono tratteggiati, e piccole luci corrono lungo gli archi come domande | 1280 × 720 | apertura e chiusura |
| `grafo-sfondo-chiaro.svg` | la stessa rete, appena accennata in alto e in basso | 1280 × 720 | tutte le altre slide |
| `codice-in-grafo.svg` | un file sorgente letto riga per riga che diventa un grafo: prima i nodi, poi gli archi colorati per relazione, i dedotti tratteggiati | 660 × 290 | copertina |
| `cascata.png` | ritaglio di `../../prove/assets/schermate/grafo-cascata.png`: `Gestisci` con le sue chiamate e la scheda con la descrizione | 1215 × 640 | «Il grafo, a cascata» |

I colori sono quelli del resto della presentazione: blu per le chiamate, verde per *implementa*, ambra per i riferimenti
ai tipi, viola per l'ereditarietà.

## Come le slide li richiamano

Uno sfondo è un commento sulla prima riga della slide:

```markdown
<!-- .slide: data-background-image="assets/grafo-sfondo-chiaro.svg" -->
```

Un'illustrazione o una schermata è un'immagine dentro la slide:

```markdown
<img src="assets/codice-in-grafo.svg" alt="Un file sorgente che diventa un grafo" width="500">
<img src="../prove/assets/schermate/analisi-con-mark.png" alt="Analisi con Mark completata" width="440">
```

## Come sono nati

Gli SVG li scrive un programma Python, `grafo.py`, che sta in `docs-internal/pitch/asset-generatori/` del repository di
sviluppo di MdExplorer, accanto a quello degli asset della città degli agenti. Serve solo a chi vuole ritoccarli: le
slide usano i file SVG, non il programma. Le schermate sono l'app vera, catturate durante una prova del 13/10/2026
sul programma d'esempio.

[Torna alla sezione](../../README.md)
