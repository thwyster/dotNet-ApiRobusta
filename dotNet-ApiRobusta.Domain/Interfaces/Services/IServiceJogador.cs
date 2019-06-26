using dotNet_ApiRobusta.Domain.Arguments.Jogador;
using dotNet_ApiRobusta.Domain.ValueObjects;

namespace dotNet_ApiRobusta.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
