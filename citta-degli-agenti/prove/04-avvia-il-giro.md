---
title: Avvia il giro e leggi le schede
---

# Prova 4: avvia il giro e leggi le schede

## TL;DR

Approvata la ricerca, premi il pulsante «Avvia il giro» sotto il messaggio dell'account manager: lui incarica i tre
responsabili. Ognuno legge lo stesso capitolato con i **suoi** occhi e scrive una scheda. Tu segui a che punto sono dalla
posta, e prima di approvarle le leggi: è il momento in cui verifichi.

- La risposta è un pulsante, e dice chi viene incaricato e per fare cosa.
- Sotto «Giro avviato» c'è una riga per ogni scheda attesa, che cambia stato da sola.
- Le tre schede arrivano in circa 4-5 minuti; una scheda si legge con **Apri**, prima di approvarla.

## Premi «Avvia il giro»

1. Clicca il fumetto e, nell'elenco, il messaggio di `account-manager` della prova 3.
2. Sotto il testo c'è **Che cosa puoi rispondere a account-manager**, con il pulsante **Avvia il giro su NC-2027-014** e la
   sua descrizione: incarica il responsabile tecnico, il legale e il delivery di scrivere ciascuno la propria scheda.
3. Premilo.

![Il pulsante Avvia il giro sotto il messaggio, con la sua descrizione](../presentazione/assets/schermate/posta-risposta.png)

Se il pulsante è chiuso e c'è scritto «Prima decidi sull'artefatto», non hai ancora approvato la ricerca: è il passo
finale della prova 3.

Dopo mezzo minuto arriva un messaggio nuovo: «Giro avviato su NC-2027-014: incarichi inviati ai tre responsabili».

## Segui le schede

Clicca il messaggio «Giro avviato». Nell'elenco, **sotto** di lui, ci sono tre righe rientrate, una per scheda attesa:

| Riga | Che cosa vuol dire | Sfondo |
|---|---|---|
| sta lavorando | l'agente del responsabile sta scrivendo la scheda | azzurro |
| in approvazione | la scheda c'è: aspetta la decisione del suo responsabile | ambra |
| approvato | la scheda è nel progetto | verde |
| rifiutato, fermo | il responsabile l'ha rifiutata: non riparte da sola | rosso |

![Sotto «Giro avviato», una riga per ogni scheda attesa con il suo stato](../presentazione/assets/schermate/posta-stati.png)

Le righe cambiano da sole, e quando una cambia lampeggia per qualche secondo. È quello che vede **chi aspetta**: qui
l'account manager, che ha incaricato i tre responsabili. Nel demo le quattro persone sei tu; in azienda queste righe
dicono all'account manager a che punto è ciascun collega, senza chiederglielo.

Ci vogliono circa **4-5 minuti**: i posti di lavoro sono due, quindi il terzo agente parte quando uno dei primi due finisce.
Ogni responsabile ti scrive un messaggio `[ESITO]` di tre righe, per esempio:

```text
[ESITO]
3 coperti / 7 parziali / 1 non coperto / 3 da chiarire; rischi alti: 4.
Rischio più grave: RPO 30 minuti contro il massimo richiesto di 15 (§6.6, NFR-DR-001).
Punto che convince meno: data lakehouse senza qualifica ACN, attesa nel Q4 2027 (§3.3).
```

Sotto ognuno di questi messaggi c'è la sua riga «Da approvare: l'artefatto».

## Leggi una scheda prima di approvarla

Prendi il messaggio di `responsabile-delivery`: è quello con il calcolo più facile da controllare.

1. Clicca la riga «Da approvare: l'artefatto» sotto il suo messaggio.
2. Sul file `citta-degli-agenti/gara/schede/delivery.md` clicca **Apri**: lo leggi impaginato, com'è nella consegna dell'agente.
3. **Torna** riporta alla richiesta. Non approvare ancora: lo fai nella prova 5.

Cosa guardare, in ordine:

- **«Da verificare da te»**, in fondo. L'agente ti dice dove è meno sicuro: controlla lì per primo.
- **Ogni affermazione cita la sezione del capitolato** (per esempio «§7.4.7»). Aprila nel [capitolato](../gara/capitolato.md)
  e controlla che dica quello che la scheda dice.
- **Il calcolo delle date.** La scheda delivery scrive il calcolo accanto al risultato: «9 mesi dalla firma» contro
  «attivazione entro il 01/01/2028». Rifallo a mano.

## Se una scheda non ti convince

La strada normale è **correggerla tu**: dal selettore del ramo scegli «Worktree» e l'agente, e lavori nella sua copia come dopo
un cambio di ramo. Sistemi la scheda, torni al tuo lavoro (l'app ti chiede di committare e pubblicare) e poi la approvi.
È spiegato in [Lavorare nella copia di un agente](../guida/lavorare-nella-copia-di-un-agente.md).

**Rifiuta** è l'eccezione, per quando la scheda è così sbagliata che conviene rifarla. Ti chiede il motivo, e poi **ferma**:

- la scheda resta nella posta come «Rifiutato: il lavoro è fermo», e nella riga di stato di chi aspetta diventa rossa;
- **niente riparte da solo**: se l'errore viene dalla scheda dell'agente (il file `.agent.md`), hai il tempo di correggerla;
- quando sei pronto premi **Fai ripartire**: l'agente riceve lo stesso incarico, più il tuo motivo.

![Un lavoro rifiutato e fermo, con il motivo e il pulsante Fai ripartire](../presentazione/assets/schermate/posta-fermo.png)

## Cosa è successo

- I tre agenti hanno letto **lo stesso capitolato** ma ognuno ha letto **il suo capitolo del profilo di Pentagroup**: il
  tecnico quello tecnico, il legale quello dei contratti, il delivery quello delle persone. Per questo le tre schede
  dicono cose diverse.
- Hanno lavorato ciascuno nella **sua copia** del progetto, in parallelo, e consegnato un file diverso: per questo le
  richieste sono tre e non una.
- Nessuna scheda è nel progetto: sono rami da approvare. Il lavoro è tuo finché non lo approvi.

## E se non succede niente

- **Dopo cinque minuti una riga dice ancora «sta lavorando».** Aspetta: i posti di lavoro sono due, quindi il terzo
  agente parte quando uno dei primi due finisce. Il robot nella barra in alto gira finché qualcuno lavora.
- **Un responsabile dice di non trovare i documenti.** Non inventa la scheda: te lo scrive. Controlla di aver aperto
  la cartella giusta.
- **Il numero degli indicatori è diverso dal mio.** Normale: un modello non dà due volte le stesse parole. Cambiano le
  parole e qualche conteggio; i divari veri (RPO, qualifica ACN, date) no.

[Prova 5: approva e passa il lavoro](05-approva-e-passa-il-lavoro.md) · [Prova 3](03-l-account-manager-cerca-il-bando.md) · [Indice della sezione](../README.md)
