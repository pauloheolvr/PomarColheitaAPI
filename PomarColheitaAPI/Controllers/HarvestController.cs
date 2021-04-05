using Backoffice.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PomarFrutasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PomarColheitaAPI.Controllers
{
    [Route("harvest")]
    public class HarvestController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Harvest>>> Get([FromServices] DataContext context)
        {
            var harvest = await context.Harvest.Include(x => x.Trees).AsNoTracking().ToListAsync();
            return harvest;
        }

        //[HttpGet]
        //[Route("")]
        //public async Task<ActionResult<Harvest>> GetById([FromServices] DataContext context, int id)
        //{
        //    var harvest = await context.Harvest.Include(x => x.Trees).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        //    return harvest;
        //}


        [HttpGet]
        [Route("trees")]
        public async Task<ActionResult<List<Harvest>>> GetByTree(int id, [FromServices] DataContext context)
        {
            var harvest = await context.Harvest.Include(x => x.Trees).AsNoTracking().Where(x => x.Trees.Code == id).ToListAsync();
            return harvest;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Harvest>> Post(
            [FromServices] DataContext context,
            [FromServices] Harvest model)
        {
            if (ModelState.IsValid)
            {
                context.Harvest.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
