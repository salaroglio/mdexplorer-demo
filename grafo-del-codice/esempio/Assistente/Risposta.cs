namespace Alpina.HelpDesk.Assistente
{
    /// <summary>Una risposta proposta, con quanto il motore si fida di lei e da dove l'ha presa.</summary>
    public class Risposta
    {
        public Risposta(string testo, double fiducia, string fonte)
        {
            Testo = testo;
            Fiducia = fiducia;
            Fonte = fonte;
        }

        public string Testo { get; }

        /// <summary>Da 0 a 1. Sotto la soglia del servizio il ticket va a un operatore senza proposta.</summary>
        public double Fiducia { get; }

        public string Fonte { get; }
    }
}
