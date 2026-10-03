---
title: La fiducia che decade
---

# Prova 5: la fiducia che decade

## TL;DR

La fiducia che dai a un agente vale per la scheda che hai letto, non per l'agente in astratto. Se qualcuno cambia
gli strumenti che l'agente dichiara o chi può scrivergli, la fiducia **decade** e devi riconfermarla. Questa prova
te lo fa vedere cambiando una riga.

- Cambi `tools:` nella scheda di `custode-piano` e lui torna «Non fidato».
- Lo stesso succede se cambi il blocco `a2a:`, per esempio chi può scrivergli.
- Il corpo della scheda, cioè le istruzioni, si può cambiare senza perdere la fiducia.

## Perché esiste

Una scheda è un file nel repository, e il repository lo modificano più persone. Senza questa regola, chi vuole
dare a un agente un permesso in più potrebbe scrivere `shell` nella scheda e contare sul fatto che tu ti sei già
fidato. Così invece il permesso nuovo passa da te.

## Provala

1. Apri `.github/agents/custode-piano.agent.md` con un editor di testo. In cima, tra i due `---`, trovi la scheda.
2. Cambia questa riga:

   ```yaml
   tools: [read, search]
   ```

   in questa:

   ```yaml
   tools: [read, search, shell]
   ```

3. Salva il file.
4. Torna in MdExplorer, apri il registro (l'icona delle due persone) e clicca **Aggiorna**.

## Cosa vedi

- `custode-piano` è tornato **«Non fidato»**.
- Tra i suoi tool compare `shell`, in rosso con un triangolo.
- Gli altri due agenti restano fidati: la decadenza riguarda solo la scheda cambiata.

Se clicchi **Concedi trust**, la finestra elenca i tool richiesti, compreso `shell`: stai dando un permesso in più
e lo fai con gli occhi aperti.

## Rimetti tutto a posto

Riporta la riga com'era (`tools: [read, search]`), salva e clicca **Aggiorna**. L'agente resta «Non fidato»: la
fiducia decaduta non torna da sola. Clicca **Concedi trust** per darla di nuovo.

## Un secondo cambio: chi può scrivergli

Il blocco `a2a:` ha una riga `accepts_messages_from`, l'elenco di chi può scrivere a quell'agente. Aggiungi o
togli un nome da quell'elenco e il risultato è lo stesso: scheda cambiata, fiducia decaduta.

## Cosa non fa decadere la fiducia

Il testo sotto la scheda, cioè le istruzioni che l'agente segue, si può modificare senza perdere la fiducia. È una
scelta: le istruzioni cambiano spesso e non danno permessi nuovi. Per questo ciò che può fare un agente sta nella
scheda e non nel testo.

## E gli strumenti dichiarati sono davvero un limite?

Sì, con GitHub Copilot e nelle versioni di MdExplorer successive al 3 ottobre 2026: ciò che l'agente non
dichiara (eseguire comandi, scrivere file) il motore lo **rifiuta** («Permission to run this tool was denied»,
dice l'agente stesso se ci prova). Prima di quella data i `tool:` erano un'intenzione scritta, non un
divieto: se hai una versione più vecchia, aggiornala prima di fidarti di questa riga.

[Prova 6: il lavoro che passa dalla tua approvazione](06-lavoro-e-revisione.md) · [Indice della sezione](../README.md)
