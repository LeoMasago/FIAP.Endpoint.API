using FIAP.Endpoint.API.Models;

namespace FIAP.Endpoint.API.Data
{
    public class AppDbContext
    {
        public List<Aluno> Alunos { get; set; }

        public AppDbContext() 
        { 
            Alunos = new List<Aluno>();
            Aluno aluno1 = new Aluno();
            aluno1.Id = 1;
            aluno1.Nome = "Eduardo Tomaz";
            aluno1.Email = "eduardo.tomaz@fiap.com.br";
            aluno1.Curso = "Engenharia de Software";

            Aluno aluno2 = new Aluno();
            aluno1.Id = 2;
            aluno1.Nome = "Luiz Henrique";
            aluno1.Email = "luiz.henrique@fiap.com.br";
            aluno1.Curso = "Engenharia de Software";

            Aluno aluno3 = new Aluno();
            aluno1.Id = 3;
            aluno1.Nome = "Léo Masago";
            aluno1.Email = "leo.masago@fiap.com.br";
            aluno1.Curso = "Engenharia de Software";

            Alunos.Add(aluno1);
            Alunos.Add(aluno2);
            Alunos.Add(aluno3);
        }
    }
}
