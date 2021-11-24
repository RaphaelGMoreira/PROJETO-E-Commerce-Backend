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
    public class EstoqueController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (MyContext ctx = new MyContext())
            {

                return Ok(ctx.Items.ToList());

            }
        }

        [HttpGet("{Id}")]
        public ActionResult getPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                Estoque estoque = ctx.Estoques.Where(e => e.Id.Equals(Id)).FirstOrDefault();

                if (estoque == null)
                    return NotFound();

                return Ok(estoque);

            }

        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                Estoque estoque = ctx.Estoques.Where(e => e.Id.Equals(Id)).FirstOrDefault();

                if (estoque == null)
                    return NotFound();

                ctx.Estoques.Remove(estoque);
                ctx.SaveChanges();

            }
            return Ok();

        }

        [HttpPost]
        public ActionResult Post(Estoque estoque)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Estoques.Add(estoque);
                ctx.SaveChanges();

            }
            return Ok(estoque);

        }

        [HttpPut]
        public ActionResult Put(Estoque estoque)
        {

            using(MyContext ctx = new MyContext())
            {

                ctx.Estoques.Update(estoque);
                ctx.SaveChanges();

            }
            return Ok(estoque);
        }

    }
}
