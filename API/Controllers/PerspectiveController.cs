using API.Data;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerspectivesController : ControllerBase
    {
        private readonly AppDbContext context;

        public PerspectivesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Perspective>>> GetPerspectives()
        {
            var perspectives = await context.Perspectives.ToListAsync();
            return perspectives;
        }
    }
}
