using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Rua).HasMaxLength(50);

            builder.Property(e => e.Bairro).HasMaxLength(50);

            builder.Property(e => e.Cidade).HasMaxLength(20);

            builder.Property(e => e.Numero).HasMaxLength(10);

            builder.Property(e => e.Complemento).HasMaxLength(50);

            builder.Property(e => e.Cep).HasMaxLength(8);

        }
    }
}
