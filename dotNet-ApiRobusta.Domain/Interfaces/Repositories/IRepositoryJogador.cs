using dotNet_ApiRobusta.Domain.Entities;
using System;
using System.Collections.Generic;

namespace dotNet_ApiRobusta.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);
        Jogador AdicionarJogador(Jogador jogador);
        void AlterarJogador(Jogador jogador);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterJogadorPorId(Guid id);
    }
}
