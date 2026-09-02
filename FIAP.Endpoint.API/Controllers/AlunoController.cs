using FIAP.Endpoint.API.Data;
using FIAP.Endpoint.API.DTOs;
using FIAP.Endpoint.API.Models;
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

        //POST: api/v1/alunos
        [HttpPost]
        public IActionResult Create([FromBody] AlunoRequest request)
        {
            var novoId = _context.Alunos.Any() ? _context.Alunos.Max(a => a.Id) + 1 : 1;
            var aluno = new Aluno
            {
                Id = novoId,
                Nome = request.Nome,
                Email = request.Email,
                Curso = request.Curso
            };

            _context.Alunos.Add(aluno);
            return Created($"/api/v1/alunos/{aluno.Id}", aluno);
        }

        //PUT: api/v1/alunos/{id}
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] AlunoRequest request)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            //Só atualiza se o campo for enviado e não está vazio
            if (!string.IsNullOrWhiteSpace(request.Nome))
            {
                aluno.Nome = request.Nome;
            }

            if (!string.IsNullOrWhiteSpace(request.Email))
            {
                aluno.Email = request.Email;
            }

            if (!string.IsNullOrWhiteSpace(request.Curso))
            {
                aluno.Curso = request.Curso;
            }

            return NoContent();
        }

        //DELETE: api/v1/alunos/{id}
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno is null) return NotFound();

            _context.Alunos.Remove(aluno);
            return NoContent();
        }
    }
}
