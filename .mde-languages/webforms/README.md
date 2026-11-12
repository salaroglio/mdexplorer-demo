# ASP.NET Web Forms

Pacchetto di linguaggio per il grafo del codice di MdExplorer: pagine (`.aspx`), controlli utente (`.ascx`) e master page
(`.master`). Serve un MdExplorer del 12 novembre 2026 o più nuovo (le chiamate `codebehind`, `handler`, `autowire`).

- `language.yml` — le regole: la pagina e la sua classe di code-behind, i controlli con i loro gestori, `Page_Load` per
  convenzione, la master page, i controlli utente, gli include.
- `prompts/code-doc.md` — che cosa dire a Mark quando descrive una pagina.
- `skills/webforms-pacchetto/` — per MarkAgent: provare le regole sulle pagine vere, correggerle, scrivere la rilevazione.
- `tbox.ttl` — che cosa queste regole scrivono nel grafo; lo scrive MdExplorer dalle regole.
- `findings/` — le rilevazioni scritte da MarkAgent: viaggiano con il pacchetto quando lo si esporta.

Il code-behind (`.aspx.vb`, `.aspx.cs` e i `.designer`) lo legge MdExplorer con Visual Basic o C#: la cartella delle pagine
va segnata anche con quel linguaggio. Le regole di partenza sono scritte dalla sintassi pubblica e provate su pagine finte:
la prima cosa da fare in un progetto è chiedere a MarkAgent «metti a punto il pacchetto Web Forms».
