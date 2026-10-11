using Alpina.HelpDesk.Assistente;
using Alpina.HelpDesk.Conoscenza;
using Alpina.HelpDesk.Metriche;
using Alpina.HelpDesk.Notifiche;
using Alpina.HelpDesk.Tickets;

namespace Alpina.HelpDesk
{
    /// <summary>
    /// Il pilota dell'assistente AI per l'help desk di Alpina Servizi (vedi caso-studio/).
    /// Un ticket arriva, l'assistente propone una risposta, un operatore conferma o passa il ticket a un collega.
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            var archivio = new ArchivioTicketInMemoria();
            var catalogo = new CatalogoFaq();
            var motore = new MotoreRisposteParoleChiave(catalogo);
            var notifica = new NotificaEmail("helpdesk@alpina.example");
            var metriche = new MetricheRisoluzione();
            var assistente = new ServizioAssistente(archivio, motore, notifica, metriche);

            var ticket = new Ticket("T-1001", "Rossi", "Non riesco a entrare nel portale: password scaduta");
            assistente.Gestisci(ticket);
            assistente.Conferma(ticket.Id, "Operatore 7");

            System.Console.WriteLine($"Risolti al primo contatto: {metriche.TassoPrimoContatto():P0}");
        }
    }
}
