﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired();

            builder.Property(u => u.SobreNome)
                .IsRequired();

            builder.Property(u => u.Email)
                .IsRequired().HasMaxLength(80);

            builder.Property(u => u.Senha)
                .IsRequired();

            builder.HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuarios);

        }
    }
}
