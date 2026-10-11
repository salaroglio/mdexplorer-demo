namespace Alpina.HelpDesk.Metriche
{
    /// <summary>
    /// I numeri che il comitato guarda (caso-studio/dati/metriche-obiettivo.json): quanti ticket si chiudono
    /// al primo contatto e quanti vanno al secondo livello.
    /// </summary>
    public class MetricheRisoluzione
    {
        private int _risolti;
        private int _risoltiAlPrimoContatto;
        private int _scalati;

        public void RegistraRisolto(bool primoContatto)
        {
            _risolti++;
            if (primoContatto)
            {
                _risoltiAlPrimoContatto++;
            }
        }

        public void RegistraScalato()
        {
            _scalati++;
        }

        /// <summary>Quota di ticket chiusi al primo contatto sul totale gestito. Zero se non c'è ancora niente.</summary>
        public double TassoPrimoContatto()
        {
            var totale = _risolti + _scalati;
            return totale == 0 ? 0 : (double)_risoltiAlPrimoContatto / totale;
        }
    }
}
