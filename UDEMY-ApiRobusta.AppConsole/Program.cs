using System;
using dotNet_ApiRobusta.Domain.Arguments.Jogador;
using dotNet_ApiRobusta.Domain.Services;

namespace dotNet_ApiRobusta.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando....");
            var service = new ServiceJogador();

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criado Instancia do Objeto Request");

            request.Email = "thwyster@hotmail.com";

            var response = service.AutenticarJogador(request);

            Console.ReadKey();
        }
    }
}
