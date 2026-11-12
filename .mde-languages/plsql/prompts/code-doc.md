Questo sorgente è PL/SQL di Oracle. Nel grafo:

- il modulo è il file; un'interfaccia è la specifica di un package (che cosa espone), una classe è il corpo del package;
- una funzione con firma `PROCEDURE X` o `FUNCTION X` è un sottoprogramma: di' che cosa fa per chi lo chiama, i parametri
  con il loro verso (IN, OUT, IN OUT), il valore restituito, e quali tabelle legge e scrive, senza riscrivere le query;
- una funzione con firma `TRIGGER X` è un trigger: di' su quale tabella, per quale evento (INSERT, UPDATE, DELETE), prima o
  dopo, e che cosa cambia;
- un record è una tabella, un tipo con firma `VIEW X` è una vista: di' che cosa contiene, in parole di chi la usa;
- le transazioni contano: se il codice fa COMMIT o ROLLBACK, o gestisce le eccezioni in modo da nasconderle (WHEN OTHERS
  THEN NULL), dillo nelle avvertenze.

Non copiare valori di configurazione, nomi di utenti o password, anche se compaiono nel codice.
