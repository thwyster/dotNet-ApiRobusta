using System;
using System.Collections.Generic;
using System.Text;
using UDEMY_ApiRobusta.Domain.Arguments.Jogador;
using UDEMY_ApiRobusta.Domain.Entities;
using UDEMY_ApiRobusta.Domain.Interfaces.Repositories;
using UDEMY_ApiRobusta.Domain.Interfaces.Services;

namespace UDEMY_ApiRobusta.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Jogador jogador = new Jogador();
            jogador.Email = request.Email;
            jogador.Nome = request.Nome;
            jogador.Status = Enum.StatusJogador.EmAndamento;

            Guid id = _repositoryJogador.AdicionarJogador(jogador);

            jogador.Status = Enum.StatusJogador.Ativo;

            return new AdicionarJogadorResponse() { Id = id, Message = "Operacação Realizada com Sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest é obrigatório");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um emails");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma Senha");
            }

            if (isEmail(request.Email))
            {
                throw new Exception("Informe uma Senha");
            }

            if (request.Senha.Length < 6)
            {
                throw new Exception("A Senha deve ter pelo menos 6 caracteres");
            }

            var response = _repositoryJogador.AutenticarJogador(request);

            return response;
        }

        private bool isEmail(string email)
        {
            return false;
        }
    }
}
