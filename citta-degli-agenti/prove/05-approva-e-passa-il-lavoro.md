---
title: Approva e passa il lavoro
---

# Prova 5: approva e passa il lavoro

> **La posta è cambiata.** Dove questa pagina dice «Posta in arrivo» e «Lavoro degli agenti», oggi il fumetto apre un elenco solo, a
> tutto schermo, e un documento si legge con **Apri** senza passare da «Ci metto mano». Vedi
> [La posta degli agenti](../guida/la-posta-degli-agenti.md). Le schermate qui sotto sono ancora quelle di prima.

## TL;DR

Approvare una scheda fa due cose: la porta nel ramo principale e **tu decidi a chi passarla**. Il pulsante «Autorizza» avvisa
l'agente dell'account manager a nome tuo; l'agente non si sveglia da solo. Dopo la terza approvazione ha tutto quello che
serve per scrivere la sintesi.

- Nella richiesta compare «Dopo l'approvazione, a chi passa il lavoro?».
- Con un solo destinatario basta **Autorizza**; con più di uno devi scegliere (o dire «a nessuno»).
- Dopo ogni approvazione l'account manager ti dice cosa ha ricevuto e cosa manca.

## Approva la prima scheda

1. Nel fumetto apri **Lavoro degli agenti**: la richiesta di `responsabile-tecnico` ha il blocco «Dopo l'approvazione, a
   chi passa il lavoro?» con una voce, `account-manager`, già selezionata (e la voce «A nessuno»). Se una scheda di
   agente dichiarasse due destinatari, **Autorizza** resterebbe spento finché non scegli tu.
2. Clicca **Autorizza**. Compare «Lavoro fuso nel ramo principale. Ho avvisato account-manager.»

Dopo circa mezzo minuto, nella posta, `account-manager` ti scrive qualcosa come: «Ho ricevuto la scheda del responsabile
tecnico. Mancano le schede del legale e del delivery». Non scrive la sintesi: **non ci sono ancora le tre**.

## Approva la seconda e la terza

Ripeti con `responsabile-legale`: dopo la sua approvazione l'account manager dice che manca solo il delivery. Poi con
`responsabile-delivery`.

Ti conviene aspettare il messaggio dell'account manager prima di approvare la scheda successiva: vedi il lavoro che
avanza un passo alla volta.

## Cosa è successo, passo per passo

| Tuo gesto | Cosa fa l'app | Cosa fa l'agente |
|---|---|---|
| **Autorizza** | porta la scheda nel ramo principale e lo pubblica sul repository | niente: non c'entra |
| (stesso clic) | manda a `account-manager` un messaggio che comincia con `[APPROVATO]`, **a nome tuo** | si sveglia, controlla quali schede ci sono, ti scrive cosa manca |
| terza approvazione | come sopra | ha le tre schede: scrive la sintesi (prova 6) |

Nota: il mittente di `[APPROVATO]` sei tu. Per questo un agente non può «passare» il lavoro a un altro da solo: la
decisione di passarlo è nel tuo clic.

## Prova a dire «a nessuno»

Se vuoi vedere la differenza, su una richiesta nuova scegli «A nessuno: autorizza e basta»: la scheda entra nel progetto
e **nessuno viene avvisato**. L'account manager non saprebbe niente della scheda fino al prossimo messaggio.

## Quando l'avviso non parte

Se l'agente a cui devi passare il lavoro non esiste, non è fidato o non può ricevere, la richiesta lo mostra **in rosso con
il motivo** e non puoi sceglierlo. Se l'avviso parte ma qualcosa va storto dopo l'approvazione, l'app lo dice in un
avviso di 20 secondi: il lavoro è già approvato, ma l'agente non è stato avvisato.

## E se non succede niente

- **Nessun messaggio dall'account manager dopo un minuto.** Controlla in «Posta in arrivo» e premi **Aggiorna**.
- **L'account manager scrive che manca una scheda che hai già approvato.** Aspetta qualche secondo e controlla in «Lavoro
  degli agenti» che la richiesta non sia ancora lì: significa che l'approvazione non è finita.

[Prova 6: la sintesi e la tua decisione](06-la-sintesi-e-la-tua-decisione.md) · [Prova 4](04-avvia-il-giro.md) · [Indice della sezione](../README.md)
