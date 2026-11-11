---
title: Come Mark verifica il grafo
---

# Come Mark verifica il grafo

## TL;DR

Il grafo del codice è utile quanto è vero. Mark ha gli strumenti per sapere **com'è fatto** (il TBox, `code_ontology`),
per **confrontarlo con il sorgente** a una domanda precisa (la skill `mde-code-check`) e per **correggere** quello che
si può correggere nel progetto: le regole che collegano ciò che il parser non vede, e i pacchetti dei linguaggi aggiunti.

- Il TBox dice classi, proprietà e relazioni del grafo; per ogni linguaggio, che cosa il suo parser ha prodotto davvero.
- Una correzione non entra mai da sola: le regole e i linguaggi li approvi tu, una regola sbagliata si ritira con il tuo accordo.
- Quello che solo MdExplorer può correggere torna a chi lo mantiene come **rilevazione**, senza i nomi del tuo codice.

## Il TBox: com'è fatto il grafo

Ogni parser (Roslyn per C# e Visual Basic, tree-sitter per TypeScript, Python e Java, i pacchetti dichiarativi) scrive
gli stessi tipi di nodi. Il **TBox**, la parte dello schema che descrive le classi e le proprietà, li elenca in Turtle
(OWL), con un significato per ciascuno:

| Classe | Che cos'è |
|---|---|
| `File` | un sorgente letto da un parser |
| `Symbol` | una classe, un metodo, un campo, un controllo di una pagina; oppure, con tipo `external`, qualcosa usato ma dichiarato altrove (una classe di libreria, una tabella, una procedura) |
| `Parameter` | un parametro, nell'ordine |
| `Edge` | una relazione fra due simboli, con la riga, la fiducia e la regola che l'ha prodotta |
| `CallSite`, `StringArgument`, `TypeArgument` | i **fatti per le regole**: dove un nome è chiamato con stringhe o tipi fra gli argomenti |
| `Annotation`, `AnnotationArgument` | gli attributi e le annotazioni scritti su un simbolo |
| `RuleSet`, `LinkDescription` | una regola applicata, e la risposta alla sua domanda `describe` per ogni punto collegato |
| `Description`, `ParameterDescription`, `FileDescription`, `DescriptionSet` | le descrizioni scritte da Mark |
| `CallResolution` | la scelta dell'LLM fra i candidati di una chiamata ambigua |

`code_ontology` restituisce il TBox e, per ogni linguaggio del progetto, il profilo del suo parser: nome, versione, file
letti, tipi di simbolo e relazioni prodotte, con i numeri. La skill del grafo chiede a Mark di leggerlo **una volta,
all'inizio**: così non cerca ciò che il grafo non registra e non trascura ciò che registra (la fiducia di un arco, la
riga, la condizione `guard` di un controllo).

Il TBox è generato dalle stesse tabelle con cui MdExplorer legge gli script del grafo: non può restare indietro rispetto
al codice di MdExplorer.

## La verifica: il metodo della skill `mde-code-check`

| Passo | Che cosa fa Mark |
|---|---|
| 0 · la struttura | `code_ontology`, se non l'ha già letto: quali relazioni produce quel linguaggio |
| 1 · l'affermazione | in una riga, che cosa si verifica; i collegamenti dal grafo con fiducia e riga |
| 2 · il campione | almeno dieci punti sparsi, metà dal grafo (per i collegamenti falsi) e metà dal sorgente (per quelli mancanti) |
| 3 · il sorgente | apre ogni punto: giusto, sbagliato, o non decidibile dal codice |
| 4 · chi l'ha prodotto | parser, regola, pacchetto o descrizione: decide che cosa si può fare |
| 5 · la risposta | prima dal sorgente, poi i numeri («9 su 10 controllati»), mai una percentuale inventata sul programma intero |

La skill elenca anche i punti da controllare per primi nel C# e nel Visual Basic, quelli che MdExplorer legge da poco: i
riferimenti fra progetti, i tipi di .NET Framework, gli eventi, le forme proprie del VB, i nomi nelle stringhe, l'SQL
nelle stringhe, la dependency injection.

## Le regole: collegare ciò che il parser non vede

A volte il collegamento c'è, ma sta in una stringa o in una registrazione: `cmd.CommandText = "PKG_RAPPORTI.ELENCO"`,
`services.AddScoped<IRapporto, RapportoSettimanale>()`. Il parser registra il **fatto** (chi, dove, con quale stringa o
quale tipo); una **regola** dice che cosa vuol dire, e MdExplorer la applica a tutti i punti.

1. Mark scrive la regola e la prova a secco (`code_rule_try`): MdExplorer dice quanti punti collega e quali no, e perché.
2. Apre nel sorgente i punti di esempio che MdExplorer gli restituisce.
3. La propone (`code_rule_propose`): nel tab di Mark compare «Migliora il grafo», con il problema, i numeri e un sì o un no.

Le regole sono di due tipi. **Smistamento**: una stringa nomina il metodo che parte (relazione `dispatches`), oppure un
simbolo di un **altro linguaggio**, come la procedura del database chiamata dal codice. **Registrazione**: un'astrazione
si risolve nell'implementazione registrata altrove (relazione `resolvesTo`): un contenitore di dependency injection, un
attributo `[Export]`.

Quando il bersaglio non è nel grafo, perché il codice del database non è stato ancora analizzato, il collegamento si
fa lo stesso verso un **nodo esterno** con il nome scritto nel codice; quando quei sorgenti arrivano, la regola si
riapplica e il collegamento passa al simbolo vero. Una regola che collega meno del 60% dei punti che dovrebbe collegare
viene respinta: i bersagli fuori dal grafo non contano contro di lei.

Una regola approvata e poi trovata sbagliata si corregge riproponendola con lo stesso nome. Se nessuna regola può essere
giusta, Mark la ritira (`code_rule_remove`), con tutti i suoi collegamenti, **dopo che sei d'accordo**: il motivo resta
nel log, e la regola resta nella storia di Git.

## I linguaggi aggiunti, con il loro TBox

Un linguaggio che MdExplorer non conosce si aggiunge con un **pacchetto**: una cartella `.mde-languages/<id>/` con le
regole (`language.yml`), il prompt per le descrizioni, le skill per gli agenti, le rilevazioni. Mark lo prova a secco
(`code_language_try`) e lo propone (`code_language_propose`); si porta da un progetto all'altro con «Esporta linguaggio…»
e «Importa linguaggio…».

Ogni pacchetto ha il suo **`tbox.ttl`**: quali tipi di simbolo e quali relazioni producono le sue regole, ciascuno con
la regola di `language.yml` da cui nasce. Lo scrive MdExplorer dalle regole, quando approvi la proposta, all'import e
all'export, così nello zip c'è sempre quello delle regole di quel momento. Non si scrive a mano: si cambiano le regole, e
lui le segue. `code_ontology` lo restituisce per ogni pacchetto del progetto.

## Le rilevazioni: quello che solo MdExplorer può correggere

Se il collegamento sbagliato viene dal parser di MdExplorer, né Mark né tu potete cambiarlo. Mark scrive una
**rilevazione**, `.mde-code/_findings/rilevazione-AAAA-MM-GG.md`: le **forme** del codice (uno scheletro con nomi
inventati, un'espressione regolare) e i **numeri**, mai il codice, i nomi delle classi, delle tabelle o dei server.
Le rilevazioni dei pacchetti di linguaggio stanno nel pacchetto, in `findings/`.

Le rilevazioni arrivano a chi mantiene MdExplorer con **«Invia diagnostica»**, nella lista dei progetti: si spunta
«Allega le rilevazioni di MarkAgent», si guarda l'anteprima, si invia. Senza rete, «Salva lo zip».

## Gli strumenti

| Strumento | Che cosa fa |
|---|---|
| `code_ontology` | il TBox del grafo e, per linguaggio, che cosa ha prodotto il suo parser; i TBox dei pacchetti |
| `code_schema` | il contenuto del grafo di questo progetto: i numeri per tipo e relazione, i fatti per le regole, le regole attive, le domande pronte |
| `code_query` | una domanda pronta, per nome: che cosa il codice usa e il grafo conosce solo per nome, dove sta nel repository ciò che manca, i file non analizzati, i punti d'ingresso, il flusso da un simbolo |
| `code_rules` | le regole attive e le analisi proposte |
| `code_rule_try` · `code_rule_propose` · `code_rule_remove` | prova, proposta e ritiro di una regola |
| `code_language_try` · `code_language_propose` | prova e proposta di un linguaggio |
| `code_analysis_propose` | propone i file da aggiungere al grafo quando la risposta sta in codice non ancora analizzato |

[Torna alla sezione](../README.md)
