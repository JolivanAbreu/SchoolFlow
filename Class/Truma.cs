using System.Diagnostics.Contracts;

class Turma()
{
    public string Nome { get; set; }
    public int QuantidadeAlunos { get; set; }
    // public Disciplina Disciplina { get; set; }
    public Professor Professor { get; set; }
    public List<Aluno> Alunos { get; set; }

}