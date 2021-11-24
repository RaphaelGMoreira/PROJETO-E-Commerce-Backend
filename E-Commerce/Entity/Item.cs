using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Entity
{
    public class Item
    {
        public int Id { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }

        public int Quantidade { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public decimal Valor { get; set; }

    }
}
