---
title: Dietro le quinte
document_type: slides
reveal:
  theme: white
  config:
    width: 1280
    height: 720
    slideNumber: c/t
    transition: fade
    pdfSeparateFragments: false
---

# Dietro le quinte

Come è costruito MdExplorer

Note:
Questa presentazione si apre da un link della principale. La traccia in alto a sinistra riporta alla
slide di partenza.

---

## I numeri

| Dato | Valore |
|---|---|
| Righe di codice C# | circa 150.000 |
| Righe di codice TypeScript | circa 43.000 |
| Progetti nella soluzione | 22 |
| Test automatici | più di 1.300 |
| Commit da marzo 2021 | 1.311 |
| Piani di sprint | 54 |

Misurati sul repository il 1° ottobre 2026.

---

## Sei anni, un'accelerazione

<div style="width:860px; margin:24px auto 0; font-size:26px; text-align:left">
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2021</span><span style="display:inline-block; height:30px; width:135px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">149</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2022</span><span style="display:inline-block; height:30px; width:111px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">122</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2023</span><span style="display:inline-block; height:30px; width:57px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">63</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2024</span><span style="display:inline-block; height:30px; width:85px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">94</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2025</span><span style="display:inline-block; height:30px; width:200px; background:#9aa0a6; border-radius:0 4px 4px 0"></span><span style="margin-left:12px">221</span></div>
<div style="display:flex; align-items:center; margin:8px 0"><span style="width:80px">2026</span><span style="display:inline-block; height:30px; width:600px; background:#1a73e8; border-radius:0 4px 4px 0"></span><span style="margin-left:12px"><b>662</b></span></div>
</div>

Commit per anno. Nel 2026, fino al 1° ottobre, 638 su 662 sono firmati insieme a un agente AI.

Note:
Il salto non viene da più ore di lavoro. Viene dal metodo della slide successiva.

---

## Il metodo

```plantuml
@startuml
!theme plain
scale 1.5
left to right direction
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam rectangle {
  BackgroundColor<<Centro>> #E8F0FE
  BorderColor<<Centro>> #1A73E8
}
hide stereotype

rectangle "Piano di sprint\nin markdown" as P <<Centro>>
rectangle "L'agente esegue\nuna fase" as A
rectangle "Prova nell'app\nvera" as V
rectangle "Commit" as C

P --> A
A --> V
V --> C
C --> P : il piano si aggiorna
@enduml
```

Il piano è un documento vivo: decisioni, fasi, cosa è stato provato e cosa resta.

Note:
Ogni funzione vista oggi ha il suo piano di sprint, scritto e letto dentro MdExplorer.
La persona decide e controlla, l'agente esegue e documenta.

---

## Com'è fatto

```plantuml
@startuml
!theme plain
scale 1.5
left to right direction
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam DatabaseBackgroundColor #F1F3F4
skinparam DatabaseBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam rectangle {
  BackgroundColor<<Centro>> #E8F0FE
  BorderColor<<Centro>> #1A73E8
}
hide stereotype

rectangle "Applicazione desktop\nWindows e Linux" as E
rectangle "Interfaccia\nAngular" as UI
rectangle "Servizio\n.NET 8" as S <<Centro>>
database "Indice e impostazioni\nSQLite, sul computer" as DB
rectangle "Git" as G
rectangle "Server MCP" as MCP
rectangle "Motore AI\nscelto dal progetto" as AI

E --> UI
UI --> S
S --> DB
S --> G
S --> AI
AI --> MCP
MCP --> S
@enduml
```

---

## Tre cose imparate

1. **Il piano scritto vale più della richiesta.** Un agente con un piano chiaro lavora per ore senza perdersi <!-- .element: class="fragment" -->
2. **Prima si verifica, poi si cambia.** L'agente prova nell'applicazione vera, non suppone <!-- .element: class="fragment" -->
3. **La memoria è fatta di documenti.** Ciò che l'agente impara resta scritto, e lo legge anche una persona <!-- .element: class="fragment" -->

Note:
Sono le stesse tre cose che servono a un'azienda che adotta l'AI: conoscenza scritta, verifica, regole comuni.
