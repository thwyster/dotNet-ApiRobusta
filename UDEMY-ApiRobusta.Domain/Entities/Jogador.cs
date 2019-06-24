using System;
using UDEMY_ApiRobusta.Domain.Enum;
using UDEMY_ApiRobusta.Domain.ValueObjects;

namespace UDEMY_ApiRobusta.Domain.Entities
{
    public class Jogador
    {
        public Guid id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public StatusJogador Status { get; set; }
    }
}
