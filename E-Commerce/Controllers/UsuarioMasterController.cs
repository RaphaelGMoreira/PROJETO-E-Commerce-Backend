using E_Commerce.Context;
using E_Commerce.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class UsuarioMasterController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (MyContext ctx = new MyContext())
            {
                return Ok(ctx.UsuarioMasters.ToList());
            }
        }

        [HttpGet("{Id}")]
        public ActionResult getPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                UsuarioMaster usuarioMaster = ctx.UsuarioMasters.Where(u => u.Id.Equals(Id)).FirstOrDefault();

                if (usuarioMaster == null)
                    return NotFound();

                return Ok(usuarioMaster);

            }

        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                UsuarioMaster usuarioMaster = ctx.UsuarioMasters.Where(u => u.Id.Equals(Id)).FirstOrDefault();

                if (usuarioMaster == null)
                    return NotFound();

                ctx.UsuarioMasters.Remove(usuarioMaster);
                ctx.SaveChanges();

            }
            return Ok();

        }

        [HttpPost]
        public ActionResult Post(UsuarioMaster usuarioMaster)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.UsuarioMasters.Add(usuarioMaster);
                ctx.SaveChanges();

            }
            return Ok(usuarioMaster);

        }

        [HttpPut]
        public ActionResult Put(UsuarioMaster usuarioMaster)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.UsuarioMasters.Update(usuarioMaster);
                ctx.SaveChanges();

            }
            return Ok(usuarioMaster);

        }


    }
}
