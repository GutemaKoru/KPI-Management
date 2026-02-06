using API.Data;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IReadOnlyList<Perspective>> GetPerspectives()
        {
            var perspectives = context.Perspectives.ToList();
            return perspectives;
        }
    }
}
