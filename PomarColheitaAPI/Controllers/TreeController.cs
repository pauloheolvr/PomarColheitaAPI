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
    [Route("trees")]
    public class TreeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Trees>>> Get([FromServices] DataContext context)
        {
            var trees = await context.Trees.Include(x => x.Species).AsNoTracking().ToListAsync();
            return trees;
        }

        //[HttpGet]
        //[Route("")]
        //public async Task<ActionResult<Trees>> GetById([FromServices] DataContext context, int id)
        //{
        //    var trees = await context.Trees.Include(x => x.Species).AsNoTracking().FirstOrDefaultAsync(x => x.Code == id);
        //    return trees;
        //}


        [HttpGet]
        [Route("species")]
        public async Task<ActionResult<List<Trees>>> GetBySpecies(int id, [FromServices] DataContext context)
        {
            var trees = await context.Trees.Include(x => x.Species).AsNoTracking().Where(x => x.Species.Code == id).ToListAsync();
            return trees;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Trees>> Post(
            [FromServices] DataContext context, 
            [FromServices]Trees model)
        {
            if(ModelState.IsValid)
            {
                context.Trees.Add(model);
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
