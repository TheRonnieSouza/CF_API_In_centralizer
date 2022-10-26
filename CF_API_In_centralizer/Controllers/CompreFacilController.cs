using CF_API_In_centralizer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CF_API_In_centralizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompreFacilController : ControllerBase
    {
        private readonly DBCOMPREFACILContext _context;
        public CompreFacilController(DBCOMPREFACILContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Cfproduct>>> GetProducts()
        {

            return Ok(await _context.Cfproducts.ToListAsync());
        }        
    }
}
