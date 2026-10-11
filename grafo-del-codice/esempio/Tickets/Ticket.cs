namespace Alpina.HelpDesk.Tickets
{
    /// <summary>Una richiesta di aiuto arrivata all'help desk.</summary>
    public class Ticket
    {
        public Ticket(string id, string cliente, string testo)
        {
            Id = id;
            Cliente = cliente;
            Testo = testo;
            Stato = StatoTicket.Aperto;
        }

        public string Id { get; }
        public string Cliente { get; }
        public string Testo { get; }
        public StatoTicket Stato { get; set; }

        /// <summary>La risposta proposta dall'assistente, in attesa di un operatore.</summary>
        public string RispostaProposta { get; set; }
    }

    public enum StatoTicket
    {
        Aperto,
        InAttesaDiConferma,
        Risolto,
        Scalato
    }
}
