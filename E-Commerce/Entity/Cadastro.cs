using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Entity
{
    public class Cadastro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public long Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public Endereco Endereco { get; set; }

        public Perfil Perfil { get; set; }






    }
}
