---
title: Comitato guida del 23 ottobre
document_type: slides
reveal:
  theme: white
  config:
    width: 1280
    height: 720
    slideNumber: c/t
    transition: fade
---

# Assistente AI per l'help desk

Comitato guida · 23 ottobre 2026

Note:
Presentazione di esempio del caso di studio. È un file markdown come gli altri: si corregge dalla pagina
con «Modifica» e MarkAgent può aggiungere slide leggendo i documenti della cartella.

---

## Dove siamo

- Pilota approvato il 18 settembre
- Base di conoscenza riordinata: 300 articoli
- Assistente al lavoro in ombra da una settimana

Note:
I dettagli sono nel piano del pilota. Il calendario completo è nella tabella delle fasi.

---

## Il percorso di una bozza

```plantuml
@startuml
!theme plain
scale 1.5
skinparam ActivityBackgroundColor #F1F3F4
skinparam ActivityBorderColor #5F6368
skinparam ActivityDiamondBackgroundColor #FEF7E0
skinparam ActivityDiamondBorderColor #F29900
skinparam ArrowColor #5F6368

start
:Arriva un ticket;
:Cerca le fonti;
:Scrivi la bozza;
if (Fiducia sufficiente?) then (sì)
  :Mostra la bozza all'operatore;
else (no)
  -[#D93025]->
  #FCE8E6:Non proporre niente;
endif
stop
@enduml
```

---

## Cosa decidiamo oggi

1. Passare al gruppo ristretto di operatori
2. Modello in cloud con anonimizzazione, oppure modello in azienda
3. Data del prossimo comitato

---

## Per approfondire

- [Obiettivi e requisiti](01-obiettivi-e-requisiti.md)
- [Architettura](02-architettura.md)
- [Piano del pilota](03-piano-del-pilota.md)
- [Il prototipo del pannello](mockup/pannello-operatore.html)
