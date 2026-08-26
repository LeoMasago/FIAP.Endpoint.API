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
            aluno2.Id = 2;
            aluno2.Nome = "Luiz Henrique";
            aluno2.Email = "luiz.henrique@fiap.com.br";
            aluno2.Curso = "Engenharia de Software";

            Aluno aluno3 = new Aluno();
            aluno3.Id = 3;
            aluno3.Nome = "Léo Masago";
            aluno3.Email = "leo.masago@fiap.com.br";
            aluno3.Curso = "Engenharia de Software";

            Alunos.Add(aluno1);
            Alunos.Add(aluno2);
            Alunos.Add(aluno3);
        }
    }
}
