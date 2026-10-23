---
title: "Nota tecnica: Fuseki, Java e le grammatiche"
---

# Nota tecnica: Fuseki, Java e le grammatiche

## TL;DR

Il grafo del codice vive in **Apache Jena Fuseki**, un database a grafo che MdExplorer include nel pacchetto e avvia
da sé: serve **Java 21** sul computer, lo stesso che fa girare PlantUML. Per i linguaggi diversi dal C# e dal PowerShell
si scarica una piccola grammatica da mdexplorer.net, una volta per linguaggio.

- Nessun servizio da installare né da configurare: Fuseki parte con MdExplorer, su una porta locale, e si spegne con lui.
- I dati stanno nella cartella dati di MdExplorer, fuori dal progetto; gli script nel progetto bastano a ricostruirli.
- Senza rete funziona tutto, tranne il primo scaricamento di una grammatica.

## Che cosa serve

| Cosa | Perché | Dove si controlla |
|---|---|---|
| **Java 21** o più recente | Fuseki 6 è scritto in Java 21; MdExplorer lo rifiuta più vecchio e lo dice | all'avvio MdExplorer controlla il Java impostato e, se l'aveva scelto lui ed è vecchio o sparito, lo sostituisce con il migliore che trova e lo dice; nelle impostazioni c'è «Rileva il migliore» |
| **Rete**, una volta per linguaggio | per scaricare la grammatica tree-sitter (0,1-1,5 MB) | la finestra «Ambiente di sviluppo», pulsante «Scarica la grammatica» |
| **Un motore AI** del progetto | per «Descrivi con Mark» e per le domande nel tab Mark Agent | impostazioni del progetto, «Ambiente agentico»; il modello per descrivere, nella finestra «Ambiente di sviluppo» |

Per il **C# non serve niente**: l'estrattore è Roslyn, il compilatore, che MdExplorer si porta dietro e usa senza SDK,
senza MSBuild e senza compilare davvero il programma. Lo stesso per il **PowerShell**: il parser ufficiale del
linguaggio è nel pacchetto, e non serve `pwsh` installato.

## Fuseki, in due righe

Fuseki è il server di Apache Jena: un database **RDF**, cioè un grafo di triple «soggetto, relazione, oggetto», che si
interroga in **SPARQL**. MdExplorer ne avvia un'istanza propria, raggiungibile solo dal computer stesso, con un dataset
`code` dove ogni cartella «program» ha il suo grafo nominato. Lo stesso Fuseki fa da memoria agli agenti della
[città degli agenti](../../citta-degli-agenti/README.md), quando è accesa.

Dentro, il vocabolario è l'ontologia `mde-code`: un simbolo è un `code:Symbol` con `code:kind`, `code:qualifiedName`,
`code:signature`, `code:line`; una relazione è una tripla diretta (`code:calls`, `code:implements`…) più un nodo
«arco» (`code:Edge`) che porta la riga e la fiducia; una descrizione è un `code:Description` legato al simbolo, e a che
cosa serve un file un `code:FileDescription` legato al file. La ricerca a testo pieno (`code_find_symbol` con un
frammento) la fa l'indice Lucene di jena-text sui nomi e sulle descrizioni.

Gli script di `.mde-code/` sono già queste triple, scritte in **Turtle**: MdExplorer li carica in Fuseki così come sono,
un file per grafo, senza tradurli. Chi vuole può caricarli in un altro database RDF o interrogarli con gli strumenti di
Apache Jena.

## Dove finiscono i dati

| Sistema | Cartella di Fuseki |
|---|---|
| Windows | `%AppData%\MdExplorer\fuseki-data` |
| Linux | `~/.local/share/MdExplorer/fuseki-data` |
| macOS | `~/Library/Application Support/MdExplorer/fuseki-data` |

Si può cancellare: alla prossima apertura del progetto MdExplorer ricarica gli script di `.mde-code/` e il grafo torna
com'era. Il contrario non vale: senza gli script il grafo non si ricostruisce, per questo gli script si committano.

Le grammatiche scaricate stanno accanto, in `grammars/<piattaforma>/`, una per linguaggio, con la versione e
l'impronta: MdExplorer controlla l'impronta prima di installarle e non installa nulla che non torni.

## Quanto costa

Sulla macchina di prova di MdExplorer (una macchina virtuale Linux) l'intero codice di **PlantUML**, 3.662 file Java,
è stato analizzato e caricato in **202 secondi**: 40.002 simboli e 210.791 relazioni, 1,1 GB su disco, circa 1 GB di
memoria per Fuseki. Le domande di Mark sul grafo rispondono in decine o centinaia di millisecondi; la panoramica di un
progetto così grande è l'unica che supera i tre secondi. Il programma d'esempio di questa sezione, quindici file, si
analizza in meno di un secondo.

«Descrivi con Mark» è l'unico passo che consuma il tuo abbonamento AI: una domanda per ogni gruppo di simboli dello
stesso file allo stesso livello, solo per quello che manca o è cambiato. Per i quindici file d'esempio sono 33 domande,
un paio di minuti. Su PlantUML sarebbero 13.429 domande su 49 livelli, più 3.229 getter, setter e costanti che
MdExplorer descrive da solo senza chiedere niente: per questo la finestra mostra il conto prima di partire, e per questo
il modello per descrivere si sceglie a parte (con Claude Code il predefinito è `haiku`, il più leggero). Le domande nel
tab e le correzioni delle descrizioni costano quanto una normale conversazione con Mark.

[Torna alla sezione](../README.md)
