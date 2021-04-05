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
    [Route("grouptrees")]
    public class GroupTreesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<GroupTrees>>> Get(
            [FromServices] DataContext context
        )
        {
            var grouptrees = await context.GroupTrees.AsNoTracking().ToListAsync();
            return Ok(grouptrees);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<GroupTrees>> GetById(
            int id,
            [FromServices] DataContext context
        )
        {
            var grouptrees = await context.GroupTrees.AsNoTracking().FirstOrDefaultAsync(x => x.Code == id);
            return grouptrees;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<GroupTrees>>> Post(
            [FromBody] GroupTrees model,
            [FromServices] DataContext context
        )
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.GroupTrees.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch
            {
                return BadRequest(new { message = "It was no possible to create this tree group" });
            }
        }
    }
}
