---
title: Sintassi markdown + esempi runnable
order: 2
---

# 📝 Markdown + esempi runnable

Markdown è una sintassi semplice per documenti formattati. MdExplorer aggiunge alcune funzionalità extra che non trovi negli editor classici.

## Le basi che già conosci

```markdown
# Titolo H1
## Titolo H2

**grassetto** _corsivo_ ~~barrato~~

- elenco puntato
- secondo punto
  - annidato

1. elenco numerato
2. secondo

[link a un sito](https://example.com)
![immagine](path/to/image.png)

> citazione su più righe
```

## Tabelle

| Feature | MDE | Editor classico |
|---|---|---|
| Cross-reference | ✅ navigazione interna | ❌ apre browser |
| PlantUML | ✅ rendering live | ⚠️ solo preview testo |
| Runnable code | ✅ ▶ esegue inline | ❌ |
| Indicizzazione AI | ✅ embeddings su file salvato | ❌ |

## ⚡ Runnable code blocks

Questa è una feature MdExplorer-specifica. Premi il pulsante **▶ Run** che appare in alto a destra del blocco:

```bash
echo "Ciao da MDE!"
date
```

```pwsh
Write-Host "PowerShell da Mark" -ForegroundColor Cyan
Get-Date
```

> ⚠️ Per motivi di sicurezza, devi **abilitare l'esecuzione** per il progetto la prima volta — MdExplorer ti chiede conferma.

## Front-matter YAML

Hai notato l'header in cima a questo file?

```yaml
---
title: Sintassi markdown + esempi runnable
order: 2
---
```

MdExplorer lo legge per ordinare i file e mostrare il titolo descrittivo invece del nome file.

---

**Avanti**: [Schema architetturale](docs/architecture.md) | **Indietro**: [Primi passi](01-getting-started.md) | **Home**: [README](README.md)
