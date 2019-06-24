using System;
using System.Collections.Generic;
using System.Text;
using UDEMY_ApiRobusta.Domain.Interfaces.Arguments;

namespace UDEMY_ApiRobusta.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
