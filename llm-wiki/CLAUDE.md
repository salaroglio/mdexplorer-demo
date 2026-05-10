# LLM Wiki — Schema (CLAUDE.md)

Questo file è lo **schema** del wiki: definisce le regole che ogni agente AI (Claude, Copilot, Gemini, locale) **deve seguire** quando aggiorna il wiki. È il contratto tra umano e LLM.

> ⚠️ Questo è un esempio dimostrativo. Adattalo al tuo dominio.

## 🎯 Mission del wiki

Costruire una conoscenza **compoundente** su un dominio specifico (qui: pattern di knowledge management con AI).
Ogni risposta utile diventa una nuova pagina o aggiorna pagine esistenti, **in modo che il wiki cresca** in qualità nel tempo invece di rispondere ogni volta da zero ai documenti grezzi.

## 📂 Struttura delle cartelle

| Cartella | Contiene | Naming |
|---|---|---|
| `sources/` | Riassunti di documenti grezzi (1 file per source) | `YYYY-MM-titolo-breve.md` |
| `entities/` | Pagine entità (persone, prodotti, organizzazioni) | `nome-cognome.md` o `nome-prodotto.md` (kebab-case) |
| `concepts/` | Pagine concetto (idee, pattern, tecniche) | `nome-concetto.md` (kebab-case) |
| `diagrams/` | Diagrammi PlantUML che illustrano il dominio | `descrizione-tipo.md` |
| `index.md` | Catalogo navigabile, una riga per pagina, raggruppato per categoria | (file unico) |
| `log.md` | Diario append-only di tutte le operazioni | (file unico) |

## 🧾 Regole per i file di pagina

Ogni pagina (`sources/`, `entities/`, `concepts/`) **deve avere**:

1. **Front-matter YAML** con campi: `title`, `kind` (`source`/`entity`/`concept`), `tags` (lista), `last_updated` (ISO date)
2. **Sezione "Sintesi"** in apertura — 2-4 righe che spiegano cosa è la cosa
3. **Sezione "Punti chiave"** — bullet list di affermazioni indipendenti, ognuna con `[fonte: source-id#anchor]`
4. **Sezione "Vedi anche"** — link a entità e concetti correlati (`[[entities/nome]]` o `[concepts/nome](concepts/nome.md)`)
5. **Footer "Storico"** — append-only delle modifiche (data + riga di descrizione)

## 🛠️ Workflow: ingest di una nuova source

Quando l'umano aggiunge un documento nuovo a `sources/raw/` (file PDF, link, transcript):

1. Crea `sources/YYYY-MM-titolo.md` con il riassunto (3-5 paragrafi max)
2. Identifica le **entità nuove o aggiornate** → crea/aggiorna `entities/*.md`
3. Identifica i **concetti nuovi o aggiornati** → crea/aggiorna `concepts/*.md`
4. Aggiungi tutte le pagine toccate a `index.md` (sotto la categoria giusta)
5. Append una riga in `log.md`:
   `[YYYY-MM-DD HH:MM] INGEST sources/<id> → touched: <lista file>`
6. Se trovi una **contraddizione** con pagine esistenti, NON sovrascrivere: aggiungi una nota
   `> ⚠️ Contraddizione con [pagina X]: ...` e logga in `log.md` come `CONFLICT`
7. Mostra all'umano un **diff sintetico** dei file toccati e attendi approvazione prima di committare

## 🔍 Workflow: rispondere a una domanda

Quando l'umano fa una domanda:

1. Leggi `index.md` (è il TOC del wiki)
2. Identifica **2-5 pagine candidate** per la risposta
3. Leggi le pagine candidate **per intero** (non spezzettare in chunk se non necessario)
4. Sintetizza una risposta con **citazioni inline** del tipo `[entities/karpathy.md]`
5. Se la risposta è **non banale e riusabile**, proponi all'umano:
   - "Vuoi che la salvi come pagina concept in `concepts/...`?"
   - Se sì: scrivi la pagina, aggiorna `index.md`, logga `QUERY → SAVED concepts/<id>`
6. Se la risposta NON è completa con il wiki attuale, logga `GAP: <descrizione>` in `log.md` per ricerche future

## 🧪 Lint periodico (settimanale)

Una volta a settimana l'umano lancia un **lint** sul wiki. L'LLM deve:

1. Trovare **pagine orfane** (non linkate da nessuno) → suggerire dove linkarle
2. Trovare **link rotti** (puntano a file inesistenti)
3. Trovare **contraddizioni** non risolte tra pagine
4. Trovare **claim senza fonte** (bullet senza `[fonte: ...]`)
5. Suggerire **pagine mancanti** (entità menzionate molte volte ma senza pagina dedicata)
6. Output: report markdown in `log.md` sotto sezione `# Lint YYYY-MM-DD`

## 🎨 Stile di scrittura

- **Italiano**, frasi brevi, paragrafi <5 righe
- Tono **enciclopedico** (informativo, non promozionale)
- **Niente prima persona** ("io", "noi") nelle pagine entità/concetti
- **Sì prima persona** in `log.md` (l'LLM è il narratore del log)
- **Sempre citare**: ogni claim non banale ha `[fonte: ...]`

## 🚫 Cosa NON fare

- Non cancellare contenuto in `sources/raw/` (sono **immutabili**)
- Non modificare `log.md` se non in append (mai editare righe vecchie)
- Non inventare fonti — se non hai una fonte, scrivi `[fonte: TODO]` e logga in `log.md`
- Non creare nuove cartelle senza prima aggiornare questo `CLAUDE.md`

---

*Schema versione 1.0 — 2026-05-10. Quando aggiorni questo file, append una riga in `log.md`: `SCHEMA-UPDATE: <descrizione>`.*
