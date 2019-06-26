using System;
using dotNet_ApiRobusta.Domain.Arguments.Jogador;
using dotNet_ApiRobusta.Domain.Entities;

namespace dotNet_ApiRobusta.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(string email, string senha);
        Guid AdicionarJogador(Jogador jogador);
    }
}
