---
title: Accendi la città
---

# Prova 1: accendi la città

## TL;DR

La città degli agenti è spenta in ogni progetto finché non la accendi tu. Si accende con una casella nelle
impostazioni del progetto e cambia il progetto in un punto solo: due righe nel file `.development.yml`.
Questa prova ti fa accenderla e vedere cosa è cambiato.

- La casella sta in «Impostazioni Progetto», nella sezione «Città degli agenti / Federazione».
- Accesa, la barra degli strumenti mostra quattro icone nuove.
- Il progetto diventa «da committare»: **non committare quel file** in questo demo.

## Accendila

1. Apri la pagina dei **progetti recenti**: è quella che vedi quando avvii MdExplorer.
2. Sulla scheda di questo progetto clicca la rotella: si apre «Impostazioni Progetto». Può metterci un momento.
3. Scorri fino alla sezione **Città degli agenti / Federazione**.
4. Spunta «Abilita la città degli agenti per questo progetto».
5. Chiudi la finestra e riapri il progetto cliccando sulla sua scheda.

## Cosa vedi

Nella barra degli strumenti, accanto alle icone di prima, compaiono quattro icone nuove:

| Icona | Si chiama | A cosa serve |
|---|---|---|
| le due persone | «Città degli agenti» | il registro: chi abita il progetto e di chi ti fidi |
| la persona in un cerchio | l'identità | chi sei per la città; serve alla federazione |
| la testa con la lampadina | la memoria degli agenti | richiede un componente in più, non lo usiamo |
| il fumetto | «Messaggi degli agenti» | la posta, le conversazioni e il lavoro da rivedere |

## Cosa è cambiato nel progetto

In alto a destra il badge dice «1 da committare». Il file cambiato è `.development.yml`, nella cartella del
progetto, e ha due righe nuove:

```yaml
agentCity:
  enabled: true
  roomSecret: <una chiave casuale, generata sul tuo computer>
```

- `enabled` è l'interruttore che hai appena spuntato.
- `roomSecret` è una chiave casuale che MdExplorer genera la prima volta. Serve solo alla federazione tra città
  di persone diverse, che qui non si usa; ma è una **credenziale**, perché in un gruppo vero finisce nel
  repository insieme al resto.

> **Non fare commit di `.development.yml` in questo demo.** Il repository è pubblico: la chiave non deve finirci.
> Per tornare com'eri ripristina il file con git: `git checkout .development.yml`.

## Dove consegnano gli agenti

Gli agenti di questo caso **scrivono documenti**, e un documento scritto da un agente non entra mai nella tua
cartella da solo: lo consegna su un ramo a parte e tu lo approvi. Per consegnare, l'agente ha bisogno di un
repository su cui poter scrivere, che nel linguaggio di git si chiama `origin`.

- Se hai creato il progetto con **«Crea progetto demo»**, MdExplorer ha già preparato tutto: accanto alla cartella
  del progetto c'è una cartella `<nome>.origin.git`, e il repository pubblico del demo è rimasto come `upstream`.
  Non devi fare niente, e non rovina nessun altro progetto: lo fa solo per il clone del demo.
- Se invece hai clonato il demo a mano, `origin` è il repository pubblico, su cui non puoi scrivere: la consegna
  non riesce e ti arriva un messaggio che lo dice. Fai prima un **fork** sul tuo account e lavora su quello.

Per sapere cosa succede davvero, leggi la [nota tecnica sul repository locale](../guida/nota-tecnica-repository-locale.md).

## Perché è spenta di partenza

Una città accesa può svegliare agenti AI e farli parlare, e ogni risveglio consuma il tuo abbonamento. Per questo
è una scelta esplicita, **di progetto**: sta in un file che il gruppo di lavoro condivide.

[Prova 2: abilita gli agenti](02-abilita-gli-agenti.md) · [Indice della sezione](../README.md)
