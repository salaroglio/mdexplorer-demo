---
title: Le domande che Mark sa fare
---

# Le domande che Mark sa fare

## TL;DR

Quando una cartella ha un grafo, Mark riceve dieci **strumenti** (tool MCP del gruppo `code`): nove leggono il grafo e
uno corregge le descrizioni. Li sceglie da solo in base alla domanda; non devi nominarli. Questa pagina dice cosa fa
ciascuno e una domanda che lo fa scattare, così sai cosa aspettarti e cosa chiedere; e quali domande si fanno senza
scrivere, dal grafo.

- Tutti partono da un **simbolo**: un id, un nome qualificato, o una ricerca a testo (`code_find_symbol`).
- Un nome ambiguo non viene indovinato: Mark ti propone gli id fra cui scegliere.
- Le risposte citano file, riga e **fiducia** della relazione; dove il grafo tace, Mark legge il sorgente e lo dice.
- Mark non scrive query al database: chiede a MdExplorer, che le fa al posto suo e risponde con i fatti.

## I dieci strumenti

| Strumento | Che cosa fa | Una domanda che lo fa scattare |
|---|---|---|
| `code_find_symbol` | trova simboli per nome qualificato, nome semplice o **testo libero** (nomi, firme e descrizioni, con l'indice a testo pieno) | «Quale metodo calcola la quota di ticket chiusi al primo contatto?» |
| `code_describe` | scheda di un simbolo: kind, firma, file e riga, parametri con tipo, direzione e descrizione, se la descrizione è da rivedere | «Descrivimi `ServizioAssistente.Conferma` con i parametri» |
| `code_outline` | a che cosa serve un file e i suoi simboli, nell'ordine in cui stanno | «Cosa c'è in `Conoscenza/CatalogoFaq.cs`?» |
| `code_neighbors` | i vicini di un simbolo: in uscita o in entrata, per relazione, fino a cinque salti | «Chi implementa `IMotoreRisposte`?» · «Da chi è chiamato `Proponi`?» |
| `code_impact` | tutto ciò che, a ritroso, dipende da un simbolo (chi lo chiama, chi chiama chi lo chiama…) | «Cosa si rompe se cambio la firma di `INotifica.Invia`?» |
| `code_path` | il cammino più corto fra due simboli | «Come si arriva da `Program.Main` a `TassoPrimoContatto`?» |
| `code_overview` | la panoramica della cartella: quanti simboli per tipo, quante relazioni, i più connessi, i file più grossi con la loro utilità | «Fammi una panoramica del programma dell'help desk» |
| `code_inventory` | che cosa c'è nel grafo, cartella per cartella: linguaggi, file e simboli letti, quanti hanno già una descrizione, l'ultimo giro di descrizione e quelli in corso | «A che punto è la descrizione del programma? È finita?» |
| `code_roots` | dove sta il codice su questo computer: le cartelle del progetto e le radici esterne (codice che sta fuori, con un alias) | «Dove sta il codice del backend su questo computer?» |
| `code_set_description` | **scrive**: corregge o completa una descrizione, del file o di un simbolo con ritorno, avvertenze e parametri; MdExplorer la controlla e aggiorna lo script `.doc.ttl` | «La descrizione di `Gestisci` non dice che il ticket è archiviato prima della proposta: aggiungilo» |

Tutti vogliono il **nome del progetto**, che Mark prende da `get_projects`: per questo nella prima risposta lo vedi
chiamare anche quello.

`code_set_description` è l'unico che scrive, e scrive solo le descrizioni: i fatti letti dal parser (chi chiama chi, le
righe) non si toccano, e Mark non scrive mai a mano gli script di `.mde-code/`. Lo provi nella
[prova 4](../prove/04-analizza-il-codice.md).

## Dal grafo, senza scrivere

Nella pagina «Grafo del codice» il tasto destro fa la domanda al posto tuo. La risposta arriva nella finestra di Mark,
nella stessa conversazione del tab, e puoi continuare a chiedere da lì.

| Tasto destro su | Voce | Che cosa chiede a Mark |
|---|---|---|
| un simbolo | «Chiedi a MarkAgent di «X»» | di spiegarlo: a che cosa serve, che cosa riceve e restituisce, chi lo chiama, che cosa chiama, gli effetti, i punti delicati |
| un file | «Chiedi a MarkAgent di spiegare «X» e i suoi legami» | a che cosa serve il file e perché è collegato agli altri, con i legami disegnati |
| un arco | «Chiedi a MarkAgent: che cosa vuol dire «A → B»?» | di leggere i punti del codice da cui nasce l'arco e dire se è certo, dedotto o ambiguo |
| un simbolo | «Descrivi con Mark» · «Rifai la descrizione con Mark» | di scrivere, o riscrivere, la descrizione di quel solo simbolo: questa non è una domanda, aggiorna lo script |
| un file | «Descrivi il file con Mark» · «Rifai la descrizione del file con Mark» | lo stesso, per a che cosa serve il file |

## Come leggere una risposta

Una risposta di Mark sul grafo ha tre ingredienti, e vale la pena riconoscerli:

1. **Il fatto, con la riga.** «`Proponi` lo chiama `ServizioAssistente.Gestisci`, in `Assistente/ServizioAssistente.cs`,
   riga 32.» Viene dal grafo: puoi aprire il file e controllare.
2. **La fiducia.** «La chiamata verso le due classi concrete è *dedotta*.» Il grafo distingue ciò che ha letto da ciò
   che ha dedotto, e Mark lo riporta. Una relazione *ambigua* viene detta tale.
3. **Il limite.** «`code_impact` sulla soglia trova solo chi costruisce la classe: non basta, leggo il sorgente.» Quando
   il grafo non copre la domanda, Mark non riempie il vuoto con una supposizione: apre il file, e lo dice.

Se una risposta non ha nessuno dei tre, probabilmente Mark non ha usato il grafo: la conversazione è cominciata prima
che la cartella fosse segnata (con Copilot o opencode). «Nuova sessione chat» e riprova.

## Domande che il grafo oggi non regge

- **«Chi legge `SogliaFiducia`?»** Le letture di un campo dentro un metodo non sono archi. Mark compensa con il sorgente.
- **«Perché `Scala` manda un messaggio al secondo livello?»** Il grafo non ha i perché; le descrizioni di Mark
  ([prova 4](../prove/04-analizza-il-codice.md)) sì, se hai fatto descrivere il codice.
- **Le descrizioni appena scritte, durante un giro lungo.** Mentre «Descrivi con Mark» lavora, le descrizioni entrano
  nel database a gruppi, ogni 200 domande o ogni cinque minuti: le ultime Mark può non vederle ancora.
- **«Cosa fa il template di questo componente Angular?»** I template HTML non sono nel grafo.
- **«Qual è il cammino fra due classi lontane in un progetto enorme?»** Può passare per un `import` comune, che non
  dice niente: pesare le relazioni è il prossimo passo di MdExplorer.

## Quanto costano

Gli strumenti del grafo pesano circa **2.500 token** di descrizione per conversazione e rispondono in decine di
millisecondi; il costo di una risposta è quello del ragionamento di Mark, nel nostro giro fra due e undici centesimi.
Il gruppo `code` è acceso di default quando una cartella ha un linguaggio scelto; si può spegnere nelle impostazioni
del progetto, voce «Gruppi di funzionalità MCP».

[Torna alla sezione](../README.md)
