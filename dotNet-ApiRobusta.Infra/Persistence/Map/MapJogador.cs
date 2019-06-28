using dotNet_ApiRobusta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet_ApiRobusta.Infra.Persistence.Map
{
    public class MapJogador : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            //builder.HasKey(w => w.Id);
            builder.Property(w => w.Nome.PrimeiroNome).HasMaxLength(50).IsRequired();
            builder.Property(w => w.Nome.UltimoNome).HasMaxLength(50).IsRequired();
            builder.Property(w => w.Senha).IsRequired();
            builder.Property(w => w.Status).IsRequired();
            builder.Property(w => w.Email).IsRequired();
        }
    }
}
