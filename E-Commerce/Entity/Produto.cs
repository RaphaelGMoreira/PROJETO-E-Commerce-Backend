using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Entity
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        public Plataforma Plataformas { get; set; }

        public Categoria Categorias { get; set; }


    }
}
