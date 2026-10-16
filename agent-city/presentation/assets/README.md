---
title: The assets of the agent city presentation
---

# The assets of the agent city presentation

## TL;DR

The characters, backgrounds and screenshots of the presentation are separate files, in this folder. The slides refer to them by name: to
change an illustration or a screenshot you just replace the file, without touching the slides. Here is the list, with the sizes
to keep.

- Four animated SVG characters (one per agent) and two backgrounds.
- Nine real screenshots of the app, captured during a trial of the case, in `schermate/`.
- The animations live **inside** each SVG; the screenshots are still images.

## The characters

| File | Who it is | Colour | Size |
|---|---|---|---|
| `agente-account.svg` | the account manager's assistant | amber | 180 × 290 |
| `agente-tecnico.svg` | the technical lead's assistant | blue | 180 × 290 |
| `agente-legale.svg` | the legal lead's assistant | purple | 180 × 290 |
| `agente-delivery.svg` | the delivery lead's assistant | green | 180 × 290 |

They float, wink, and the light on the antenna blinks. The same colour ties together person, agent and sheet throughout the
presentation.

![The account manager's assistant](agente-account.svg)
![The technical lead's assistant](agente-tecnico.svg)
![The legal lead's assistant](agente-legale.svg)
![The delivery lead's assistant](agente-delivery.svg)

## The backgrounds

| File | What it shows | Size | Where it is used |
|---|---|---|---|
| `citta-sfondo.svg` | the city at night, with windows lighting up and envelopes crossing the sky | 1280 × 720 | opening and closing |
| `citta-sfondo-chiaro.svg` | the skyline, barely sketched | 1280 × 720 | all the other slides |

## The screenshots

They are the real app, during the tender round. **The model's words change at every trial**: if you redo one, the texts
will be different, but the path is the same.

| File | What it shows | Slide |
|---|---|---|
| `schermate/fiducia.png` | the window that opens before you enable an agent | «First you enable them» |
| `schermate/registro.png` | the list of agents with their summaries | (available, not used) |
| `schermate/scoperta.png` | the account manager's message with the new calls for tenders | «Step 1» |
| `schermate/risposta.png` | the «Start the round» button under the message | «Step 2» |
| `schermate/posta-risposta.png` | the message with the reply button open (mailbox from before the sections) | (no longer used) |
| `schermate/posta-risposta-chiusa.png` | the same button closed, before the approval | trial 3 |
| `schermate/posta-stati.png` | the state lines under the message (mailbox from before the sections) | (no longer used) |
| `schermate/posta-giro-righe.png`, `posta-da-avviare.png`, `posta-giro-lavorano.png`, `posta-approva-scheda.png`, `posta-giro-approvata.png`, `posta-giro-sintesi.png`, `posta-giro-concluso.png`, `posta-archivio.png` | the mailbox in three sections (To do, Rounds, Messages) through the tender, from the button to the archive (07/10) | trials 4-6; mailbox guide |
| `schermate/guida-*.png` | crops of the same screenshots | step-by-step guide, parts 2 and 3 |
| `schermate/slide-*.png` | crops of the same screenshots | presentation «One assistant for every person» |
| `schermate/posta-rifiuto.png` | the rejection with its reason | (spare) |
| `schermate/posta-fermo.png` | a rejected, stopped piece of work, with «Restart» | trial 4; mailbox guide |
| `schermate/copia-dentro.png` | the window working in an agent copy | guide «Working in an agent copy» |
| `schermate/prima-di-avviare.png` | the «there is unsaved work» window before starting an agent | trial 3 |
| `schermate/copia-uscita.png` | the exit window with «Commit and publish» | guide «Working in an agent copy» |
| `schermate/scoperta.png`, `esiti.png`, `revisione.png`, `mancano.png` | crops of the mailbox screenshots | short presentation |
| `schermate/esiti.png` | the technical and legal messages | «The same specification» |
| `schermate/revisione.png` | two requests to review, with the choice of recipient | «Three requests to review reach you» |
| `schermate/avviso.png` | «Work merged into the main branch. account-manager has been notified.» | «Approving is passing the work on» |
| `schermate/mancano.png` | the account manager says what is missing | «Approving is passing the work on» |
| `schermate/sintesi-richiesta.png` | the fourth request, with the synthesis and the register | (available, not used) |

In the trust window **a single line** is covered with a white rectangle: the path of the folder on the computer where it
was captured. If you redo a screenshot, cover the path or open the project from a folder with a neutral name.

## How the slides refer to them

A character or a screenshot is an image inside the slide:

```markdown
<img src="assets/agente-tecnico.svg" alt="The technical lead's assistant" width="130">
<img src="assets/schermate/fiducia.png" alt="The enabling window" height="560">
```

A background is a comment on the first line of the slide:

```markdown
<!-- .slide: data-background-color="#0a1322" data-background-image="assets/citta-sfondo.svg" -->
```

## How they were made

The characters and backgrounds are written by a Python program, `citta.py`, which lives in `docs-internal/pitch/asset-generatori/` of
the MdExplorer development repository. It is only for people who want to retouch them: the slides use the SVG files, not the program. The
screenshots are captured from the app with the browser zoom on a region.

[Back to the section](../../README.md)
