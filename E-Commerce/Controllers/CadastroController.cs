using E_Commerce.Context;
using E_Commerce.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Cadastro>> get()
        {

            using (var ctx = new MyContext())
            {
                return Ok(ctx.Enderecos.ToList());
            }

        }

        [HttpGet("{Id}")]
        public ActionResult<Cadastro> GetPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                //consulta no campo id e retornando o primeiro registro ou null
                Cadastro cadastro = ctx.Cadastros.Where(c => c.Id.Equals(Id)).FirstOrDefault();

                if (cadastro == null)
                    return NotFound();


                return cadastro;
            }

        }


        //criando um metado para inserir registro do tipo cadastro
        [HttpPost]
        public ActionResult<Cadastro> Post(Cadastro cadastro)
        {

            using (MyContext ctx = new MyContext())
            {

                //inserindo no banco de dados um cadastro sem informar o ID
                //e o metodo add adiciona o ID para nós com o que foi gerado automaticamente
                ctx.Cadastros.Add(cadastro);
                //realizando auterações no BD
                ctx.SaveChanges();

            }
            //retornando o cadastro inserido já com o ID.
            return cadastro;

        }

        [HttpPut]
        public ActionResult<Cadastro> Put(Cadastro cadastro)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Cadastros.Update(cadastro);
                ctx.SaveChanges();

            }
            return cadastro;

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            using (MyContext ctx = new MyContext())
            {

                Cadastro cadastro = ctx.Cadastros.Where(cadastro => cadastro.Id.Equals(id)).FirstOrDefault();

                if (cadastro == null)
                    return NotFound();

                ctx.Cadastros.Remove(cadastro);
                ctx.SaveChanges();

            }

            return Ok();

        }

    }
}
