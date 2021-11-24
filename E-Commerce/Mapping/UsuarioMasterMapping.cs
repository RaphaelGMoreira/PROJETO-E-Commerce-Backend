using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Mapping
{
    public class UsuarioMasterMapping : IEntityTypeConfiguration<UsuarioMaster>
    {
        public void Configure(EntityTypeBuilder<UsuarioMaster> builder)
        {
            builder.ToTable("UsuarioMaster");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Nome).HasMaxLength(50);

            builder.Property(p => p.Email).HasMaxLength(50);

            builder.Property(p => p.Senha).HasMaxLength(15);

            builder.Property(p => p.CPF).HasMaxLength(11);


        }
    }
}
