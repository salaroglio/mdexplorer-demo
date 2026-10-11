using Alpina.HelpDesk.Metriche;
using Alpina.HelpDesk.Notifiche;
using Alpina.HelpDesk.Tickets;

namespace Alpina.HelpDesk.Assistente
{
    /// <summary>
    /// Il cuore del pilota: riceve il ticket, chiede una proposta al motore, la tiene in attesa di un operatore.
    /// Nessuna risposta parte verso il cliente senza una conferma umana.
    /// </summary>
    public class ServizioAssistente
    {
        /// <summary>Sotto questa fiducia la proposta non si mostra nemmeno all'operatore.</summary>
        public const double SogliaFiducia = 0.5;

        private readonly IArchivioTicket _archivio;
        private readonly IMotoreRisposte _motore;
        private readonly INotifica _notifica;
        private readonly MetricheRisoluzione _metriche;

        public ServizioAssistente(IArchivioTicket archivio, IMotoreRisposte motore, INotifica notifica, MetricheRisoluzione metriche)
        {
            _archivio = archivio;
            _motore = motore;
            _notifica = notifica;
            _metriche = metriche;
        }

        public void Gestisci(Ticket ticket)
        {
            _archivio.Aggiungi(ticket);
            var proposta = _motore.Proponi(ticket);
            if (proposta != null && proposta.Fiducia >= SogliaFiducia)
            {
                ticket.RispostaProposta = proposta.Testo;
                ticket.Stato = StatoTicket.InAttesaDiConferma;
            }
            else
            {
                Scala(ticket.Id, "nessuna proposta affidabile");
            }
        }

        public void Conferma(string idTicket, string operatore)
        {
            var ticket = _archivio.Trova(idTicket);
            if (ticket == null || ticket.Stato != StatoTicket.InAttesaDiConferma)
            {
                return;
            }
            ticket.Stato = StatoTicket.Risolto;
            _notifica.Invia(ticket.Cliente, ticket.RispostaProposta);
            _metriche.RegistraRisolto(primoContatto: true);
        }

        public void Scala(string idTicket, string motivo)
        {
            var ticket = _archivio.Trova(idTicket);
            if (ticket == null)
            {
                return;
            }
            ticket.Stato = StatoTicket.Scalato;
            _notifica.Invia("secondo-livello", $"Ticket {ticket.Id} da {ticket.Cliente}: {motivo}");
            _metriche.RegistraScalato();
        }
    }
}
