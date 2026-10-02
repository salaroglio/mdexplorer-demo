---
title: Living documents
---

# Living documents

## TL;DR

An MdExplorer document is a markdown file that does more than what is written in it. It shows the real
files of the project, draws them, runs them, and lets you correct it right where you read it. On this page
every paragraph is something to try with your own hands.

- Files are **included**, not copied: the document stays aligned on its own.
- A command written in the page **runs** from the page.
- Text is corrected with a **right click**, without opening an editor.

## Moving around

- A click on a link opens the other document here inside: try with [the diagrams](02-diagrams.md).
- The **←** and **→** arrows of the blue bar at the top take you back where you were.
- The search box at the top searches names, links and, in the "Content" tab, inside the text.
- The "TOC" tab on the right opens the index of the page.

## A real file inside the document

This box is not a copy: it is the file `examples/project.yaml`, read right now.
In the markdown it is an empty code block, whose language is `text(./examples/project.yaml)`.

```text(./examples/project.yaml)
```

Change the file and reload the page: the box changes with it.

## A data file that becomes a drawing

The same principle, but the file is drawn. Here the language of the block is
`plantuml(@yaml, ./examples/project.yaml)`.

```plantuml(@yaml, ./examples/project.yaml)
#highlight "phases"
```

A click on a box lights up its connections. Ctrl and the wheel zoom in.

## An HTML page, as a preview

In the same way you include an HTML page: the document shows it in two tabs, "Preview" and
"Source". The language of the block is `html(path)`. You find it at work in the
[architecture of the case study](../case-study/02-architecture.md), with the prototype of a screen.

## A command that runs from the page

Press **▶ Run** at the top right of the block. The first time, MdExplorer asks permission for this
project: tick "Enable execution in this project" and press "Enable & Run".

```bash
echo "Markdown documents in this project:"
find . -name "*.md" -not -path "./.md/*" | wc -l
```

The command starts from the project folder and the output appears below.

## Correcting the text where you read it

The sentence below has a typo. Right click on the sentence, then "✏️ Edit text".
Enter or a click outside save, Esc cancels.

> This sentence has a tipo to correct.

The correction ends up in the markdown file, and the "Changes" tab of the left panel shows it.

## Pasting an image at the right place

Copy a screenshot, then right click on a paragraph and "📋 Paste image here", or Ctrl+V with the
pointer on the spot. "Annotate Screenshot" opens, where you can crop and draw before saving.

## What you need

Nothing besides MdExplorer. Diagrams need Java, which the installation checks at startup.

Next: [Diagrams that answer](02-diagrams.md) · [Back to the start](../README.md)
