---
title: Il grafo del codice
---

# Il grafo del codice

## TL;DR

MdExplorer legge il codice di un programma e ne fa un **grafo**: classi, metodi, chi chiama chi, chi implementa cosa,
con la riga e con quanto è sicuro di ogni relazione. Il grafo si guarda, si legge in un report e, soprattutto, lo
interroga **Mark**, l'agente AI, che così risponde sul codice con fatti e non a memoria. Questa sezione te lo fa provare
su un programma piccolo, scritto apposta.

- Cinque prove, in ordine, mezz'ora in tutto: segni una cartella, guardi il grafo, fai domande, fai scrivere le descrizioni, committi.
- Il programma è in **C#** e non chiede niente da installare: lo legge il compilatore che MdExplorer si porta dietro.
- Per le prove 3 e 4 serve un motore AI configurato per il progetto (GitHub Copilot, Claude Code o opencode).

## Il caso

Il [caso di studio](../caso-studio/README.md) racconta il pilota di un assistente AI per l'help desk di Alpina Servizi.
Qui c'è il **programma** di quel pilota, in piccolo: quindici file C# in [esempio/](esempio/README.md). Un ticket
arriva, l'assistente propone una risposta cercando nelle FAQ, un operatore la conferma o passa il ticket a un
collega, e le metriche contano quanti ticket si chiudono al primo contatto. Due interfacce con due implementazioni
ciascuna, una soglia che decide, un numero che il comitato vuole vedere: abbastanza per fare domande vere.

## La presentazione

- [Il codice, spiegato dal codice](presentazione/grafo-del-codice.md): l'idea e come funziona, in quindici slide.

## Per chi vuole capire cosa c'è sotto

- [Come funziona](guida/come-funziona.md). I due tempi, il parser e Mark; cosa c'è nel grafo; perché ogni relazione ha un
  grado di fiducia; cosa va su Git e cosa no; cosa il grafo non sa ancora.
- [Le domande che Mark sa fare](guida/le-domande-di-mark.md). I sette strumenti del grafo, con una domanda d'esempio per ciascuno.
- [Nota tecnica: Fuseki, Java e le grammatiche](guida/nota-tecnica.md). Cosa serve sul computer, dove finiscono i dati, quanto costa.

## Il percorso

| # | Pagina | Cosa provi | Tempo |
|---|---|---|---|
| 1 | [Segna la cartella](prove/01-segna-la-cartella.md) | la cartella diventa «ambiente di sviluppo», scegli il linguaggio, parte l'analisi | 3 min |
| 2 | [Guarda il grafo](prove/02-guarda-il-grafo.md) | la pagina del grafo, file per file e simbolo per simbolo, e il report | 5 min |
| 3 | [Chiedi a Mark](prove/03-chiedi-a-mark.md) | chi implementa, chi chiama, cosa cambia se tocco una soglia: Mark risponde con il grafo | 8 min |
| 4 | [Fai scrivere le descrizioni](prove/04-descrivi-il-codice.md) | Mark descrive ogni simbolo e i parametri; poi cerchi per significato | 8 min |
| 5 | [Il grafo va su Git](prove/05-il-grafo-va-su-git.md) | gli script nel progetto, il commit, cosa trova un collega | 5 min |

## Prima di cominciare

- Apri questo progetto in MdExplorer. La strada più semplice è **«Crea progetto demo»** dalla guida di Mark.
- Serve **Java 21** o più recente: lo stesso Java di PlantUML. MdExplorer lo controlla all'avvio e, se manca, ti dice dove prenderlo.
- Il motore AI si sceglie **una volta per progetto** nelle impostazioni del progetto, riquadro «Ambiente agentico»
  (vedi [MarkAgent nel tour](../tour/03-markagent.md)). Senza, le prove 1, 2 e 5 funzionano lo stesso.
- Le prove scrivono file nel progetto (`.development.yml`, `.mde-code/`): li vedi nella scheda «Differenze», e la prova 5 te li fa committare.

## Cosa non vedrai qui

Il grafo di un programma grande (MdExplorer è stato provato su PlantUML, 3.662 file Java), gli altri linguaggi
(TypeScript, JavaScript, Python, Java, con una grammatica scaricata al primo uso) e il passo successivo, che è decidere
quali relazioni del grafo sono conoscenza e quali rumore. Le [guide](guida/come-funziona.md) ne parlano; il resto si mostra dal vivo.

[Torna all'inizio](../README.md)
