using E_Commerce.Context;
using E_Commerce.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public ActionResult<IEnumerable<Produto>> get ()
        {
            using (var ctx = new MyContext())
            {
                return Ok(ctx.Produtos.ToList());
            }
        }

        [HttpGet("{Id}")]
        public ActionResult<Produto> GetPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                //consulta no campo id e retornando o primeiro registro ou null
                Produto produto = ctx.Produtos.Where(p => p.Id.Equals(Id)).FirstOrDefault();

                if (produto == null)
                    return NotFound();


                return produto;
            }

        }

        [HttpGet("{Nome}")]
        public ActionResult<Produto> GetPeloNome(string Nome)
        {

            using (MyContext ctx = new MyContext())
            {

                //consulta no campo Nome e retornando o primeiro registro ou null
                Produto produto = ctx.Produtos.Where(p => p.Id.Equals(Nome)).FirstOrDefault();

                if (produto == null)
                    return NotFound();


                return produto;
            }

        }


        //criando um metado para inserir registro do tipo cadastro
        [HttpPost]
        public ActionResult<Produto> Post(Produto produto)
        {

            using (MyContext ctx = new MyContext())
            {

                //inserindo no banco de dados um cadastro sem informar o ID
                //e o metodo add adiciona o ID para nós com o que foi gerado automaticamente
                ctx.Produtos.Add(produto);
                //realizando auterações no BD
                ctx.SaveChanges();

            }
            //retornando o cadastro inserido já com o ID.
            return produto;

        }

        [HttpPut]
        public ActionResult<Produto> Put(Produto produto)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Produtos.Update(produto);
                ctx.SaveChanges();

            }
            return produto;

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            using (MyContext ctx = new MyContext())
            {

                Produto produto = ctx.Produtos.Where(produto => produto.Id.Equals(id)).FirstOrDefault();

                if (produto == null)
                    return NotFound();

                ctx.Produtos.Remove(produto);
                ctx.SaveChanges();

            }

            return Ok();

        }

    }
}
