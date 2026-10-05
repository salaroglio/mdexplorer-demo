---
title: Avvia il giro e leggi le schede
---

# Prova 4: avvia il giro e leggi le schede

> **La posta è cambiata.** Dove questa pagina dice «Posta in arrivo» e «Lavoro degli agenti», oggi il fumetto apre un elenco solo, a
> tutto schermo, e un documento si legge con **Apri** senza passare da «Ci metto mano». Vedi
> [La posta degli agenti](../guida/la-posta-degli-agenti.md). Le schermate qui sotto sono ancora quelle di prima.

## TL;DR

Rispondi all'account manager «avvia» e lui incarica i tre responsabili. Ognuno legge lo stesso capitolato con i **suoi**
occhi e scrive una scheda: ti arrivano **tre richieste da rivedere**, una per scheda. Prima di approvarle le leggi: è il
momento in cui tu verifichi, e le schede sono fatte per aiutarti a farlo.

- Si risponde dalla posta in arrivo, nella stessa conversazione: «Rispondi» sveglia l'agente.
- Le tre schede arrivano in circa 4-5 minuti, in «Lavoro degli agenti».
- Per leggerle prima di approvare: **Ci metto mano**, poi la scheda **Differenze**.

## Dì «avvia»

1. Nel fumetto, nella **Posta in arrivo**, trova il messaggio di `account-manager` della prova 3.
2. Nella casella **La tua risposta** scrivi:

   > avvia NC-2027-014

3. Clicca **Rispondi**.

L'agente si risveglia nella stessa conversazione e ti scrive «Giro avviato su NC-2027-014: incarichi inviati ai tre
responsabili». Dietro le quinte ha mandato un messaggio a ciascuno: sono i messaggi che cominciano con `[INCARICO]`.

## Aspetta le schede

Ognuno dei tre responsabili lavora per conto suo e ti scrive un messaggio `[ESITO]` di tre righe, per esempio:

```text
[ESITO]
3 coperti / 7 parziali / 1 non coperto / 3 da chiarire; rischi alti: 4.
Rischio più grave: RPO 30 minuti contro il massimo richiesto di 15 (§6.6, NFR-DR-001).
Punto che convince meno: data lakehouse senza qualifica ACN, attesa nel Q4 2027 (§3.3).
```

Ci vogliono circa **4-5 minuti**. Intanto, nella scheda **Lavoro degli agenti** del fumetto, compaiono tre richieste, una
per agente, ognuna col suo file (`tecnica.md`, `contrattuale.md`, `delivery.md`) e con un riassunto di chi è l'agente.

## Leggi una scheda prima di approvarla

Prendi la richiesta di `responsabile-delivery`: è quella con il calcolo più facile da controllare.

1. Clicca **Ci metto mano**. L'agente va in coda e non tocca la sua cartella finché non chiudi.
2. Apri la scheda **Differenze** (accanto a «Documenti progetto», nel pannello di sinistra) e clicca il file
   `citta-degli-agenti/gara/schede/delivery.md`: lo leggi per intero come righe aggiunte, con il segno `+`. Il testo è
   markdown "grezzo" (le tabelle compaiono con i trattini): per leggerlo meglio puoi anche aprire la cartella che
   l'app ha aperto con «Ci metto mano».
3. Nella scheda **Lavoro degli agenti** premi **Ho finito**: la richiesta torna come prima, pronta da approvare.

Cosa guardare, in ordine:

- **«Da verificare da te»**, in fondo. L'agente ti dice dove è meno sicuro: controlla lì per primo.
- **Ogni affermazione cita la sezione del capitolato** (per esempio «§7.4.7»). Aprila nel [capitolato](../gara/capitolato.md)
  e controlla che dica quello che la scheda dice.
- **Il calcolo delle date.** La scheda delivery scrive il calcolo accanto al risultato: «9 mesi dalla firma» contro
  «attivazione entro il 01/01/2028». Rifallo a mano.

## Cosa è successo

- I tre agenti hanno letto **lo stesso capitolato** ma ognuno ha letto **il suo capitolo del profilo di Pentagroup**: il
  tecnico quello tecnico, il legale quello dei contratti, il delivery quello delle persone. Per questo le tre schede
  dicono cose diverse.
- Hanno lavorato ciascuno nella **sua copia** del progetto, in parallelo, e consegnato un file diverso: per questo le
  richieste sono tre e non una.
- Nessuna scheda è nel progetto: sono rami da approvare. Il lavoro è tuo finché non lo approvi.

## E se non succede niente

- **Dopo cinque minuti le richieste sono meno di tre.** Aspetta ancora: i posti di lavoro sono due, quindi il terzo
  agente parte quando uno dei primi due finisce. Poi premi **Aggiorna** nella scheda «Lavoro degli agenti».
- **Un responsabile dice di non trovare i documenti.** Non inventa la scheda: te lo scrive. Controlla di aver aperto
  la cartella giusta.
- **Il numero degli indicatori è diverso dal mio.** Normale: un modello non dà due volte le stesse parole. Cambiano le
  parole e qualche conteggio; i divari veri (RPO, qualifica ACN, date) no.

[Prova 5: approva e passa il lavoro](05-approva-e-passa-il-lavoro.md) · [Prova 3](03-l-account-manager-cerca-il-bando.md) · [Indice della sezione](../README.md)
