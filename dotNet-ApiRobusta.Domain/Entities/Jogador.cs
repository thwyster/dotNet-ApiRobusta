using prmToolkit.NotificationPattern;
using System;
using dotNet_ApiRobusta.Domain.Enum;
using dotNet_ApiRobusta.Domain.ValueObjects;

namespace dotNet_ApiRobusta.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {

        }

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(w => w.Senha, 6, 32, "A senha deve ter pelo menos 6 a 32 caracteres");
        }

        public Guid id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public StatusJogador Status { get; set; }
    }
}
