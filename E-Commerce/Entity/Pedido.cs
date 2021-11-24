using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Entity
{
    public class Pedido
    {
        public int Id { get; set; }

        public DataType MomentoDaCompra { get; set; }

        public Cadastro cadastro { get; set; }

        public Item Item { get; set; }
    }
}
