using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;
using E_Commerce.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace E_Commerce.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Cadastro> Cadastros { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Item> Itens { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<UsuarioMaster> UsuarioMasters { get; set; }

        public DbSet<Estoque> Estoques { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("data source=45.93.100.120,1433;initial catalog=FS11;persist security info=True;user id=FS11;password=111122;MultipleActiveResultSets=True;App=exeEf;");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Cadastro>(new CadastroMapping().Configure);

            builder.Entity<Produto>(new ProdutoMapping().Configure);

            builder.Entity<Estoque>(new EstoqueMapping().Configure);

        }

    }
}
