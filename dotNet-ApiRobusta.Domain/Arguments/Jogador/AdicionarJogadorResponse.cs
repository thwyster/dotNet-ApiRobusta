using System;
using System.Collections.Generic;
using System.Text;
using dotNet_ApiRobusta.Domain.Interfaces.Arguments;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
