using dotNet_ApiRobusta.Domain.Interfaces.Arguments;
using dotNet_ApiRobusta.Domain.ValueObjects;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
