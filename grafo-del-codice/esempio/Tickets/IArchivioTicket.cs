using System.Collections.Generic;

namespace Alpina.HelpDesk.Tickets
{
    /// <summary>Dove stanno i ticket. Il pilota usa la memoria; in produzione sarà il sistema di ticketing.</summary>
    public interface IArchivioTicket
    {
        void Aggiungi(Ticket ticket);
        Ticket Trova(string id);
        IReadOnlyList<Ticket> Aperti();
    }
}
