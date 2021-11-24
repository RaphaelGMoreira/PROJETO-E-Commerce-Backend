using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Mapping
{
    public class CadastroMapping : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.ToTable("Cadastro");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Nome).HasMaxLength(50);

            builder.Property(p => p.Email).HasMaxLength(50);

            builder.Property(p => p.Senha).HasMaxLength(15);

            builder.Property(p => p.Cpf).HasMaxLength(11);

            builder.Property(p => p.DataNascimento).HasMaxLength(8);

            builder.Property(p => p.Perfil).HasMaxLength(2);

            
        }
    }
}
