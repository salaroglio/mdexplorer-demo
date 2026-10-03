---
title: Il registro e la fiducia
---

# Prova 2: il registro e la fiducia

## TL;DR

Il registro è l'elenco degli agenti che abitano il progetto: per ognuno dice chi è, cosa sa fare e quali strumenti
dichiara. Un agente non partecipa a nessuna conversazione finché tu non gli dai **fiducia**. Questa prova ti fa
leggere le schede e darla ai tre agenti del caso di studio.

- Il registro si apre dall'icona delle due persone nella barra degli strumenti.
- Ogni agente nasce «Non fidato»: la fiducia è una tua conferma esplicita, per agente.
- Gli strumenti più rischiosi (scrivere, eseguire comandi) sono evidenziati in rosso.

## Apri il registro

Clicca l'icona delle due persone, «Città degli agenti». Si apre una finestra con l'elenco degli agenti scoperti
nel progetto. Ne trovi quattro:

| Agente | Tipo | Cosa è |
|---|---|---|
| `a2a-ping` | ALGORITMICO | un agente che non usa nessun modello: risponde «pong» a ciò che gli scrivi. Serve a provare che il canale funziona e c'è in ogni progetto |
| `custode-piano` | LLM | presidia il piano del pilota |
| `custode-requisiti` | LLM | presidia i requisiti del pilota |
| `custode-verbali` | LLM | presidia le decisioni del comitato |

«LLM» vuol dire che dietro c'è un modello linguistico, quello del motore AI che hai scelto per il progetto.

## Leggi una scheda

Ogni riga è la **scheda** dell'agente, scritta nel suo file in `.github/agents/`. Per `custode-piano` leggi:

- il **ruolo**: «Custode del piano del pilota»;
- la **skill**: `verifica-piano`, cosa sa fare in una riga;
- i **tool**: `read` e `search`. Sono gli strumenti che l'agente dichiara di usare: leggere e cercare. Se un agente
  dichiarasse `write` o `shell` vedresti la parola **in rosso con un triangolo**, perché sono i due che cambiano
  le cose.

## Dai la fiducia

1. Su `custode-piano` clicca **Concedi trust**.
2. La finestra chiede «Concedi il trust a questo agente?» e dice che l'agente potrà partecipare alle conversazioni
   dentro questo progetto, e quali tool richiede.
3. Se ti torna, clicca **Mi fido**. Se no, **Annulla**.
4. Ripeti per `custode-requisiti` e `custode-verbali`. Lascia fuori `a2a-ping`, non ci serve.

Dopo, la scheda dell'agente dice «Fidato» e il pulsante diventa **Revoca trust**: puoi ritirare la fiducia quando
vuoi.

## Cosa vuol dire «fiducia»

- È **tua**, sul tuo computer: nessuno può fidarsi al posto tuo, e un clone nuovo del progetto riparte da zero.
- È **per agente**: fidarti di uno non ti fa fidare degli altri.
- È **legata alla scheda**: se qualcuno cambia il blocco `a2a:` o i `tool:` di un agente, la fiducia decade e va
  data di nuovo. Lo vedrai nella [prova 5](05-la-fiducia-che-decade.md).

Senza fiducia un agente può essere lanciato a mano, ma **non può essere interpellato dai colleghi**: nella
[prova 4](04-il-dialogo.md) lo scambio parte solo se gli agenti sono fidati.

[Prova 3: il primo agente al lavoro](03-il-primo-agente.md) · [Indice della sezione](../README.md)
