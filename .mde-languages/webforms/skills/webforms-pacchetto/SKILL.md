---
name: webforms-pacchetto
description: "Mettere a punto il pacchetto del linguaggio ASP.NET Web Forms (pagine .aspx, controlli utente .ascx, master page .master, con il code-behind in Visual Basic o C#) sulle pagine vere e scrivere la rilevazione da riportare a chi mantiene il pacchetto. Usala quando l'utente chiede di analizzare le pagine web, di capire quale codice risponde a un pulsante o a una griglia, di seguire il percorso dalla pagina al database, di provare o migliorare il pacchetto Web Forms, o di preparare la rilevazione o lo zip del pacchetto. Parole che la attivano: Web Forms, aspx, ascx, master page, code-behind, OnClick, Page_Load, postback, rilevazione Web Forms, migliora il pacchetto Web Forms, esporta il pacchetto Web Forms."
---

# Mettere a punto il pacchetto Web Forms sulle pagine vere

Il pacchetto (`.mde-languages/webforms/language.yml`) è stato scritto **senza vedere le pagine di questo progetto**: solo
dalla sintassi pubblica di ASP.NET e da pagine finte. Chi lo mantiene non può guardare questo codice. Tu sì: qui lo provi
sulle pagine vere, lo correggi, e scrivi una **rilevazione** che viaggia dentro il pacchetto. Poi l'utente la manda a chi
mantiene il pacchetto con «Invia diagnostica» (regole corrette e rilevazione insieme), oppure esporta il pacchetto in uno
zip («Esporta…» sulla riga Web Forms nella finestra «Ambiente di sviluppo»).

Prima di cominciare chiama `code_ontology`: in `languagePackages` c'è il TBox di questo pacchetto.

## Regole

- **Non modificare mai le pagine né il code-behind.** Sulle radici remote solo `remote_grep`, `remote_read`, `remote_list`.
- **Nella rilevazione non entra niente del cliente**: niente nomi di pagine, controlli, classi, metodi, tabelle, testi
  dell'interfaccia, indirizzi, utenti, stringhe di connessione. Descrivi le **forme** (anche con un'espressione regolare) e
  i **numeri**, con segnaposto (`Pagina1.aspx`, `btn1`, `Classe1.Metodo1`).
- **Ogni cambio alle regole si misura prima** con `code_language_try` (non scrive niente) e arriva all'utente con
  `code_language_propose`: le regole le scrive MdExplorer dopo il suo sì, tu non scrivi `language.yml`. A ogni proposta
  alza `version:` di uno. Non cambiare i nomi delle chiamate `codebehind`, `handler`, `autowire`: sono quelli che
  MdExplorer collega al code-behind.
- Un cambio alla volta: prima e dopo, gli stessi numeri a confronto.

## Come il pacchetto legge una pagina

| Nella pagina | Nel grafo |
|---|---|
| il file `.aspx`, `.ascx`, `.master` | il modulo |
| `<%@ Page/Control/Master … Inherits="X.Y" %>` | la classe `X.Y` (Visual Basic o C#) `renders` la pagina |
| un elemento con `OnClick="metodo"` (e ogni `On…` lato server, non `OnClient…`) | un controllo che `calls` quel metodo della classe |
| `AutoEventWireup="true"` | la pagina `calls` i `Page_Load`, `Page_Init`… della classe |
| `MasterPageFile="~/…"`, `<%@ Register Src="~/…" %>`, `<!-- #include file="…" -->` | `includes` verso la master page, il controllo utente, il file |
| un elemento con un evento del browser (`onclick="…"`, `OnClientClick`) | un controllo, con le chiamate del suo JavaScript |

I gestori agganciati nel code-behind Visual Basic con `Handles btn.Click` li collega già il linguaggio Visual Basic: il
campo `WithEvents` del controllo (nel file `.designer`) porta al gestore.

### Le carenze già note, da misurare per prime

- **Classe non trovata**: `Inherits` con un nome che nel grafo non c'è (il code-behind non è in una cartella analizzata,
  il nome è diverso da quello qualificato della classe, un sito web senza progetto con `CodeFile=` invece di `CodeBehind=`).
- **Gestori agganciati nel codice C#** (`btn.Click += …` in `Page_Init` o nel `.designer`): li vede il linguaggio C#, non
  il pacchetto; controlla che le frecce arrivino.
- **Eventi dei controlli dentro i template** (`ItemTemplate` di una griglia o di un repeater): `OnCommand`, `CommandName`,
  `OnItemCommand` — il metodo che risponde dipende dal comando.
- **Navigazione fra pagine**: `Response.Redirect("X.aspx")`, `Server.Transfer`, `PostBackUrl`, `NavigateUrl`. Le stringhe
  nel code-behind il grafo le registra (punti di chiamata): una regola le può collegare alle pagine.
- **Associazione dei dati**: `DataSourceID` verso un `SqlDataSource`/`ObjectDataSource` con la query o il metodo scritti
  nella pagina (`SelectCommand`, `SelectMethod`): il pacchetto oggi non li legge.

## 1. Dove sono le pagine

Trova le cartelle con `.aspx`, `.ascx`, `.master` (`code_roots`, `remote_list`, `remote_grep`), e il code-behind accanto
(`.aspx.vb`, `.aspx.cs`, `.designer.vb`, `.designer.cs`). La cartella deve essere segnata con **due** linguaggi: Web
Forms per le pagine e Visual Basic o C# per il code-behind. Conta: pagine, controlli utente, master page; progetti
(`.vbproj`, `.csproj`) o siti web senza progetto.

## 2. Il censimento delle forme

Con `remote_grep` (conta i file e le occorrenze, non copiare il contenuto):

1. **Direttive**: `<%@ Page`, `<%@ Control`, `<%@ Master`, `<%@ Register`; con `Inherits`, `CodeBehind`, `CodeFile`;
   `AutoEventWireup="true"` e `"false"`; direttive su più righe.
2. **Eventi lato server** negli elementi: quali attributi `On…` e quante volte (`OnClick`, `OnSelectedIndexChanged`,
   `OnRowCommand`…); quanti dentro template.
3. **Gestori nel code-behind**: `Handles` (Visual Basic), `+=` (C#), metodi `Page_…`.
4. **Navigazione**: `Response.Redirect`, `Server.Transfer`, `PostBackUrl`, `NavigateUrl`, con nomi di pagina scritti o
   costruiti a pezzi.
5. **Dati**: `SqlDataSource`, `ObjectDataSource`, `DataSourceID`, `SelectCommand`, `SelectMethod`, `Eval(`, `Bind(`.
6. **Blocchi di codice nella pagina**: `<% … %>`, `<%= … %>`, `<script runat="server">`.

## 3. La prova delle regole

1. Leggi `.mde-languages/webforms/language.yml` e passalo com'è a `code_language_try`.
2. Annota: file letti, `symbolsByKind`, `edgesByRelation`, `pages` (controlli, include risolti e no, punti di chiamata),
   `warnings`, `accepted`, `rejectReasons`.
3. **Apri ogni file del campione** (`sample`) e controlla: i controlli con un evento ci sono tutti? Gli `On…` sono
   diventati chiamate `handler` con il nome giusto? La master page e i controlli utente sono inclusi?
4. Dopo l'estrazione vera (con il sì dell'utente): `code_neighbors` su qualche classe di code-behind (`renders`) e su
   qualche gestore (chi lo chiama): le frecce verso il code-behind arrivano? Quelle che non arrivano vanno nella
   rilevazione, con il motivo (classe non trovata, metodo con un altro nome, gestore agganciato nel C#).

## 4. Correggere le regole

Per ogni difetto trovato, dal più frequente: correzione misurata con `code_language_try` (numeri prima/dopo, 3-5 punti
aperti), poi `code_language_propose` (`version` alzata di uno, `problem` in parole semplici, un `sampleChecks` per ogni
file del campione). Quello che le regole non possono leggere va nella rilevazione, sezione 4.

## 5. La rilevazione

Scrivi `.mde-languages/webforms/findings/rilevazione-AAAA-MM-GG.md` (crea la cartella `findings/` se manca; solo file
`.md`), con la convenzione dei documenti di MdExplorer (TL;DR in testa):

1. **Perimetro**: pagine, controlli utente, master page; linguaggio del code-behind; progetti o siti senza progetto.
2. **Censimento**: i numeri del passo 2, in tabella.
3. **Prova delle regole**: i numeri all'inizio e alla fine; le correzioni, una per una.
4. **Quello che le regole non leggono**: per ogni forma, quante volte, perché sfugge, uno **scheletro** di 5-15 righe con i
   tag veri di ASP.NET e i nomi sostituiti da segnaposto.
5. **Le frecce verso il code-behind**: quante pagine hanno la loro classe, quanti controlli il loro gestore, e perché le
   altre no.
6. **Domande aperte** per chi mantiene il pacchetto.

Rileggi la rilevazione prima di chiudere: se c'è un nome vero, toglilo. Poi di' all'utente come farla arrivare: «Invia
diagnostica» con «Allega le rilevazioni di MarkAgent», oppure «Esporta…» sulla riga Web Forms.
