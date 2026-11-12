# PL/SQL (Oracle)

Pacchetto di linguaggio per il grafo del codice di MdExplorer: package (specifica e corpo), procedure e funzioni, trigger,
tabelle, viste e tipi di Oracle (`.sql`, `.pks`, `.pkb`, `.pck`, `.spc`, `.bdy`, `.prc`, `.fnc`, `.trg`, `.vw`, `.tps`…).
Serve un MdExplorer del 12 novembre 2026 o più nuovo (`database: true`).

- `language.yml` — le regole. Con `database: true`: l'SQL scritto nel codice C# o Visual Basic che nomina una procedura o
  una tabella di questi file si ricollega a lei da solo, in qualunque ordine si analizzino le cartelle.
- `prompts/code-doc.md` — che cosa dire a Mark quando descrive il PL/SQL.
- `skills/plsql-pacchetto/` — per MarkAgent: provare le regole sui sorgenti veri, correggerle, scrivere la rilevazione.
- `tbox.ttl` — che cosa queste regole scrivono nel grafo; lo scrive MdExplorer dalle regole.
- `findings/` — le rilevazioni scritte da MarkAgent: viaggiano con il pacchetto quando lo si esporta.

Le regole di partenza sono scritte dalla sintassi pubblica di Oracle e provate su sorgenti finti: la prima cosa da fare
in un progetto è chiedere a MarkAgent «metti a punto il pacchetto PL/SQL».
