---
title: Presentations
---

# Presentations

## TL;DR

An MdExplorer presentation is a markdown file with one more line in its header. You write it like a
document, show it from the application and correct it from the slide itself. This page shows how to
present, how to edit and how to link several presentations together.

- Slides are separated by a `---` line: everything else is plain markdown.
- On the slide there is a bar: "Present", "Edit", full screen, a pen to annotate.
- A link leads to another presentation or to a document, and a trail at the top brings you back.

## The presentations of this project

| Presentation | What it shows |
|---|---|
| [MdExplorer](../presentation/mdexplorer.md) | the presentation of the product |
| [Behind the scenes](../presentation/behind-the-scenes.md) | the numbers and the method, linked to the first |
| [Steering committee](../case-study/committee-slides.md) | five slides of the case study |

## How it is made

The header of the file says it is a presentation. Then each slide is a piece of markdown.

```markdown
---
title: Steering committee of 23 October
document_type: slides
---

# AI assistant for the help desk

---

## Where we are

- Pilot approved on 18 September
- Assistant at work in shadow mode for a week
```

To create one: "create new document" in the bar, and in the "New document" window the type "Slides".
Or ask MarkAgent, who knows the rules from the `mde-slide` skill.

## The bar on the slide

Open [the committee presentation](../case-study/committee-slides.md): the bar is at the top right.

| Button | What it does |
|---|---|
| "Present" | the presentation as it is, with working links |
| "Edit" | a click on a text corrects it; the ⋮⋮ handle moves a list item |
| 🎬 | in "Edit", chooses the transition of this slide or of all of them |
| ⛶ | puts the presentation in full screen |
| 🖍 | annotates the slide while you present: pen, highlighter, eraser |

The corrections made in "Edit" end up in the markdown file. The annotations do not: they stay on the slide
until you reload the page.

Over a diagram, when the mouse passes, the zoom and the eye 👁 appear; the eye shows it full page.

## To try

1. Open [the committee presentation](../case-study/committee-slides.md).
2. Press "Edit" and correct a word of the title with a click.
3. Go back to "Present", press 🖍 and circle a point.
4. Go to the last slide and follow a link: at the top left the trail to come back appears.
5. Right click on a list item, then "💬 Ask MarkAgent": the explanation uses the documents of the project.

## Backgrounds and characters

The MdExplorer presentation has backgrounds that move and animated characters: the astronaut, the rocket, Mark.
They are SVG files in the `presentation/assets` folder, called by the slides by name. To change one, just
replace the file: the list, with sizes and rules, is in the page [The assets of the presentation](../presentation/assets/README.md).

## Linking presentations

A markdown link to another presentation opens it, and the trail at the top left takes you back to the slide
you left from. The **←** and **→** arrows of the blue bar remember the slide too.

| Link | What it opens |
|---|---|
| `[Numbers](behind-the-scenes.md)` | the whole presentation |
| `[Numbers](behind-the-scenes.md?pages=2-)` | from the second slide on |
| `[Requirements](../case-study/01-goals-and-requirements.md)` | a document |
| `[Prototype](../case-study/mockup/operator-panel.html)` | an HTML page of the project |

## What you need

Nothing besides MdExplorer. "Ask MarkAgent" needs an AI engine: see [MarkAgent](03-markagent.md).

Next: [Word, PDF and site](05-word-pdf-site.md) · Back: [MarkAgent](03-markagent.md) · [Back to the start](../README.md)
