---
title: Abilita gli agenti
---

# Prova 2: abilita gli agenti

## TL;DR

Un agente è un file di testo nel progetto: chiunque può modificarlo, anche dopo che l'hai letto. Per questo nessun
agente parte finché non lo **abiliti** tu, uno per uno, dopo aver letto cosa fa e cosa può fare sul tuo computer. In
MdExplorer questo gesto si chiama «Concedi trust».

- Si fa dal **registro** (icona delle due persone): per ogni agente leggi una finestra con due blocchi distinti.
- Un blocco è scritto dall'**autore** dell'agente (non verificato); l'altro lo **calcola l'app** dagli strumenti.
- Se qualcuno cambia la scheda dopo il tuo sì, l'abilitazione **decade** e va rifatta.

## Apri il registro

Clicca l'icona delle due persone, «Città degli agenti». Si apre l'elenco degli agenti scoperti nel progetto. Per
questo caso interessano quattro righe, tutte «Non fidato»:

| Agente | Cosa fa, in una frase |
|---|---|
| `account-manager` | cerca i bandi, avvia il giro, scrive la sintesi |
| `responsabile-tecnico` | scrive la scheda di fattibilità tecnica |
| `responsabile-legale` | scrive la scheda contrattuale |
| `responsabile-delivery` | scrive la scheda di team e piano |

Ogni riga mostra il ruolo, un riassunto di due o tre righe e gli strumenti dichiarati. Gli strumenti che cambiano le
cose (`edit`, `shell`) sono **in rosso**. Gli altri agenti che vedi nell'elenco non fanno parte di questa prova.

## Leggi la finestra di un agente

Su `responsabile-tecnico` clicca **Concedi trust**. Si apre «Concedi il trust a questo agente?», con due blocchi.

**«Che cosa fa»**, con l'etichetta arancione *scritto dall'autore, non verificato*. È il riassunto che l'autore ha
messo nella scheda: ti dice cosa produce e per chi. L'app non lo può controllare, per questo ti dice di leggerlo con
la testa.

**«Cosa può fare sul tuo computer»**, con l'etichetta verde *calcolato dall'app*. Un elenco di sì e di no dedotto dagli
strumenti dichiarati, gli unici che l'app fa rispettare:

| Voce | Per `responsabile-tecnico` |
|---|---|
| Legge i file del progetto | sì |
| Cerca nei documenti del progetto | no |
| Crea e modifica file nel progetto | **sì**, in rosso: *le consegne passano dalla tua approvazione* |
| Esegue comandi sul computer | **no** |
| Può scrivere agli altri agenti e a te | sì |
| Quando approvi il suo lavoro puoi passarlo a | `account-manager` |

Sotto, una nota dice che l'app limita comandi e scrittura di file, ma che altri strumenti del motore (per esempio la
rete) dipendono dal motore scelto.

## Perché questa finestra ti serve

Guarda gli strumenti: questo agente **non può eseguire comandi**, e tutto ciò che scrive resta in una copia a parte
finché non lo approvi. Il suo errore peggiore, quindi, è una scheda sbagliata: e quella la leggi tu prima che entri
nel progetto. È per questo che puoi abilitarlo con tranquillità, e che il controllo vero, nel resto del caso, sarà la tua
verifica di ciò che scrive.

Un agente con `shell` sarebbe un'altra storia: potrebbe fare danni **mentre lavora**, prima che tu veda un solo
risultato. La finestra lo scriverebbe in rosso.

## Abilitali

Clicca **Mi fido** e ripeti per gli altri tre agenti. Quando hai finito la riga di ognuno dice «Fidato» e il pulsante
diventa «Revoca trust».

## Cambia una parola e guarda cosa succede

1. Apri `.github/agents/responsabile-tecnico.agent.md` e, nel riassunto (`summary:`), cambia una parola. Salva.
2. Torna al registro e premi **Aggiorna**.

`responsabile-tecnico` non è più fidato: hai letto una descrizione, ne trovi un'altra, e l'app te lo fa rifare. Vale per
ogni cosa dentro `a2a:` e per gli strumenti (`tools:`): se cambiano, l'abilitazione decade. Se invece cambi il testo
**sotto** il blocco in alto (le istruzioni), resta valida.

Rimetti la parola com'era e abilitalo di nuovo prima di proseguire. Se la riga dice «Non fidato» invece di «decaduto»,
è lo stesso effetto: dipende da chi se n'è accorto per primo.

## E se non succede niente

- **Non vedi i quattro agenti.** Aspetta qualche secondo che il progetto finisca di indicizzare e premi **Aggiorna**.
- **«Concedi trust» non risponde.** Chiudi e riapri il registro.

[Prova 3: l'account manager cerca il bando](03-l-account-manager-cerca-il-bando.md) · [Prova 1](01-accendi-la-citta.md) · [Indice della sezione](../README.md)
