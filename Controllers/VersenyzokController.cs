using Euriskills.Data;
using Euriskills.Models;
using Microsoft.AspNetCore.Mvc;

namespace Euriskills.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class VersenyzokController : ControllerBase
    {
        private readonly SzakmaiVersenyzokDbContext _context;
        public VersenyzokController(SzakmaiVersenyzokDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Versenyzo>>> GetVersenyzok()
        {
            return _context.Versenyzok.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Versenyzo>> GetVersenyzo(int id)
        {
            var meccs = _context.Versenyzok.Find(id);
            if (meccs == null)
                return NotFound();
            return meccs;
        }

        [HttpPost]
        public async Task<ActionResult> AddMeccs(Versenyzo versenyzo)
        {
            _context.Versenyzok.Add(versenyzo);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
