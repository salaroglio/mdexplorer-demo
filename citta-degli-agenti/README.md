---
title: La città degli agenti
---

# La città degli agenti

## TL;DR

In MdExplorer gli agenti AI possono abitare un progetto, ognuno con un nome, un ruolo e il lavoro di una persona. Questa
sezione ti fa provare **come si lavora con loro**: ogni persona ha il suo agente, l'agente prepara, la persona verifica e
decide se passare il lavoro al passo dopo. Il caso è una gara d'appalto di un'azienda inventata, Pentagroup.

- Sei prove, in ordine, circa un'ora in tutto (la maggior parte è attesa).
- Gli agenti **scrivono schede**, ma nessuna scheda entra nel progetto senza la tua approvazione.
- Serve un motore AI già configurato (GitHub Copilot, Claude Code o opencode) e la rete.

## Il caso

Pentagroup riceve un invito a una gara di Nordica Crediti: un capitolato lungo, da leggere con occhi diversi prima di
decidere se partecipare. [La gara di Nordica](gara/README.md) dice chi sono i quattro agenti, cosa fa ciascuno e come passa il lavoro: leggila
prima di cominciare.

## Le presentazioni

- [Un assistente per ogni persona](presentazione/citta-degli-agenti.md): l'idea, in sedici slide.
- [La gara, passo per passo](presentazione/guida-passo-passo.md): cosa fare e dove cliccare. Per ora c'è la **parte 1**, fino al
  messaggio dell'account manager.

## Il percorso

| # | Pagina | Cosa provi | Tempo |
|---|---|---|---|
| 1 | [Accendi la città](prove/01-accendi-la-citta.md) | una casella nelle impostazioni, e dove consegnano gli agenti | 3 min |
| 2 | [Abilita gli agenti](prove/02-abilita-gli-agenti.md) | leggi cosa fa e cosa può fare ciascun agente, poi lo abiliti | 7 min |
| 3 | [L'account manager cerca il bando](prove/03-l-account-manager-cerca-il-bando.md) | lanci il primo agente e controlli ciò che propone | 5 min |
| 4 | [Avvia il giro e leggi le schede](prove/04-avvia-il-giro.md) | dici «avvia», aspetti tre schede e le leggi prima di approvarle | 12 min |
| 5 | [Approva e passa il lavoro](prove/05-approva-e-passa-il-lavoro.md) | approvi tre schede: ogni approvazione avvisa il collega | 10 min |
| 6 | [La sintesi e la tua decisione](prove/06-la-sintesi-e-la-tua-decisione.md) | leggi la sintesi, cerchi dove le schede si parlano, decidi | 8 min |

## Prima di cominciare

- Apri questo progetto in MdExplorer. La strada più semplice è **«Crea progetto demo»**: prepara tutto, compreso il
  repository su cui gli agenti consegnano.
- La città è **spenta** finché non la accendi (prova 1). Gli agenti ci sono già, in `.github/agents/`.
- Ogni agente chiama il motore AI scelto per il progetto: l'intero percorso fa una decina di chiamate e consuma un po' del
  tuo abbonamento.
- Se usi opencode, scrivi nella scheda dell'agente anche un modello (`runtime: model:`): senza, il livello gratuito non basta.

## Cosa non vedrai qui

La federazione tra città di persone diverse, la memoria degli agenti e il lavoro di più persone su computer diversi hanno
bisogno di cose che un repository pubblico non può dare (una chiave di stanza, un relay, un componente in più). Si mostrano
dal vivo. In questo caso le quattro persone sono tutte tu.

[Torna all'inizio](../README.md)
