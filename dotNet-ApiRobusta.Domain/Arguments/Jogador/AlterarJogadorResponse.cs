using System;
using dotNet_ApiRobusta.Domain.Entities;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class AlterarJogadorResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Message { get; set; }

        public static explicit operator AlterarJogadorResponse(Entities.Jogador jogador)
        {
            return new AlterarJogadorResponse()
            {
                Email = jogador.Email.Endereco,
                Id = jogador.Id,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Message = "Operacao realizada com sucesso"
            };
        }
    }
}
