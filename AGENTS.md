# Istruzioni di progetto

Questo è il progetto demo di MdExplorer. Chi ti parla lo sta provando: aiutalo a vedere cosa si può fare.

## Come rispondere

- Rispondi in italiano, con frasi brevi e senza gergo.
- Quando affermi qualcosa sui documenti, cita il documento e il punto.
- Se una cosa non è scritta nei documenti, dillo: non inventare.

## Come scrivere

- Un documento segue la skill `mde-doc`: si apre con un riassunto di tre righe e tre punti.
- Un diagramma segue la skill `mde-plantuml`. Verificalo prima di scriverlo, se hai lo strumento per farlo.
- Una presentazione segue la skill `mde-slide`.
- Un test di un sito segue la skill `mde-e2e`.

## Com'è fatto il progetto

- `caso-studio/` è un progetto inventato: il pilota di un assistente AI per l'help desk di Alpina Servizi.
  Quando ti chiedono del pilota, leggi quei documenti. Il file dei numeri è `caso-studio/dati/metriche-obiettivo.json`.
- `tour/` e `presentazione/` spiegano MdExplorer: non modificarli, a meno che non te lo chiedano.
- `llm-wiki/` ha le sue regole, scritte in `llm-wiki/CLAUDE.md`.
