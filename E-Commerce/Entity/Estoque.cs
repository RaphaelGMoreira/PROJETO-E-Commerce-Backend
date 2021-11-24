using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Entity
{
    public class Estoque
    {
        public int Id { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public int QtdProduto { get; set; }


    }
}
