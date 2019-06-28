using dotNet_ApiRobusta.Domain.Interfaces.Arguments;
using dotNet_ApiRobusta.Domain.ValueObjects;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
    }
}
