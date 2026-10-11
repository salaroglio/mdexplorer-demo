using System.Collections.Generic;

namespace Alpina.HelpDesk.Conoscenza
{
    /// <summary>Una domanda frequente con la risposta standard approvata dal servizio clienti.</summary>
    public class VoceFaq
    {
        public VoceFaq(string codice, IReadOnlyList<string> paroleChiave, string rispostaStandard)
        {
            Codice = codice;
            ParoleChiave = paroleChiave;
            RispostaStandard = rispostaStandard;
        }

        public string Codice { get; }
        public IReadOnlyList<string> ParoleChiave { get; }
        public string RispostaStandard { get; }
    }
}
