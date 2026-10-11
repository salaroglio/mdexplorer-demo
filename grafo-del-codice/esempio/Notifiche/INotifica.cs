namespace Alpina.HelpDesk.Notifiche
{
    /// <summary>Come il servizio avvisa un cliente o un collega.</summary>
    public interface INotifica
    {
        void Invia(string destinatario, string testo);
    }
}
