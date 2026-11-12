---
name: plsql-pacchetto
description: "Mettere a punto il pacchetto del linguaggio PL/SQL (Oracle: package, procedure, funzioni, trigger, tabelle, viste, tipi; file .sql, .pks, .pkb, .pck, .spc, .bdy, .prc, .fnc, .trg, .vw, .tps) sui sorgenti veri e scrivere la rilevazione da riportare a chi mantiene il pacchetto. Usala quando l'utente chiede di analizzare il codice del database, di provare o migliorare il pacchetto PL/SQL, di capire quali procedure chiama il codice C# o Visual Basic e quali tabelle tocca, o di preparare la rilevazione o lo zip del pacchetto. Parole che la attivano: PL/SQL, Oracle, package body, stored procedure, trigger, schema del database, rilevazione PL/SQL, migliora il pacchetto PL/SQL, esporta il pacchetto PL/SQL."
---

# Mettere a punto il pacchetto PL/SQL sui sorgenti veri

Il pacchetto (`.mde-languages/plsql/language.yml`) è stato scritto **senza vedere il codice di questo progetto**: solo
dalla sintassi pubblica di Oracle e da sorgenti finti. Chi lo mantiene non può guardare questo codice. Tu sì: qui lo
provi sui sorgenti veri, lo correggi, e scrivi una **rilevazione** che viaggia dentro il pacchetto. Poi l'utente la manda a
chi mantiene il pacchetto con «Invia diagnostica» (regole corrette e rilevazione insieme), oppure esporta il pacchetto in
uno zip («Esporta…» sulla riga PL/SQL nella finestra «Ambiente di sviluppo»).

Prima di cominciare chiama `code_ontology`: in `languagePackages` c'è il TBox di questo pacchetto, cioè quali tipi di
simbolo e quali relazioni producono le sue regole, ciascuna con la regola da cui nasce.

## Regole

- **Non modificare mai i sorgenti, non eseguire niente sul database.** Sulle radici remote solo `remote_grep`,
  `remote_read`, `remote_list`.
- **Nella rilevazione non entra niente del cliente**: niente testo di query, nomi di schemi, tabelle, package o procedure,
  utenti, password, stringhe di connessione, nomi di clienti o di persone. Descrivi le **forme** (anche con
  un'espressione regolare) e i **numeri**. Al posto dei nomi metti segnaposto (`PKG_1.PROC_1`, `SCHEMA_1.TABELLA_1`),
  tenendo ciò che della forma conta: lo schema davanti, le virgolette, `$` e `#` nei nomi, il collegamento `@db`.
- **Ogni cambio alle regole si misura prima** con `code_language_try` (non scrive niente) e arriva all'utente con
  `code_language_propose`: le regole le scrive MdExplorer dopo il suo sì, tu non scrivi `language.yml`. A ogni proposta
  alza `version:` di uno. Non togliere `database: true`: è ciò che collega il codice C# e Visual Basic a questi simboli.
- Un cambio alla volta: prima e dopo, gli stessi numeri a confronto.
- Le espressioni regolari sono .NET; il pacchetto ha `ignoreCase: true`. Le regole leggono **righe**: una regola vede una
  riga (e, con `after:`, quella prima).

## Come le regole leggono il PL/SQL

| Nel sorgente | Nel grafo |
|---|---|
| il file | il modulo |
| `CREATE PACKAGE X` (specifica) | interfaccia `X`, con le procedure e funzioni che dichiara (`X.P`: la firma) |
| `CREATE PACKAGE BODY X` | classe `X` |
| `PROCEDURE P` / `FUNCTION F` nel corpo | funzione `X.P` (firma `PROCEDURE P`) |
| `CREATE PROCEDURE` / `CREATE FUNCTION` da sole | funzione |
| `CREATE TRIGGER T` | funzione (firma `TRIGGER T`), `references` verso la tabella dopo `ON` |
| `CREATE TABLE T` | record `T` |
| `CREATE VIEW V` | tipo `V`, fino al primo `;` a fine riga o alla `/` da sola su una riga |
| `CREATE TYPE T` (`.tps`) | tipo `T` (i suoi attributi e metodi no) |
| `FROM` / `JOIN` | `reads` verso la tabella o la vista |
| `INSERT INTO`, `UPDATE` (a inizio riga), `DELETE FROM`, `MERGE INTO`, `TRUNCATE TABLE` | `writes` |
| `PKG.PROC(…)`, `PKG.PROC;` | `calls` (i package di Oracle `DBMS_`, `UTL_`, `OWA`, `HTP`, `APEX` restano fuori) |
| `PROC(…)`, `PROC;` nello stesso file | `calls` |

Una tabella o una procedura che il grafo non ha (lo schema non è fra i file analizzati) è un nodo esterno. Se di un package
ci sono specifica e corpo, chi chiama `X.P` arriva alla procedura del corpo; se c'è solo la specifica, alla firma. Dentro
il corpo di una procedura il pacchetto legge solo tre cose: le chiamate, le tabelle lette, le tabelle scritte. Variabili,
cursori, condizioni e testo delle query non diventano nodi: li trovi nel sorgente e nelle descrizioni di Mark.

### Le carenze già note, da misurare per prime

Chi mantiene il pacchetto le conosce ma non sa quanto pesano qui. Contale (passo 2) e mettile nella rilevazione con i
numeri, prima di proporre correzioni:

- **Package con la sola specifica**: quanti `.pks` (o `.spc`) senza il corpo corrispondente. Le loro procedure sono solo
  firme: niente chiamate né tabelle. Il corpo sta altrove (nel database, in un altro repository)?
- **Cursori dichiarati a livello di package** (fuori dalle procedure) e usati da una procedura con `OPEN c`, `FETCH c`,
  `FOR r IN c`: la tabella che il cursore legge finisce sul package, non sulla procedura che lo usa.
- **SQL in una stringa**: `EXECUTE IMMEDIATE`, `OPEN … FOR 'SELECT …'`, `DBMS_SQL`: il pacchetto non guarda dentro le
  stringhe del PL/SQL, quindi quelle tabelle e procedure mancano.
- **`END;` senza nome** a chiudere procedure e funzioni (vedi il passo 2.2), blocchi `BEGIN … END;` dentro un trigger.
- **Commenti `/* … */`** su più righe che contengono SQL o nomi di procedure.

## 1. Dove sono i sorgenti del database

Trova le cartelle con file `.sql`, `.pks`, `.pkb`, `.pck`, `.pls`, `.plb`, `.prc`, `.fnc`, `.trg`, `.vw`, `.tab` (e
altre estensioni che il progetto usa per il PL/SQL: cercale con `remote_grep` su `CREATE OR REPLACE`). Devono stare in una
cartella analizzata dal grafo (una cartella `program` o una radice di codice): se `code_language_try` risponde che non
trova file, dillo all'utente e fermati finché non l'ha collegata.

Conta: file per estensione e per cartella; quanti script di installazione o di migrazione (molte istruzioni diverse in
un file) contro file di un oggetto solo.

## 2. Il censimento delle forme

Con `remote_grep` (conta i file e le occorrenze, non copiare il contenuto):

1. **Oggetti**: quanti `CREATE … PACKAGE`, `PACKAGE BODY`, `PROCEDURE`, `FUNCTION`, `TRIGGER`, `TABLE`, `VIEW`,
   `SEQUENCE`, `TYPE`, `TYPE BODY`, `SYNONYM`; con o senza `OR REPLACE`, `EDITIONABLE`, lo schema davanti, le
   virgolette; per estensione di file (`.prc`, `.pks`, `.fnc`, `.trg`, `.vw`, `.tps`, `.sql`…), e se ci sono estensioni
   che il pacchetto non conosce.
   Per i `.sql`: quanti contengono un oggetto solo e quanti sono script di installazione o di migrazione con molte
   istruzioni, e quanti oggetti sono creati più di una volta (MdExplorer avvisa «già dichiarato»).
2. **La fine dei sottoprogrammi** — il punto più delicato. Quante procedure e funzioni finiscono con `END nome;` e quante
   con `END;` senza nome. Con `END;` la regola non sa dove finiscono: la procedura resta aperta fino al prossimo `END`
   con un nome, e prende le righe della successiva.
3. **Intestazioni su più righe**: `PROCEDURE X(` con i parametri sulle righe dopo; `IS`/`AS` su una riga a sé.
4. **Commenti `/* … */`** su più righe, e quante volte contengono SQL o nomi di procedure (le regole li leggerebbero).
5. **SQL dinamico**: `EXECUTE IMMEDIATE`, `OPEN … FOR` con una stringa, `DBMS_SQL`; quante volte il nome della tabella
   o della procedura è costruito a pezzi.
6. **Chiamate**: quante con il package davanti, quante con lo schema e il package (`SCHEMA.PKG.PROC`), quante attraverso
   un collegamento (`@db`), quante a un sinonimo.
7. **Tabelle**: `FROM` su più righe (`FROM` da solo e la tabella sotto), elenchi `FROM A, B`, sottoquery,
   `UPDATE` con la tabella sulla riga dopo, `INSERT ALL`.
8. **Package di Oracle** usati (`DBMS_OUTPUT`, `UTL_FILE`, `DBMS_LOB`…): quali e quanto.

## 3. La prova delle regole

1. Leggi `.mde-languages/plsql/language.yml` e passalo com'è a `code_language_try`.
2. Annota: file letti, `symbolsByKind`, `edgesByRelation`, bersagli esterni, `warnings` (i blocchi «non si chiude» sono
   il segno delle procedure finite con `END;`), `accepted`, `rejectReasons`.
3. **Apri ogni file del campione** (`sample`) e controlla i fatti uno per uno: ogni procedura c'è e finisce alla riga
   giusta? Le tabelle lette e scritte sono quelle delle istruzioni, o la regola ha preso per tabella una parola qualunque
   dopo `FROM` (`EXTRACT(YEAR FROM data)`)? Le chiamate vanno alla procedura giusta?
4. Guarda che cosa NON si è risolto: le procedure chiamate che restano esterne (un package non analizzato? un sinonimo?),
   le tabelle esterne (lo script delle tabelle è nel perimetro?).

## 4. Correggere le regole

Per ogni difetto trovato, dal più frequente:

1. Scrivi la correzione e misurala con `code_language_try`: i numeri di prima e di dopo, 3-5 punti (`percorso:riga`)
   aperti e controllati.
2. Proponila con `code_language_propose` (`version` alzata di uno, `problem` in parole semplici, un `sampleChecks` per
   ogni file del campione). Di' all'utente che la proposta lo aspetta nella scheda di MarkAgent.
3. Quello che le regole a righe non possono leggere (un `END;` che non si distingue da quello di un blocco interno, SQL
   costruito a pezzi, intestazioni spezzate) non forzarlo: va nella rilevazione, sezione 4.

## 5. Il codice che chiama il database

Il collegamento dal codice C# o Visual Basic alle procedure e alle tabelle di questo pacchetto MdExplorer lo fa da solo,
quando l'SQL è scritto nel codice. Verificalo, non darlo per buono:

1. `code_query` o `code_neighbors` su qualche procedura: chi la chiama dal codice? Le frecce arrivano?
2. Cerca nel codice C# e Visual Basic le forme che il collegamento non vede: il nome della procedura assegnato a
   `CommandText` con `CommandType.StoredProcedure` (una regola `owner.from: symbol` della skill del grafo lo collega),
   nomi costruiti a pezzi, chiamate attraverso un livello di accesso ai dati generico (un metodo che riceve il nome).
3. Conta per forma, con un'espressione regolare che la riconosce.

## 6. La rilevazione

Scrivi `.mde-languages/plsql/findings/rilevazione-AAAA-MM-GG.md` (crea la cartella `findings/` se manca; solo file `.md`
lì dentro), con la convenzione dei documenti di MdExplorer (TL;DR in testa):

1. **Perimetro**: file per estensione, oggetti per tipo.
2. **Censimento**: i numeri del passo 2, in tabella.
3. **Prova delle regole**: i numeri di `code_language_try` all'inizio e alla fine; le correzioni fatte, una per una (la
   regola YAML, il motivo, prima/dopo, i punti controllati come `percorso:riga` senza copiare il contenuto).
4. **Quello che le regole non leggono**: per ogni forma, quante volte compare, perché sfugge, e uno **scheletro** di 5-15
   righe con le parole di PL/SQL vere e i nomi sostituiti da segnaposto.
5. **Il codice che chiama il database**: le forme del passo 5, con numeri ed espressioni regolari.
6. **Domande aperte** per chi mantiene il pacchetto.

Rileggi la rilevazione prima di chiudere: se c'è un nome vero, una query o una stringa di connessione, toglili.

Poi di' all'utente come farla arrivare a chi mantiene il pacchetto, in uno dei due modi:

- **«Invia diagnostica»** (nella lista dei progetti): spuntare «Allega le rilevazioni di MarkAgent», controllare
  l'anteprima, inviare. Parte il pacchetto PL/SQL intero (regole, rilevazione) insieme ai log; se la rete non lo
  permette, lì stesso c'è «Salva lo zip».
- **«Esporta…»** sulla riga PL/SQL nella finestra «Ambiente di sviluppo»: uno zip del solo pacchetto, da portare a mano.
  Se l'esportazione dice che lo zip con quella versione esiste già con un contenuto diverso, proponi un cambio di sola
  `version:`.
