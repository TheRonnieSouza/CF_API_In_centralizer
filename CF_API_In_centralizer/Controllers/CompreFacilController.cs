using CF_API_In_centralizer.Infrastructure;
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

        [HttpPost]
        public ActionResult InsertProuct(string product, double price, string supermarket)//(Cfproduct cfproduct)
        {
            bool result = false;

            result = DataProcessingInfrastructure.ProcessingData(product, price, supermarket);

            //  _context.Add(cfproduct);
            //_context.SaveChanges();
            if(result)
                return Ok();
            else
                return BadRequest(result);
            
            
            //new CreatedAtAction("ObterProduto",
                        //new { id = cfproduct.Id }, cfproduct)      }

        }
    }


}
