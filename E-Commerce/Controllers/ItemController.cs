using E_Commerce.Context;
using E_Commerce.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            
            using (MyContext ctx = new MyContext())
            {

                var item = ctx.Items.Include(i => i.Produto).ToList();
                return Ok(item);

            }

        }

        [HttpGet("{Id}")]
        public ActionResult getPeloId(int Id)
        {

            using (MyContext ctx = new MyContext())
            {

                Item item = ctx.Items.Where(i => i.Id.Equals(Id)).FirstOrDefault();

                if (item == null)
                    return NotFound();

                return Ok(item);

            }

        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {

            using(MyContext ctx = new MyContext())
            {

                Item item = ctx.Items.Where(i => i.Id.Equals(Id)).FirstOrDefault();

                if (item == null)
                    return NotFound();

                ctx.Items.Remove(item);
                ctx.SaveChanges();

            }
            return Ok();

        }

        [HttpPost]
        public ActionResult Post(Item item)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Items.Add(item);
                ctx.SaveChanges();

            }
            return Ok(item);
        }

        [HttpPut]
        public ActionResult Put(Item item)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.Items.Update(item);
                ctx.SaveChanges();

            }
            return Ok(item);

        }


    }
}
