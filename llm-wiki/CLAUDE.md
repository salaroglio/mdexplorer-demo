# LLM Wiki — Schema (CLAUDE.md)

This file is the **schema** of the wiki: it defines the rules that every AI agent (Claude Code, GitHub Copilot, opencode) **must follow** when it updates the wiki. It is the contract between the human and the LLM.

> ⚠️ This is a demonstration example. Adapt it to your own domain.

## 🎯 Mission of the wiki

Build **compounding** knowledge about a specific domain (here: knowledge management patterns with AI).
Every useful answer becomes a new page or updates existing pages, **so that the wiki grows** in quality over time instead of answering from the raw documents from scratch every time.

## 📂 Folder structure

| Folder | Contains | Naming |
|---|---|---|
| `sources/` | Summaries of raw documents (1 file per source) | `YYYY-MM-short-title.md` |
| `entities/` | Entity pages (people, products, organizations) | `first-name-last-name.md` or `product-name.md` (kebab-case) |
| `concepts/` | Concept pages (ideas, patterns, techniques) | `concept-name.md` (kebab-case) |
| `diagrams/` | PlantUML diagrams that illustrate the domain | `description-type.md` |
| `index.md` | Browsable catalogue, one line per page, grouped by category | (single file) |
| `log.md` | Append-only journal of all operations | (single file) |

## 🧾 Rules for page files

Every page (`sources/`, `entities/`, `concepts/`) **must have**:

1. **YAML front matter** with the fields: `title`, `kind` (`source`/`entity`/`concept`), `tags` (list), `last_updated` (ISO date)
2. **A "Summary" section** at the top — 2-4 lines that explain what the thing is
3. **A "Key points" section** — a bullet list of independent statements, each with `[source: source-id#anchor]`
4. **A "See also" section** — links to related entities and concepts (`[[entities/name]]` or `[concepts/name](concepts/name.md)`)
5. **A "History" footer** — append-only list of changes (date + one line of description)

## 🛠️ Workflow: ingest of a new source

When the human adds a new document to `sources/raw/` (PDF file, link, transcript):

1. Create `sources/YYYY-MM-title.md` with the summary (3-5 paragraphs at most)
2. Identify the **new or updated entities** → create/update `entities/*.md`
3. Identify the **new or updated concepts** → create/update `concepts/*.md`
4. Add all the touched pages to `index.md` (under the right category)
5. Append one line to `log.md`:
   `[YYYY-MM-DD HH:MM] INGEST sources/<id> → touched: <file list>`
6. If you find a **contradiction** with existing pages, do NOT overwrite: add a note
   `> ⚠️ Contradiction with [page X]: ...` and log it in `log.md` as `CONFLICT`
7. Show the human a **short diff** of the touched files and wait for approval before committing

## 🔍 Workflow: answering a question

When the human asks a question:

1. Read `index.md` (it is the TOC of the wiki)
2. Identify **2-5 candidate pages** for the answer
3. Read the candidate pages **in full** (do not split them into chunks unless necessary)
4. Synthesize an answer with **inline citations** such as `[entities/karpathy.md]`
5. If the answer is **non-trivial and reusable**, propose to the human:
   - "Do you want me to save it as a concept page in `concepts/...`?"
   - If yes: write the page, update `index.md`, log `QUERY → SAVED concepts/<id>`
6. If the answer is NOT complete with the current wiki, log `GAP: <description>` in `log.md` for future research

## 🧪 Periodic lint (weekly)

Once a week the human runs a **lint** on the wiki. The LLM must:

1. Find **orphan pages** (not linked from anywhere) → suggest where to link them
2. Find **broken links** (they point to files that do not exist)
3. Find unresolved **contradictions** between pages
4. Find **claims without a source** (bullets without `[source: ...]`)
5. Suggest **missing pages** (entities mentioned many times but without a dedicated page)
6. Output: a markdown report in `log.md` under the section `# Lint YYYY-MM-DD`

## 🎨 Writing style

- **English**, short sentences, paragraphs <5 lines
- **Encyclopedic** tone (informative, not promotional)
- **No first person** ("I", "we") in entity/concept pages
- **First person allowed** in `log.md` (the LLM is the narrator of the log)
- **Always cite**: every non-trivial claim has `[source: ...]`

## 🚫 What NOT to do

- Do not delete content in `sources/raw/` (it is **immutable**)
- Do not change `log.md` except by appending (never edit old lines)
- Do not invent sources — if you have no source, write `[source: TODO]` and log it in `log.md`
- Do not create new folders without updating this `CLAUDE.md` first

---

*Schema version 1.0 — 2026-05-10. When you update this file, append one line to `log.md`: `SCHEMA-UPDATE: <description>`.*
