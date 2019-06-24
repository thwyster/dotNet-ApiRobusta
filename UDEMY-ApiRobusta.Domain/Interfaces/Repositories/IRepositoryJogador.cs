using System;
using UDEMY_ApiRobusta.Domain.Arguments.Jogador;
using UDEMY_ApiRobusta.Domain.Entities;

namespace UDEMY_ApiRobusta.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        Guid AdicionarJogador(Jogador jogador);
    }
}
