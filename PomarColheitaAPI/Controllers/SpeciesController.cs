using Backoffice.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PomarFrutasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PomarFrutasAPI.Controllers
{
    [Route("species")]
    public class SpeciesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Species>>> Get(
            [FromServices]DataContext context    
        )
        {
            var species = await context.Species.AsNoTracking().ToListAsync();
            return Ok(species);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Species>> GetById(
            int id,
            [FromServices] DataContext context
        )
        {
            var species = await context.Species.AsNoTracking().FirstOrDefaultAsync(x => x.Code == id);
            return species;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Species>>> Post(
            [FromBody]Species model,
            [FromServices]DataContext context
        )
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Species.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch
            {
                return BadRequest(new { message = "It was no possible to create the type os species" });
            }
        }
    }
}
