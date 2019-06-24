using UDEMY_ApiRobusta.Domain.Arguments.Jogador;
using UDEMY_ApiRobusta.Domain.ValueObjects;

namespace UDEMY_ApiRobusta.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
