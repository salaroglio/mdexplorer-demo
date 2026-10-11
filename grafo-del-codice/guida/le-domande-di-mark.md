---
title: Le domande che Mark sa fare
---

# Le domande che Mark sa fare

## TL;DR

Quando una cartella ha un grafo, Mark riceve sette **strumenti** (tool MCP del gruppo `code`), tutti di sola lettura sul
database. Li sceglie da solo in base alla domanda; non devi nominarli. Questa pagina dice cosa fa ciascuno e una
domanda che lo fa scattare, così sai cosa aspettarti e cosa chiedere.

- Tutti partono da un **simbolo**: un id, un nome qualificato, o una ricerca a testo (`code_find_symbol`).
- Un nome ambiguo non viene indovinato: Mark ti propone gli id fra cui scegliere.
- Le risposte citano file, riga e **fiducia** della relazione; dove il grafo tace, Mark legge il sorgente e lo dice.

## I sette strumenti

| Strumento | Che cosa fa | Una domanda che lo fa scattare |
|---|---|---|
| `code_find_symbol` | trova simboli per nome qualificato, nome semplice o **testo libero** (nomi, firme e descrizioni, con l'indice a testo pieno) | «Quale metodo calcola la quota di ticket chiusi al primo contatto?» |
| `code_describe` | scheda di un simbolo: kind, firma, file e riga, parametri con tipo, direzione e descrizione, se la descrizione è da rivedere | «Descrivimi `ServizioAssistente.Conferma` con i parametri» |
| `code_outline` | i simboli di un file, nell'ordine in cui stanno | «Cosa c'è in `Conoscenza/CatalogoFaq.cs`?» |
| `code_neighbors` | i vicini di un simbolo: in uscita o in entrata, per relazione, fino a cinque salti | «Chi implementa `IMotoreRisposte`?» · «Da chi è chiamato `Proponi`?» |
| `code_impact` | tutto ciò che, a ritroso, dipende da un simbolo (chi lo chiama, chi chiama chi lo chiama…) | «Cosa si rompe se cambio la firma di `INotifica.Invia`?» |
| `code_path` | il cammino più corto fra due simboli | «Come si arriva da `Program.Main` a `TassoPrimoContatto`?» |
| `code_overview` | la panoramica della cartella: quanti simboli per tipo, quante relazioni, i più connessi, i file più grossi | «Fammi una panoramica del programma dell'help desk» |

Tutti vogliono il **nome del progetto**, che Mark prende da `get_projects`: per questo nella prima risposta lo vedi
chiamare anche quello.

## Come leggere una risposta

Una risposta di Mark sul grafo ha tre ingredienti, e vale la pena riconoscerli:

1. **Il fatto, con la riga.** «`Proponi` lo chiama `ServizioAssistente.Gestisci`, in `Assistente/ServizioAssistente.cs`,
   riga 32.» Viene dal grafo: puoi aprire il file e controllare.
2. **La fiducia.** «La chiamata verso le due classi concrete è *dedotta*.» Il grafo distingue ciò che ha letto da ciò
   che ha dedotto, e Mark lo riporta. Una relazione *ambigua* viene detta tale.
3. **Il limite.** «`code_impact` sulla soglia trova solo chi costruisce la classe: non basta, leggo il sorgente.» Quando
   il grafo non copre la domanda, Mark non riempie il vuoto con una supposizione: apre il file, e lo dice.

Se una risposta non ha nessuno dei tre, probabilmente Mark non ha usato il grafo: la conversazione è cominciata prima
che la cartella fosse segnata. «Nuova sessione chat» e riprova.

## Domande che il grafo oggi non regge

- **«Chi legge `SogliaFiducia`?»** Le letture di un campo dentro un metodo non sono archi. Mark compensa con il sorgente.
- **«Perché `Scala` manda un messaggio al secondo livello?»** Il grafo non ha i perché; le descrizioni di Mark
  ([prova 4](../prove/04-descrivi-il-codice.md)) sì, se le hai fatte scrivere.
- **«Cosa fa il template di questo componente Angular?»** I template HTML non sono nel grafo.
- **«Qual è il cammino fra due classi lontane in un progetto enorme?»** Può passare per un `import` comune, che non
  dice niente: pesare le relazioni è il prossimo passo di MdExplorer.

## Quanto costano

Gli strumenti del grafo pesano circa **1.500 token** di descrizione per conversazione e rispondono in decine di
millisecondi; il costo di una risposta è quello del ragionamento di Mark, nel nostro giro fra due e undici centesimi.
Il gruppo `code` è acceso di default quando una cartella ha un linguaggio scelto; si può spegnere nelle impostazioni
del progetto, voce «Gruppi di funzionalità MCP».

[Torna alla sezione](../README.md)
