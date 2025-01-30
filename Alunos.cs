class Alunos()
{
    public static void GerAlunos()
    {
        Console.WriteLine("\n====== Gerenciamento de Alunos ======");
        Console.WriteLine("1. Cadastrar Aluno");
        Console.WriteLine("2. Listar Alunos");
        Console.WriteLine("3. Editar Aluno");
        Console.WriteLine("4. Remover Aluno");
        Console.WriteLine("5. Voltar");

        int OptionAl = int.Parse(Console.ReadLine());

        if (OptionAl == 1)
        {
            CadastrarAluno();
        }
        else if (OptionAl == 2)
        {
            ListarAlunos();
        }
        else if (OptionAl == 3)
        {
            EditarAluno();
        }
        else if (OptionAl == 4)
        {
            RemoverAluno();
        }
        else if (OptionAl == 5)
        {
            Console.WriteLine("\n Saindo...");
            return ;
        }
    }

    private static void RemoverAluno()
    {

    }

    private static void ListarAlunos()
    {

    }

    private static void EditarAluno()
    {

    }

    private static void CadastrarAluno()
    {

    }
}