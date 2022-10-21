using CF_API_In_centralizer.Context;
using CF_API_In_centralizer.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CF_API_In_centralizer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompreFacilController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CompreFacilController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produtos.ToList();
            if(produtos is null)
            {
                return NotFound("Produto nao encontrado...");  
            }
            return produtos;
        }
    }
}
