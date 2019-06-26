using dotNet_ApiRobusta.Domain.Arguments.Jogador;
using dotNet_ApiRobusta.Domain.Arguments.Plataforma;

namespace dotNet_ApiRobusta.Domain.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarJogadorRequest request);
    }
}
