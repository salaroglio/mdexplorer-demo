---
title: Word, PDF and site
---

# Word, PDF and site

## TL;DR

Markdown is the working format, but whoever receives the result often wants a file they know. MdExplorer
produces a Word document from a document, and a PDF or a site from a presentation. The markdown file stays
the only source: the delivery formats are regenerated when needed.

- A document becomes **Word**, with the company's template.
- A presentation becomes a **PDF**, one page per slide.
- A presentation becomes a **site** in a zip, with everything its links reach.

## From a document to Word

1. Open [the requirements of the case study](../case-study/01-goals-and-requirements.md).
2. In the bar of the document press "export in word".
3. MdExplorer answers "Export request queued!". When the file is ready a notice appears
   with the "Open folder" button.

For a whole folder: right click on the folder, then "Export folder to Word".

The template is chosen per document: right click on the document, "document settings",
"Microsoft Word Templates". The templates are in the `.md/templates/word/` folder of the project.

## From a presentation to PDF

1. Open [the committee presentation](../case-study/committee-slides.md).
2. In the bar press "Export the slides to PDF" and choose where to save.

The PDF has one page per slide, with the backgrounds.

## From a presentation to a site

1. Open [the MdExplorer presentation](../presentation/mdexplorer.md).
2. In the bar press "Export to HTML".
3. You get a zip. Unzip it and open `index.html`: it works without MdExplorer.

The zip holds the presentation and everything its links reach: the other presentations, the documents,
the HTML pages, the images. Diagrams stay interactive. The report `_mde/resoconto.html` inside the zip says
what was included and what was not.

It is the way to leave someone the material of a meeting without asking them to install anything.

## What you need

- For Word: Pandoc, which the installation checks at startup, and Word to open the result.
- For PDF and site: nothing else.

Next: [Git without the terminal](06-git.md) · Back: [Presentations](04-presentations.md) · [Back to the start](../README.md)
