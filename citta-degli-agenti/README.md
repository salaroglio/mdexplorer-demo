---
title: La città degli agenti
---

# La città degli agenti

## TL;DR

In MdExplorer gli agenti AI non sono solo una conversazione: possono abitare un progetto, ognuno con un nome, un
ruolo e un documento da presidiare, e scriversi tra loro. Tu decidi di chi fidarti, vedi cosa si dicono e
ricevi il risultato nella posta. Questa sezione ti fa provare tutto con le mani, su un caso di studio che
contiene tre incongruenze.

- Sei prove, in ordine, circa mezz'ora in tutto.
- Gli agenti del demo **non modificano nessun file**: leggono, si scrivono e ti riferiscono.
- Serve un motore AI già configurato (GitHub Copilot, Claude Code o opencode) e la rete.

## La presentazione

Dieci minuti per capire l'idea, prima di toccare qualcosa: [La città degli agenti](presentazione/citta-degli-agenti.md),
17 slide con i tre custodi, la scena di Alpina e i messaggi che volano. Si apre come una presentazione, dal pulsante
**Presenta**.

## Il percorso

| # | Pagina | Cosa provi | Tempo |
|---|---|---|---|
| 1 | [Accendi la città](prove/01-accendi-la-citta.md) | una casella nelle impostazioni, e cosa cambia nel progetto | 3 min |
| 2 | [Il registro e la fiducia](prove/02-registro-e-fiducia.md) | chi abita la città e a chi dai fiducia | 5 min |
| 3 | [Il primo agente al lavoro](prove/03-il-primo-agente.md) | lanci un agente e leggi il risultato nella posta | 5 min |
| 4 | [Il dialogo tra due agenti](prove/04-il-dialogo.md) | due agenti si scrivono per trovare le incongruenze | 8 min |
| 5 | [La fiducia che decade](prove/05-la-fiducia-che-decade.md) | cambi la scheda di un agente e la fiducia sparisce | 5 min |
| 6 | [Il lavoro che passa dalla tua approvazione](prove/06-lavoro-e-revisione.md) | un agente che modifica i file, e come lo rivedi | 5 min |

## Il caso di studio

Gli agenti lavorano sui documenti del pilota di Alpina Servizi, lo stesso [caso di studio](../caso-studio/README.md)
del resto del demo. [La città di Alpina](alpina/README.md) dice chi sono i tre agenti, come si parlano e cosa devono
trovare: leggila prima di cominciare.

## Prima di cominciare

- Apri questo progetto in MdExplorer: è un repository git, come gli altri.
- La città è **spenta** finché non la accendi (prova 1). Gli agenti ci sono già, in `.github/agents/`.
- Ogni agente chiama il motore AI scelto per il progetto: ogni prova consuma un po' del tuo abbonamento.
- Se usi opencode, scrivi nella scheda dell'agente anche un modello (`runtime: model:`): senza, il livello
  gratuito non basta.

## Cosa non vedrai qui

La federazione tra città di persone diverse, la memoria degli agenti e la fusione automatica del lavoro in `main`
hanno bisogno di cose che un repository pubblico non può dare (una chiave di stanza, un relay, un componente
in più, un repository su cui puoi scrivere). Si mostrano dal vivo; la [pagina del caso di studio](alpina/README.md)
dice cosa sono e perché mancano.

[Torna all'inizio](../README.md)
