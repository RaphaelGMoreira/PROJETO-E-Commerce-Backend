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
    public class EnderecoController : ControllerBase
    {
        public ActionResult get()
        {

            using (var ctx = new MyContext())
            {
                return Ok(ctx.Enderecos.ToList());
            }

        }

        [HttpGet("{Id}")]
        public ActionResult<Endereco> GetPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                //consulta no campo id e retornando o primeiro registro ou null
                Endereco endereco = ctx.Enderecos.Where(c => c.Id.Equals(Id)).FirstOrDefault();

                if (endereco == null)
                    return NotFound();


                return endereco;
            }

        }


        //criando um metado para inserir registro do tipo cadastro
        [HttpPost]
        public ActionResult<Endereco> Post(Endereco endereco)
        {

            using (MyContext ctx = new MyContext())
            {

                //inserindo no banco de dados um cadastro sem informar o ID
                //e o metodo add adiciona o ID para nós com o que foi gerado automaticamente
                ctx.Enderecos.Add(endereco);
                //realizando auterações no BD
                ctx.SaveChanges();

            }
            //retornando o cadastro inserido já com o ID.
            return endereco;

        }

        [HttpPut]
        public ActionResult<Endereco> Put(Endereco endereco)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Enderecos.Update(endereco);
                ctx.SaveChanges();

            }
            return endereco;

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            using (MyContext ctx = new MyContext())
            {

                Endereco endereco = ctx.Enderecos.Where(endereco => endereco.Id.Equals(id)).FirstOrDefault();

                if (endereco == null)
                    return NotFound();

                ctx.Enderecos.Remove(endereco);
                ctx.SaveChanges();

            }

            return Ok();

        }
    }
    
}
