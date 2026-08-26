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

        //GET: api/v1/alunos/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            return aluno is not null ? Ok(aluno) : NotFound();
        }
    }
}
