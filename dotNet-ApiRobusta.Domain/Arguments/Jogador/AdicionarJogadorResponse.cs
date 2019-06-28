using System;
using System.Collections.Generic;
using System.Text;
using dotNet_ApiRobusta.Domain.Entities;
using dotNet_ApiRobusta.Domain.Interfaces.Arguments;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador jogador)
        {
            return new AdicionarJogadorResponse()
            {
                Id = jogador.Id,
                Message = "Operação realizada com sucesso"
            };
        }
    }
}
