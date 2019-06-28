using System;
using dotNet_ApiRobusta.Domain.Entities;

namespace dotNet_ApiRobusta.Domain.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid Id { get; private set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador entidade)
        {
            return new JogadorResponse()
            {
                Id = entidade.Id,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                Email = entidade.Email.Endereco,
                Status = entidade.Status.ToString()
            };
        }
    }
}
