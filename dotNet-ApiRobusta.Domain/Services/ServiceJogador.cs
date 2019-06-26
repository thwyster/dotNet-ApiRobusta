using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using dotNet_ApiRobusta.Domain.Arguments.Jogador;
using dotNet_ApiRobusta.Domain.Entities;
using dotNet_ApiRobusta.Domain.Interfaces.Repositories;
using dotNet_ApiRobusta.Domain.Interfaces.Services;
using dotNet_ApiRobusta.Domain.ValueObjects;

namespace dotNet_ApiRobusta.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
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
                AddNotification("AutenticarJogadorRequest", "é obrigatorio");
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, "222");

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
                return null;

            var response = _repositoryJogador.AutenticarJogador(request.Email, request.Senha);

            return response;
        }

        private bool isEmail(string email)
        {
            return false;
        }
    }
}
