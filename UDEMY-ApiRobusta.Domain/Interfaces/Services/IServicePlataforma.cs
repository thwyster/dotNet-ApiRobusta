using UDEMY_ApiRobusta.Domain.Arguments.Jogador;
using UDEMY_ApiRobusta.Domain.Arguments.Plataforma;

namespace UDEMY_ApiRobusta.Domain.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarJogadorRequest request);
    }
}
