using System;
using System.Linq;
using Alpina.HelpDesk.Conoscenza;
using Alpina.HelpDesk.Tickets;

namespace Alpina.HelpDesk.Assistente
{
    /// <summary>Cerca nel catalogo delle FAQ le voci che condividono più parole con il testo del ticket.</summary>
    public class MotoreRisposteParoleChiave : IMotoreRisposte
    {
        private readonly CatalogoFaq _catalogo;

        public MotoreRisposteParoleChiave(CatalogoFaq catalogo)
        {
            _catalogo = catalogo;
        }

        public Risposta Proponi(Ticket ticket)
        {
            var parole = EstraiParole(ticket.Testo);
            var voce = _catalogo.Cerca(parole);
            if (voce == null)
            {
                return null;
            }
            var comuni = voce.ParoleChiave.Count(p => parole.Contains(p));
            var fiducia = Math.Min(1.0, comuni / 3.0);
            return new Risposta(voce.RispostaStandard, fiducia, voce.Codice);
        }

        private static string[] EstraiParole(string testo)
        {
            return testo
                .ToLowerInvariant()
                .Split(new[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(p => p.Length > 3)
                .Distinct()
                .ToArray();
        }
    }
}
