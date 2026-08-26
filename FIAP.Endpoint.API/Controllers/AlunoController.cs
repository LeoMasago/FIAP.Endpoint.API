using FIAP.Endpoint.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.Endpoint.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AlunoController : Controller
    {
        private readonly AppDbContext _context;

        public AlunoController(AppDbContext context)
        {
            _context = context;
        }

        //GET: api/v1/alunos
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Alunos);
        }
    }
}
