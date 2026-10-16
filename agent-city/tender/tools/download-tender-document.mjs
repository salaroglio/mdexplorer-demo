#!/usr/bin/env node
// Downloads the tender document of a call for tenders from the Nordica portal into Pentagroup's tender documents folder.
//
//   node agent-city/tender/tools/download-tender-document.mjs NC-2027-014
//
// In the demo the portal is a folder of the project and "downloading" is a byte-for-byte copy: this program does it, not
// the agent, because an official document is not copied out by hand. It works from any folder (also from an agent copy):
// the paths start from where this file is.

import { copyFileSync, existsSync } from 'node:fs';
import { dirname, join, relative, resolve } from 'node:path';
import { fileURLToPath } from 'node:url';

const code = process.argv[2] ?? '';
if (!/^NC-\d{4}-\d{3}$/.test(code)) {
  console.error(`ERROR: invalid call for tenders code: "${code}". ` +
    'Usage: node agent-city/tender/tools/download-tender-document.mjs <code>, for example NC-2027-014.');
  process.exit(2);
}

const tender = resolve(dirname(fileURLToPath(import.meta.url)), '..');
const root = resolve(tender, '..', '..');
const fromPortal = join(tender, 'nordica-portal', 'documents', `${code}-specification.md`);
const destination = join(tender, 'tender-documents', `${code}-specification.md`);
const projectPath = p => relative(root, p).split('\\').join('/');

if (!existsSync(fromPortal)) {
  console.error(`ERROR: the portal has no tender document attached for ${code} (looked for ${projectPath(fromPortal)}). ` +
    'On the portal the procedure says "not attached": the document must be requested from the contracting authority.');
  process.exit(1);
}

copyFileSync(fromPortal, destination);
console.log(`DOWNLOADED ${code}: ${projectPath(destination)}`);
