using Alpina.HelpDesk.Tickets;

namespace Alpina.HelpDesk.Assistente
{
    /// <summary>Risponde sempre la stessa cosa: serve ai test del servizio, non ai clienti.</summary>
    public class MotoreRisposteDiProva : IMotoreRisposte
    {
        private readonly string _testoFisso;

        public MotoreRisposteDiProva(string testoFisso)
        {
            _testoFisso = testoFisso;
        }

        public Risposta Proponi(Ticket ticket)
        {
            return new Risposta(_testoFisso, 1.0, "prova");
        }
    }
}
