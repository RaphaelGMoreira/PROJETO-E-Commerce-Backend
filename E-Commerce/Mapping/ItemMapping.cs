using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Mapping
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {

            builder.ToTable("Cadastro");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.PedidoId).HasMaxLength(10);

            builder.Property(p => p.Produto).HasMaxLength(50);

            builder.Property(p => p.ProdutoId).HasMaxLength(10);

            builder.Property(p => p.Quantidade).HasMaxLength(3);

            builder.Property(p => p.Valor).HasMaxLength(10);

        }
    }
}
