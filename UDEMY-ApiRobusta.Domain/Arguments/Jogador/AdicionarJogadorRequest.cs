using UDEMY_ApiRobusta.Domain.Interfaces.Arguments;
using UDEMY_ApiRobusta.Domain.ValueObjects;

namespace UDEMY_ApiRobusta.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
