using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Mapping
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {

        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.cadastro).HasMaxLength(10);

            builder.Property(p => p.Item).HasMaxLength(10);

            builder.Property(p => p.MomentoDaCompra).HasMaxLength(15);
        }

    }

}
