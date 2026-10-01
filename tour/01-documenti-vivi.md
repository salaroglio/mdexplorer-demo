---
title: Documenti vivi
---

# Documenti vivi

## TL;DR

Un documento di MdExplorer è un file markdown che fa più di quello che c'è scritto. Mostra i file veri del
progetto, li disegna, li esegue, e si corregge nel punto in cui lo leggi. In questa pagina ogni paragrafo è
una prova da fare con le tue mani.

- I file si **includono**, non si copiano: il documento resta allineato da solo.
- Un comando scritto nella pagina **si esegue** dalla pagina.
- Il testo si corregge con il **tasto destro**, senza aprire un editor.

## Muoversi

- Un clic su un link apre l'altro documento qui dentro: prova con [i diagrammi](02-diagrammi.md).
- Le frecce **←** e **→** della barra blu in alto riportano dove eri.
- La casella «Cerca documenti e link...» cerca nei nomi, nei link e, nella scheda «Content», dentro il testo.
- La linguetta «TOC» a destra apre l'indice della pagina.

## Un file vero dentro il documento

Questo riquadro non è una copia: è il file `esempi/progetto.yaml`, letto in questo momento.
Nel markdown è un blocco di codice vuoto, il cui linguaggio è `text(./esempi/progetto.yaml)`.

```text(./esempi/progetto.yaml)
```

Cambia il file e ricarica la pagina: il riquadro cambia con lui.

## Un file di dati che diventa un disegno

Lo stesso principio, ma il file viene disegnato. Qui il linguaggio del blocco è
`plantuml(@yaml, ./esempi/progetto.yaml)`.

```plantuml(@yaml, ./esempi/progetto.yaml)
#highlight "fasi"
```

Un clic su un riquadro accende i suoi collegamenti. Con Ctrl e la rotella si ingrandisce.

## Una pagina HTML, in anteprima

Con lo stesso sistema si include una pagina HTML: il documento la mostra in due schede, «Preview» e
«Source». Il linguaggio del blocco è `html(percorso)`. La trovi all'opera nel documento di
[architettura del caso di studio](../caso-studio/02-architettura.md), con il prototipo di una schermata.

## Un comando che si esegue dalla pagina

Premi **▶ Run** in alto a destra nel blocco. La prima volta MdExplorer chiede il permesso per questo
progetto: spunta «Enable execution in this project» e premi «Enable & Run».

```bash
echo "Documenti markdown in questo progetto:"
find . -name "*.md" -not -path "./.md/*" | wc -l
```

Il comando parte dalla cartella del progetto e l'uscita compare qui sotto.

## Correggere il testo dove lo leggi

Nella frase qui sotto c'è un errore di battitura. Tasto destro sulla frase, poi «✏️ Modifica testo».
Invio o un clic fuori salvano, Esc annulla.

> In questa frase c'è un erore da correggere.

La correzione finisce nel file markdown, e la scheda «Differenze» del pannello a sinistra la mostra.

## Incollare un'immagine nel punto giusto

Copia uno screenshot, poi tasto destro su un paragrafo e «📋 Incolla immagine qui», oppure Ctrl+V con il
puntatore sul punto. Si apre «Annota Screenshot», dove puoi ritagliare e disegnare prima di salvare.

## Cosa serve

Niente oltre a MdExplorer. Per i diagrammi serve Java, che l'installazione controlla all'avvio.

Avanti: [Diagrammi che rispondono](02-diagrammi.md) · [Torna all'inizio](../README.md)
