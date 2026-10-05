---
title: Gli asset della presentazione sulla città degli agenti
---

# Gli asset della presentazione sulla città degli agenti

## TL;DR

Personaggi, sfondi e schermate della presentazione sono file a sé, in questa cartella. Le slide li richiamano per nome: per
cambiare un'illustrazione o una schermata basta sostituire il file, senza toccare le slide. Qui c'è l'elenco, con le misure
da rispettare.

- Quattro personaggi SVG animati (uno per agente) e due sfondi.
- Nove schermate vere dell'app, catturate durante una prova del caso, in `schermate/`.
- Le animazioni stanno **dentro** ogni SVG; le schermate sono immagini ferme.

## I personaggi

| File | Chi è | Colore | Misure |
|---|---|---|---|
| `agente-account.svg` | l'assistente dell'account manager | ambra | 180 × 290 |
| `agente-tecnico.svg` | l'assistente del responsabile tecnico | blu | 180 × 290 |
| `agente-legale.svg` | l'assistente del responsabile legale | viola | 180 × 290 |
| `agente-delivery.svg` | l'assistente del responsabile delivery | verde | 180 × 290 |

Fluttuano, ammiccano e la lucina dell'antenna lampeggia. Lo stesso colore tiene insieme persona, agente e scheda in tutta la
presentazione.

![L'assistente dell'account manager](agente-account.svg)
![L'assistente del tecnico](agente-tecnico.svg)
![L'assistente del legale](agente-legale.svg)
![L'assistente del delivery](agente-delivery.svg)

## Gli sfondi

| File | Cosa mostra | Misure | Dove è usato |
|---|---|---|---|
| `citta-sfondo.svg` | la città di notte, con le finestre che si accendono e le buste che attraversano il cielo | 1280 × 720 | apertura e chiusura |
| `citta-sfondo-chiaro.svg` | la skyline appena accennata | 1280 × 720 | tutte le altre slide |

## Le schermate

Sono l'app vera, durante il giro della gara. **Le parole del modello cambiano a ogni prova**: se ne rifai una, i testi
saranno diversi, ma il percorso è lo stesso.

| File | Cosa mostra | Slide |
|---|---|---|
| `schermate/fiducia.png` | la finestra che si apre prima di abilitare un agente | «Prima li abiliti tu» |
| `schermate/registro.png` | l'elenco degli agenti con i loro riassunti | (disponibile, non usata) |
| `schermate/scoperta.png` | il messaggio dell'account manager con i bandi nuovi | «Passo 1» |
| `schermate/risposta.png` | il pulsante «Avvia il giro» sotto il messaggio | «Passo 2» |
| `schermate/posta-risposta.png` | il messaggio con il pulsante di risposta aperto | guida passo per passo, gesto 4; prova 4 |
| `schermate/posta-risposta-chiusa.png` | lo stesso pulsante chiuso, prima dell'approvazione | prova 3 |
| `schermate/posta-stati.png` | le righe di stato dei lavori attesi | guida passo per passo; prova 4 |
| `schermate/posta-rifiuto.png` | il rifiuto con il motivo | (di scorta) |
| `schermate/posta-fermo.png` | un lavoro rifiutato e fermo, con «Fai ripartire» | prova 4; guida della posta |
| `schermate/copia-dentro.png` | la finestra che lavora nella copia di un agente | guida «Lavorare nella copia di un agente» |
| `schermate/copia-uscita.png` | la finestra di uscita con «Committa e pubblica» | guida «Lavorare nella copia di un agente» |
| `schermate/scoperta.png`, `esiti.png`, `revisione.png`, `mancano.png` | ritagli delle schermate della posta | presentazione corta |
| `schermate/esiti.png` | i messaggi del tecnico e del legale | «Lo stesso capitolato» |
| `schermate/revisione.png` | due richieste da rivedere, con la scelta del destinatario | «Ti arrivano tre richieste» |
| `schermate/avviso.png` | «Lavoro fuso nel ramo principale. Ho avvisato account-manager.» | «Approvare è passare il lavoro» |
| `schermate/mancano.png` | l'account manager dice cosa manca | «Approvare è passare il lavoro» |
| `schermate/sintesi-richiesta.png` | la quarta richiesta, con la sintesi e il registro | (disponibile, non usata) |

Nella finestra della fiducia è coperta con un rettangolo bianco **una sola riga**: il percorso della cartella del computer in
cui è stata catturata. Se rifai una schermata, copri il percorso o aprila da una cartella con un nome neutro.

## Come le slide li richiamano

Un personaggio o una schermata è un'immagine dentro la slide:

```markdown
<img src="assets/agente-tecnico.svg" alt="L'assistente del responsabile tecnico" width="130">
<img src="assets/schermate/fiducia.png" alt="La finestra di abilitazione" height="560">
```

Uno sfondo è un commento sulla prima riga della slide:

```markdown
<!-- .slide: data-background-color="#0a1322" data-background-image="assets/citta-sfondo.svg" -->
```

## Come sono nati

I personaggi e gli sfondi li scrive un programma Python, `citta.py`, che sta in `docs-internal/pitch/asset-generatori/` del
repository di sviluppo di MdExplorer. Serve solo a chi vuole ritoccarli: le slide usano i file SVG, non il programma. Le
schermate si catturano dall'app con lo zoom del browser su una regione.

[Torna alla sezione](../../README.md)
