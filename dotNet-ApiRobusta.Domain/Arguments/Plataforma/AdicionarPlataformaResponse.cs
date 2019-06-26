using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet_ApiRobusta.Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Message { get; set; }
    }
}
