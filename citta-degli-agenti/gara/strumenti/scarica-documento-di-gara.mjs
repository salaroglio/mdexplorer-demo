#!/usr/bin/env node
// Scarica il documento di gara di un bando dal portale di Nordica nella cartella dei documenti di gara di Pentagroup.
//
//   node citta-degli-agenti/gara/strumenti/scarica-documento-di-gara.mjs NC-2027-014
//
// Nel demo il portale è una cartella del progetto e «scaricare» è una copia byte per byte: la fa questo programma, non
// l'agente, perché un documento ufficiale non si ricopia a mano. Funziona da qualunque cartella (anche dalla copia di
// lavoro di un agente): i percorsi partono da dove sta questo file.

import { copyFileSync, existsSync } from 'node:fs';
import { dirname, join, relative, resolve } from 'node:path';
import { fileURLToPath } from 'node:url';

const codice = process.argv[2] ?? '';
if (!/^NC-\d{4}-\d{3}$/.test(codice)) {
  console.error(`ERRORE: codice del bando non valido: «${codice}». ` +
    'Uso: node citta-degli-agenti/gara/strumenti/scarica-documento-di-gara.mjs <codice>, per esempio NC-2027-014.');
  process.exit(2);
}

const gara = resolve(dirname(fileURLToPath(import.meta.url)), '..');
const radice = resolve(gara, '..', '..');
const daPortale = join(gara, 'portale-nordica', 'documenti', `${codice}-capitolato.md`);
const destinazione = join(gara, 'documenti-di-gara', `${codice}-capitolato.md`);
const percorso = p => relative(radice, p).split('\\').join('/');

if (!existsSync(daPortale)) {
  console.error(`ERRORE: il portale non ha un documento di gara allegato per ${codice} (cercato ${percorso(daPortale)}). ` +
    'Sul portale la procedura dice «non allegato»: il documento va chiesto al committente.');
  process.exit(1);
}

copyFileSync(daPortale, destinazione);
console.log(`SCARICATO ${codice}: ${percorso(destinazione)}`);
