# CHANGELOG

## 1.9.1 — 2026-11-14
- Prova 8, «Test scritti in italiano»: il test del sito segue il sito nuovo di MdExplorer (www.mdexplorer.net, riscritto a novembre 2026). Controlla il titolo e un testo della pagina iniziale italiana, e il passaggio dalla pagina iniziale al grafo del codice.

## 1.9.0 — 2026-11-12
- Grafo del codice: la prova 9, «Le pagine web». Le pagine ASP.NET Web Forms del programma Visual Basic (`esempio-web/`: una pagina di ricerca, una master page, un controllo utente, con il code-behind), lette dal pacchetto di linguaggio Web Forms che arriva con il progetto (`.mde-languages/webforms/`, skill `webforms-pacchetto`). La classe di code-behind è collegata alla sua pagina, ogni pulsante al metodo che risponde (`OnClick=` nella pagina, o `Handles` nel Visual Basic), la pagina al suo `Page_Load`; con la prova 8, il percorso va dal pulsante alle tabelle. Schermate da un giro vero con Claude Code. Serve MdExplorer 2026.11.11.5 o più nuovo, con le aggiunte del 12 novembre per le pagine con code-behind.

## 1.8.0 — 2026-11-12
- Grafo del codice: la prova 8, «Il codice e il database». Il database del programma Visual Basic, in PL/SQL (`esempio-db/`: tabelle, una vista, il package `PKG_RAPPORTI`, un trigger, una funzione), letto dal pacchetto di linguaggio PL/SQL v2 che arriva con il progetto (`.mde-languages/plsql/`, con `database: true` e la skill `plsql-pacchetto`). Quando il database entra nel grafo, le frecce dell'SQL scritto nel Visual Basic passano dalle tabelle e dalla procedura come nomi agli oggetti veri, e la finestra lo dice. Schermate da un giro vero con Claude Code. Serve MdExplorer 2026.11.11.5 o più nuovo, con le correzioni del 12 novembre per il PL/SQL.

## 1.7.5 — 2026-11-12
- Serve MdExplorer 2026.11.11.5 o più nuovo: è il pacchetto che porta tutto quello che le prove 6 e 7 usano.

## 1.7.4 — 2026-11-12
- Serve MdExplorer 2026.11.11.6 o più nuovo. La 1.7.3 chiedeva per errore la 2026.11.12, una versione che non esiste.

## 1.7.3 — 2026-11-12
- Grafo del codice: le prove 6 e 7 hanno le schermate, prese da un giro vero con Claude Code. La finestra «Ambiente di sviluppo» sul programma Visual Basic, la struttura estratta, e quattro risposte di Mark: le tabelle lette e scritte, l'evento, com'è fatto il grafo (dove Mark corregge da solo due sue risposte di prima), la verifica di `Archivia` sul sorgente. Serve MdExplorer 2026.11.12 o più nuovo: con le versioni di prima il file del gestore di un evento dichiarato in un altro file restava fuori dal grafo.

## 1.7.2 — 2026-11-12
- Grafo del codice: nella presentazione la slide degli strumenti di Mark passa da dieci a venti, in tre colonne: quelli che leggono il grafo, quelli che dicono com'è fatto e che cosa contiene (`code_ontology`, `code_schema`, `code_query`, `code_rules`), quelli che lo migliorano con il tuo sì (descrizioni, regole, linguaggi, file da analizzare).

## 1.7.1 — 2026-11-11
- Grafo del codice: la guida «Come Mark verifica il grafo» ha lo schema delle classi dell'ontologia del grafo, in PlantUML: la struttura scritta dal parser, i fatti per le regole, quello che scrivono Mark e le regole approvate, con i legami fra loro.

## 1.7.0 — 2026-11-11
- Grafo del codice: da cinque a sette prove. La 6 è su un secondo programma, in Visual Basic .NET (`esempio-vb/`): il file di progetto, un evento con il suo gestore, l'SQL scritto nelle stringhe con le tabelle lette e scritte e la procedura chiamata. La 7 è su Mark che verifica il grafo sul sorgente: il TBox con `code_ontology`, il metodo della skill `mde-code-check`, che cosa si corregge e chi lo fa. Una guida nuova, «Come Mark verifica il grafo»: il TBox, le regole, i linguaggi aggiunti con il loro `tbox.ttl`, le rilevazioni con «Invia diagnostica». Le prove 6 e 7 non hanno ancora schermate. Serve MdExplorer 2026.11.11 o più nuovo.

## 1.6.0 — 2026-11-05
- Il percorso passa da otto a dieci prove. La 9 è sulle issue di Redmine: dove si configura il collegamento, cosa resta nel progetto e cosa resta sul tuo computer, cosa chiedere a MarkAgent. La 10 è sul telecomando Telegram: il bot personale e il canale degli avvisi del progetto. Schermate vere, in italiano e in inglese. Serve MdExplorer 2026.11.05 o più nuovo.

## 1.5.0 — 2026-10-23
- Grafo del codice: la sezione racconta la finestra «Ambiente di sviluppo» com'è adesso. Due passi, «Estrai la struttura» (senza AI) e «Descrivi con Mark»; il modello per descrivere; la tabella con il preventivo delle domande; le descrizioni dalle foglie in su; la domanda che non riesce ferma chi dipende da lei, e «Riprendi». La pagina del grafo si apre sulla mappa delle parti. Dieci strumenti per Mark, con `code_inventory`. Schermate rifatte. Serve MdExplorer 2026.10.23 o più nuovo.

## 1.4.0 — 2026-10-19
- La presentazione nello stile di MdExplorer (tema `mde-space`): gli alieni in apertura, le orbite in chiusura, un'icona per titolo. Serve MdExplorer 2026.10.19.11 o più nuovo.
- Da questa versione l'italiano e l'inglese vanno di pari passo: la 1.3.0 era solo inglese, per questo il ramo italiano passa dalla 1.2.0 alla 1.4.0.

## 1.2.0 — 2026-10-19
- La presentazione per la vetrina di «Crea nuovo progetto» (`slides`), in italiano e in inglese: che cosa c'è nella demo e da dove partire. Serve MdExplorer 2026.10.19 o più nuovo.

## 1.1.0 — 2026-10-18
- `.development.yml`: il workflow della gara sta nell'elenco `agentCity.workflowDocs`, perché un progetto può avere più workflow. Serve un MdExplorer che conosce l'elenco; un progetto con la riga vecchia `workflowDoc` la vede convertire da sola all'apertura.

## 1.0.0 — 2026-10-18
- Prima versione come template: il progetto demo si crea da qui («Crea progetto demo») e da qui arrivano i suoi aggiornamenti.
