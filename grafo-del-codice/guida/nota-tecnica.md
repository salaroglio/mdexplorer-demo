---
title: "Nota tecnica: Fuseki, Java e le grammatiche"
---

# Nota tecnica: Fuseki, Java e le grammatiche

## TL;DR

Il grafo del codice vive in **Apache Jena Fuseki**, un database a grafo che MdExplorer include nel pacchetto e avvia
da sé: serve **Java 21** sul computer, lo stesso che fa girare PlantUML. Per i linguaggi diversi dal C# si scarica una
piccola grammatica da mdexplorer.net, una volta per linguaggio.

- Nessun servizio da installare né da configurare: Fuseki parte con MdExplorer, su una porta locale, e si spegne con lui.
- I dati stanno nella cartella dati di MdExplorer, fuori dal progetto; gli script nel progetto bastano a ricostruirli.
- Senza rete funziona tutto, tranne il primo scaricamento di una grammatica.

## Che cosa serve

| Cosa | Perché | Dove si controlla |
|---|---|---|
| **Java 21** o più recente | Fuseki 6 è scritto in Java 21; MdExplorer lo rifiuta più vecchio e lo dice | il controllo delle dipendenze all'avvio di MdExplorer; il percorso di Java nelle impostazioni |
| **Rete**, una volta per linguaggio | per scaricare la grammatica tree-sitter (0,1-1,5 MB) | la finestra «Ambiente di sviluppo», pulsante «Scarica la grammatica» |
| **Un motore AI** del progetto | per «Descrivi il codice con Mark» e per le domande nel tab Mark Agent | impostazioni del progetto, «Ambiente agentico» |

Per il **C# non serve niente**: l'estrattore è Roslyn, il compilatore, che MdExplorer si porta dietro e usa senza SDK,
senza MSBuild e senza compilare davvero il programma.

## Fuseki, in due righe

Fuseki è il server di Apache Jena: un database **RDF**, cioè un grafo di triple «soggetto, relazione, oggetto», che si
interroga in **SPARQL**. MdExplorer ne avvia un'istanza propria, raggiungibile solo dal computer stesso, con un dataset
`code` dove ogni cartella «program» ha il suo grafo nominato. Lo stesso Fuseki fa da memoria agli agenti della
[città degli agenti](../../citta-degli-agenti/README.md), quando è accesa.

Dentro, il vocabolario è l'ontologia `mde-code`: un simbolo è un `code:Symbol` con `code:kind`, `code:qualifiedName`,
`code:signature`, `code:line`; una relazione è una tripla diretta (`code:calls`, `code:implements`…) più un nodo
«arco» che porta la riga e la fiducia. La ricerca a testo pieno (`code_find_symbol` con un frammento) la fa l'indice
Lucene di jena-text sui nomi e sulle descrizioni.

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

«Descrivi il codice con Mark» è l'unico passo che consuma il tuo abbonamento AI: una chiamata per file sorgente, solo
per i file con simboli da descrivere.

[Torna alla sezione](../README.md)
