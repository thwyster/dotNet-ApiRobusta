using prmToolkit.NotificationPattern;

namespace dotNet_ApiRobusta.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(w=> w.Endereco);
        }

        public string Endereco { get; private set; }
    }
}
