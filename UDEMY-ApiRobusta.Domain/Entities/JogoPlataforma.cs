using System;
using System.Collections.Generic;
using System.Text;

namespace UDEMY_ApiRobusta.Domain.Entities
{
    public class JogoPlataforma
    {
        public Guid Id { get; set; }
        public Jogo Jogo { get; set; }
        public Plataforma Plataforma { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
