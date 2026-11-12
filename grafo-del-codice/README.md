---
title: Il grafo del codice
---

# Il grafo del codice

## TL;DR

MdExplorer legge il codice di un programma e ne fa un **grafo**: classi, metodi, chi chiama chi, chi implementa cosa,
con la riga e con quanto è sicuro di ogni relazione. Il grafo si guarda, si legge in un report e, soprattutto, lo
interroga **Mark**, l'agente AI, che così risponde sul codice con fatti e non a memoria; e Mark scrive, e corregge
quando glielo chiedi, a che cosa serve ogni file e ogni metodo. Questa sezione te lo fa provare su un programma piccolo,
scritto apposta.

- Otto prove, in ordine, un'ora: le prime cinque sul programma C#, la 6 e la 7 su un programma Visual Basic con l'SQL nel codice e sulla verifica del grafo, la 8 sul suo database in PL/SQL.
- I programmi sono in **C#** e in **Visual Basic .NET** e non chiedono niente da installare: li legge il compilatore che MdExplorer si porta dietro.
- Per le prove 3 e 4 serve un motore AI configurato per il progetto (GitHub Copilot, Claude Code o opencode).

## Il caso

Il [caso di studio](../caso-studio/README.md) racconta il pilota di un assistente AI per l'help desk di Alpina Servizi.
Qui c'è il **programma** di quel pilota, in piccolo: quindici file C# in [esempio/](esempio/README.md). Un ticket
arriva, l'assistente propone una risposta cercando nelle FAQ, un operatore la conferma o passa il ticket a un
collega, e le metriche contano quanti ticket si chiudono al primo contatto. Due interfacce con due implementazioni
ciascuna, una soglia che decide, un numero che il comitato vuole vedere: abbastanza per fare domande vere.

Accanto c'è il **rapporto settimanale** dello stesso help desk, in Visual Basic, in [esempio-vb/](esempio-vb/README.md):
due file che leggono i ticket dal database, scrivono lo storico e chiudono la settimana con una procedura. E il
**database** che usa, in PL/SQL, in [esempio-db/](esempio-db/README.md): le tabelle, il package con la procedura, un
trigger; lo legge il pacchetto di linguaggio in `.mde-languages/plsql/`.

## La presentazione

- [Il codice, spiegato dal codice](presentazione/grafo-del-codice.md): l'idea e come funziona, in diciotto slide.

## Per chi vuole capire cosa c'è sotto

- [Come funziona](guida/come-funziona.md). I due tempi, il parser e Mark; cosa c'è nel grafo; perché ogni relazione ha un
  grado di fiducia; le descrizioni di Mark e chi le corregge; cosa va su Git e cosa no; cosa il grafo non sa ancora.
- [Le domande che Mark sa fare](guida/le-domande-di-mark.md). Gli strumenti per leggere il grafo, con una domanda d'esempio per ciascuno,
  e le domande dal tasto destro sul grafo.
- [Come Mark verifica il grafo](guida/come-mark-verifica-il-grafo.md). Il TBox che dice com'è fatto il grafo, la verifica
  sul sorgente, le regole, i linguaggi aggiunti con il loro TBox, le rilevazioni per chi mantiene MdExplorer.
- [Nota tecnica: Fuseki, Java e le grammatiche](guida/nota-tecnica.md). Cosa serve sul computer, dove finiscono i dati, quanto costa.

## Il percorso

| # | Pagina | Cosa provi | Tempo |
|---|---|---|---|
| 1 | [Segna la cartella](prove/01-segna-la-cartella.md) | la cartella diventa «ambiente di sviluppo», scegli il linguaggio, estrai la struttura | 3 min |
| 2 | [Guarda il grafo](prove/02-guarda-il-grafo.md) | la pagina del grafo, dai file alle chiamate in cascata, e il report | 5 min |
| 3 | [Chiedi a Mark](prove/03-chiedi-a-mark.md) | chi implementa, chi chiama, cosa cambia se tocco una soglia; e il tasto destro sul grafo | 8 min |
| 4 | [Fai descrivere il codice a Mark](prove/04-analizza-il-codice.md) | Mark scrive a che cosa serve ogni file e ogni simbolo, dalle foglie in su; tu cerchi per significato e gli fai correggere una descrizione | 10 min |
| 5 | [Il grafo va su Git](prove/05-il-grafo-va-su-git.md) | gli script nel progetto, il commit, cosa trova un collega | 5 min |
| 6 | [Visual Basic e l'SQL nel codice](prove/06-visual-basic-e-sql.md) | un programma VB, le tabelle che legge e scrive, la procedura che chiama, un evento e il suo gestore | 8 min |
| 7 | [Mark controlla il grafo](prove/07-mark-controlla-il-grafo.md) | com'è fatto il grafo, una relazione verificata sul sorgente, che cosa si corregge e chi lo fa | 10 min |
| 8 | [Il codice e il database](prove/08-il-codice-e-il-database.md) | il database in PL/SQL con il suo pacchetto di linguaggio; le frecce dal Visual Basic passano alle tabelle e alla procedura vere | 8 min |

## Prima di cominciare

- Apri questo progetto in MdExplorer. La strada più semplice è **«Crea progetto demo»** dalla guida di Mark.
- Serve **Java 21** o più recente: lo stesso Java di PlantUML. MdExplorer lo controlla all'avvio e, se manca, ti dice dove prenderlo.
- Il motore AI si sceglie **una volta per progetto** nelle impostazioni del progetto, riquadro «Ambiente agentico»
  (vedi [MarkAgent nel tour](../tour/03-markagent.md)). Senza, le prove 1, 2 e 5 funzionano lo stesso.
- Le prove scrivono file nel progetto (`.development.yml`, `.mde-code/`): li vedi nella scheda «Differenze», e la prova 5 te li fa committare.

## Cosa non vedrai qui

Il grafo di un programma grande (MdExplorer è stato provato su PlantUML, 3.662 file Java), gli altri linguaggi
(PowerShell, che come il C# non chiede niente; TypeScript, JavaScript, Python e Java, con una grammatica scaricata al
primo uso; quelli aggiunti con un pacchetto, oltre al PL/SQL della prova 8), il codice che sta fuori dal progetto (le radici esterne), una regola
proposta da Mark e approvata nel wizard, e il passo successivo, che è decidere quali relazioni del grafo sono conoscenza
e quali rumore. Le [guide](guida/come-funziona.md) ne parlano; il resto si mostra dal vivo.

[Torna all'inizio](../README.md)
