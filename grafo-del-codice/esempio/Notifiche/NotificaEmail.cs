using System;

namespace Alpina.HelpDesk.Notifiche
{
    public class NotificaEmail : INotifica
    {
        private readonly string _mittente;

        public NotificaEmail(string mittente)
        {
            _mittente = mittente;
        }

        public void Invia(string destinatario, string testo)
        {
            // Nel pilota la posta non parte davvero: si scrive sulla console.
            Console.WriteLine($"[email] da {_mittente} a {destinatario}: {testo}");
        }
    }
}
