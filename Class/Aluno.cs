using System.Diagnostics.Contracts;

class Aluno()
{
    static int contador = 1;

    public int Matricula { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Media { get; set; }
    public string Situacao { get; set; }
    public string listaAlunos { get; set; }

    public int GerarMatricula()
    {
        string anoAtual = DateTime.Now.Year.ToString();
        string id = contador.ToString("D3"); // Formata com três dígitos (ex: 001, 002)

        contador++;

        return int.Parse($"{anoAtual}{id}"); // Converte a string "2025001" para int
    }


}