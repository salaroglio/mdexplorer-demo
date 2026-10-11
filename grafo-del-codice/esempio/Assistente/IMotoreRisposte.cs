using Alpina.HelpDesk.Tickets;

namespace Alpina.HelpDesk.Assistente
{
    /// <summary>Chi propone la risposta a un ticket. Il pilota ha due motori: uno a parole chiave e uno di prova.</summary>
    public interface IMotoreRisposte
    {
        /// <returns>La risposta proposta, o null se il motore non ha niente da dire.</returns>
        Risposta Proponi(Ticket ticket);
    }
}
