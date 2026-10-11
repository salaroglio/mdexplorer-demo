using System.Collections.Generic;
using System.Linq;

namespace Alpina.HelpDesk.Conoscenza
{
    /// <summary>Le FAQ del pilota. In produzione arriveranno dalla base di conoscenza del servizio clienti.</summary>
    public class CatalogoFaq
    {
        private readonly List<VoceFaq> _voci = new List<VoceFaq>
        {
            new VoceFaq("FAQ-01", new[] { "password", "scaduta", "portale" },
                "Per rinnovare la password usa «Password dimenticata» nella pagina di accesso del portale."),
            new VoceFaq("FAQ-02", new[] { "fattura", "scaricare", "portale" },
                "Le fatture sono nel portale, voce «Documenti», filtrando per anno."),
            new VoceFaq("FAQ-03", new[] { "orari", "sportello", "apertura" },
                "Lo sportello è aperto dal lunedì al venerdì, dalle 8:30 alle 17:00."),
        };

        /// <summary>La voce con più parole chiave in comune con il testo, o null se nessuna ne ha.</summary>
        public VoceFaq Cerca(IReadOnlyCollection<string> parole)
        {
            var migliore = _voci
                .Select(v => new { Voce = v, Comuni = v.ParoleChiave.Count(parole.Contains) })
                .Where(x => x.Comuni > 0)
                .OrderByDescending(x => x.Comuni)
                .FirstOrDefault();
            return migliore?.Voce;
        }

        public int Conta()
        {
            return _voci.Count;
        }
    }
}
