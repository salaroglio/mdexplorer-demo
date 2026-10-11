using System;

namespace Alpina.HelpDesk.Notifiche
{
    /// <summary>Per le prove a mano: stampa e basta.</summary>
    public class NotificaConsole : INotifica
    {
        public void Invia(string destinatario, string testo)
        {
            Console.WriteLine($"[{destinatario}] {testo}");
        }
    }
}
