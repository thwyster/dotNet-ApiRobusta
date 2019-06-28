using dotNet_ApiRobusta.Domain.Arguments.Jogador;
using dotNet_ApiRobusta.Domain.ValueObjects;
using System.Collections;
using System.Collections.Generic;

namespace dotNet_ApiRobusta.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
    }
}
