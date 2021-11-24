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
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (MyContext ctx = new MyContext())
            {
                return Ok(ctx.Pedidos.ToList());
            }
        }

        [HttpGet("{Id}")]
        public ActionResult getPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                Pedido pedido = ctx.Pedidos.Where(p => p.Id.Equals(Id)).FirstOrDefault();

                if (pedido == null)
                    return NotFound();

                return Ok(pedido);

            }

        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {

            using ( MyContext ctx = new MyContext())
            {

                Pedido pedido = ctx.Pedidos.Where(p => p.Id.Equals(Id)).FirstOrDefault();

                if (pedido == null)
                    return NotFound();

                ctx.Pedidos.Remove(pedido);
                ctx.SaveChanges();

            }
            return Ok();

        }

        [HttpPost]
        public ActionResult Post(Pedido pedido)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Pedidos.Add(pedido);
                ctx.SaveChanges();

            }
            return Ok(pedido);

        }

        [HttpPut]
        public ActionResult Put(Pedido pedido)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Pedidos.Update(pedido);
                ctx.SaveChanges();

            }
            return Ok(pedido);

        }


    }
}
