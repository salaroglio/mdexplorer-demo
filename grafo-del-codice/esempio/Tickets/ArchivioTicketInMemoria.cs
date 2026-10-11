using System.Collections.Generic;
using System.Linq;

namespace Alpina.HelpDesk.Tickets
{
    public class ArchivioTicketInMemoria : IArchivioTicket
    {
        private readonly Dictionary<string, Ticket> _ticket = new Dictionary<string, Ticket>();

        public void Aggiungi(Ticket ticket)
        {
            _ticket[ticket.Id] = ticket;
        }

        public Ticket Trova(string id)
        {
            return _ticket.TryGetValue(id, out var trovato) ? trovato : null;
        }

        public IReadOnlyList<Ticket> Aperti()
        {
            return _ticket.Values.Where(t => t.Stato != StatoTicket.Risolto).ToList();
        }
    }
}
