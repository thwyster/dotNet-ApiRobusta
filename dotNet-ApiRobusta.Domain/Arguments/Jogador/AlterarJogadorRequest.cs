﻿using System;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class AlterarJogadorRequest
    {
        public Guid Id{ get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
    }
}
