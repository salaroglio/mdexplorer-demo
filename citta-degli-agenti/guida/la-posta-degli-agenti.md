---
title: La posta degli agenti
---

# La posta degli agenti

## TL;DR

Il fumetto nella barra degli strumenti apre la posta degli agenti: una pagina a tutto schermo, sopra il progetto. A sinistra
l'elenco, diviso per **che cosa vuole da te** ogni voce; a destra il dettaglio di ciò che scegli. Il numero sul fumetto conta
solo le decisioni che ti aspettano, non i messaggi da leggere.

- **Da fare**: ciò che aspetta una tua decisione (da avviare, da approvare, pulsanti a cui non hai risposto).
- **Giri**: un giro del workflow è una voce sola, con i suoi passi e i suoi messaggi; **Messaggi**: il resto, da leggere.
- Un giro concluso si archivia in un gesto, con tutti i suoi messaggi; «Archivia i letti» toglie i messaggi già letti.

## Le tre sezioni

![La posta dopo «Avvia il giro»: in Da fare le tre schede da avviare, in Giri il giro con i suoi passi](../presentazione/assets/schermate/posta-giro-righe.png)

| Sezione | Che cosa c'è | Perché lì |
|---|---|---|
| **Da fare** (ambra) | «da avviare», «da approvare» (anche un lavoro fermo dopo un rifiuto), le richieste dei colleghi, e i messaggi con pulsanti a cui non hai ancora risposto | aspettano una tua decisione: finché non decidi, il lavoro di qualcuno è fermo |
| **Giri** (azzurro) | una voce per giro del workflow, per esempio «Gara · NC-2027-014 · 3 su 5 passi»; quelli in corso prima, con le righe dei passi sotto | il giro va avanti da solo: lo segui, non lo devi spingere |
| **Messaggi** | ciò che gli agenti ti hanno scritto fuori da un giro | da leggere |

Un messaggio scritto durante un giro sta **dentro il giro**, non in «Messaggi». Fa eccezione finché aspetta una tua
decisione (per esempio il suo artefatto è da approvare): allora resta in «Da fare», e quando hai deciso entra nel giro.

## Le voci dell'elenco

| Icona | Che cos'è | Cosa fai a destra |
|---|---|---|
| il robot | un messaggio di un agente | lo leggi, apri gli artefatti, rispondi con i suoi pulsanti |
| la lista con la spunta, in arancione, rientrata sotto un messaggio | l'artefatto di quel lavoro, **da approvare** | apri i file, poi **Autorizza**, **Ci metto mano** o **Rifiuta** |
| il fermaglio con l'orologio, «Da avviare» | un passo di un giro che è **tuo**: l'incarico che il workflow ha scritto per il tuo agente | **Apri per avviare**, **Non lo avvio** (con il motivo), o **Passa a un collega** del team |
| lo schema ad albero, in «Giri» | un **giro** del workflow: titolo, bando, passi conclusi su totale | a destra i passi con chi ne risponde e lo stato, e i messaggi del giro (un clic li apre); a giro concluso, **Archivia il giro** |
| una riga colorata, rientrata sotto un giro | un **passo** del giro, con chi ne risponde | niente: la riga cambia stato da sola; «senza messaggio» se l'agente ha consegnato senza scriverti |
| il nodo, in viola | la **richiesta di un collega**: il suo agente chiede il lavoro del tuo | **Autorizza** o **Rifiuta**: il tuo agente parte solo se accetti |

Aprire un messaggio lo segna come letto: sparisce il pallino, ma il messaggio resta nell'elenco finché ti serve.

## Un lavoro, una riga

Un agente che lavora lascia due cose: il messaggio che ti scrive e la richiesta di approvazione del suo artefatto. Nell'elenco
non sono due voci slegate: la richiesta sta **sotto** il messaggio dello stesso lavoro, rientrata, con scritto «Da approvare:
l'artefatto». Il legame è l'identificativo del turno di lavoro, non l'ora.

## Rispondere a un agente

Sotto un messaggio trovi **che cosa puoi rispondere**: un pulsante per ogni risposta che l'agente accetta, con scritto che cosa
succede premendolo (chi viene contattato, e per ottenere cosa). Se il progetto ha un workflow e il pulsante fa partire dei
passi (per esempio «Avvia il giro»), premendolo non svegli l'agente: apri un giro, e i passi arrivano «da avviare» a chi ne
risponde. Se uno di quegli agenti ha più responsabili, sotto il pulsante scegli chi lo fa. Le risposte le dichiara la scheda dell'agente, nel blocco coperto
dalla fiducia: un pulsante può inviare solo ciò che hai già visto dando fiducia all'agente.

![Il pulsante di risposta, e sotto il messaggio le righe del giro che ha avviato](../presentazione/assets/schermate/posta-giro-righe.png)

- **Finché l'artefatto di quel lavoro non è approvato, i pulsanti sono chiusi.** Prima decidi su ciò che l'agente ha prodotto,
  poi gli dici di andare avanti.
- Un agente che non ti chiede niente non ha pulsanti.
- Sotto i pulsanti c'è sempre una **casella per scrivere con parole tue**: per chiedere «perché non vedo i pulsanti?», o per
  dire all'agente una cosa che la sua scheda non prevede. L'agente si sveglia senza ricordi, quindi riceve ciò che scrivi
  insieme al suo messaggio di prima, citato, e ai pulsanti che ti aveva proposto. Anche la casella resta chiusa finché
  l'artefatto non è approvato.
- Un agente che dichiara delle risposte deve dire ogni volta quali valgono, anche «nessuna». Se se ne dimentica, MdExplorer
  rifiuta il messaggio e l'agente lo rimanda corretto: non ti arriva un messaggio senza pulsanti per sbaglio.

## Rifiutare

Il rifiuto è l'eccezione: di solito un artefatto che non convince si corregge nella copia dell'agente e poi si approva.
**Rifiuta** chiede sempre il motivo, e poi ferma tutto: niente riparte da solo.

| Il lavoro l'aveva chiesto | Dopo il rifiuto |
|---|---|
| un altro agente, che lo aspetta | resta nella posta come «Rifiutato: il lavoro è fermo». Quando vuoi premi **Fai ripartire**: l'agente riceve lo stesso incarico e il tuo motivo. Prima, se serve, correggi la sua scheda |
| tu | è un ramo chiuso: i pulsanti di risposta restano bloccati. Per riprovare rilanci l'agente |

![Un lavoro rifiutato e fermo, con Fai ripartire](../presentazione/assets/schermate/posta-fermo.png)

## Seguire un giro

![Un giro selezionato: i passi con chi ne risponde e lo stato, e i messaggi del giro](../presentazione/assets/schermate/posta-giro-approvata.png)

Seleziona il giro nella sezione «Giri»: a destra trovi **i passi**, ciascuno con chi ne risponde e lo stato, e **i messaggi del
giro**, cioè quelli che gli agenti ti hanno scritto lungo il giro. Un clic su un messaggio lo apre; in alto c'è il ritorno al giro.
Le righe cambiano da sole, e quando una cambia lampeggia per qualche secondo.

| Stato | Sfondo |
|---|---|
| aspetta che il responsabile lo avvii, in approvazione | ambra |
| sta lavorando, in rilavorazione | azzurro |
| approvato, concluso | verde |
| rifiutato e fermo, non riuscito, non avviato | rosso |
| aspetta i passi prima di lui | grigio |

Se una riga dice **«senza messaggio»**, l'agente ha consegnato il lavoro ma non ti ha scritto il messaggio che la sua scheda
chiede: guarda direttamente il file.

## Archiviare

- **Archivia**, nel dettaglio di un messaggio, lo toglie dall'elenco.
- **Archivia i letti (N)**, nella barra in alto, toglie in un gesto i messaggi già letti della sezione «Messaggi». Quelli da
  leggere, le decisioni e i giri restano.
- **Archivia il giro**, nel dettaglio di un giro concluso, lo toglie dalla posta con tutti i suoi messaggi. Un giro ancora in
  corso non si archivia: ha passi che aspettano qualcuno.

Niente si cancella: **Archivio**, nella barra in alto, mostra messaggi e giri archiviati, e da lì **Riporta in posta** li
rimette nell'elenco. Archiviare un giro riguarda solo la tua posta: il registro del giro, in git, non cambia.

![L'archivio: il giro concluso con i suoi messaggi e «Riporta in posta»](../presentazione/assets/schermate/posta-archivio.png)

## Gli artefatti di un messaggio

Un agente produce sempre due cose: il documento e il messaggio che ti dice dov'è. Sotto il testo del messaggio, la sezione
**Artefatti** elenca i documenti che il messaggio cita, ciascuno con il suo stato.

| Stato | Che cosa vuol dire | Che cosa puoi fare |
|---|---|---|
| Nella copia dell'agente, in attesa della tua approvazione | l'agente l'ha scritto, ma nel progetto non c'è ancora | **Apri** per leggerlo, **Vai alla richiesta** per decidere |
| Approvato: è nel repository, non ancora nella tua cartella | l'hai autorizzato | lo porti nella cartella con «… da pullare» → **Scarica tutto** |
| Nel progetto | è nella tua cartella | **Apri** |
| Non trovato | il messaggio cita un file che non esiste da nessuna parte | chiedi all'agente, o controlla il percorso |

**Apri** mostra il documento nella parte destra della pagina, impaginato, con in alto da dove viene. **Torna** riporta al messaggio.

## Approvare senza uscire dalla posta

1. Scegli nell'elenco una voce **Da approvare**.
2. Su ogni file c'è **Apri**: leggi il documento com'è nella consegna dell'agente.
3. **Autorizza**: il documento entra nel repository e la voce sparisce dall'elenco. Se il lavoro è un passo di un giro,
   l'approvazione va anche nel registro del giro, e il workflow fa partire chi viene dopo.

Senza workflow, se l'agente dichiara a chi passa il lavoro, prima di autorizzare scegli il collega da avvisare (o «nessuno»).

Per leggere un documento non serve più «Ci metto mano»: quello resta il gesto per **correggerlo** tu prima di approvare.

## Quando un agente scrive a un altro

Ogni volta che un agente si sveglia, l'ha deciso una persona. Con il workflow i passaggi li fa MdExplorer, e ciascun passo lo
avvia chi ne risponde. Senza workflow, se un agente scrive a un collega, il messaggio non lo sveglia: arriva nella posta del
responsabile del collega come **«Da avviare»**, e parte quando lo avvia lui. Per questo non c'è una finestra per fermare due
agenti che si scrivono senza fine: non possono farlo da soli.

Se la memoria degli agenti è accesa, nel dettaglio di un messaggio c'è anche **Consolida**: scegli i fatti che l'agente ha
imparato e che vuoi tenere nella sua scheda; gli altri decadono.

[Indice della sezione](../README.md)
