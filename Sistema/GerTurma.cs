class Turmas()
{
    public static void GerTurmas()
    {
        while (true)
        {
            Console.WriteLine("\n====== Gerenciamento de Turmas ======");
            Console.WriteLine("1. Cadastrar Turma");
            Console.WriteLine("2. Listar Turmas");
            Console.WriteLine("3. Editar Turma");
            Console.WriteLine("4. Remover Turma");
            Console.WriteLine("5. Voltar");

            Console.Write("Informe uma opção: ");
            int OptionTurma;

            if (!int.TryParse(Console.ReadLine(), out OptionTurma))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionTurma switch
            {
                1 => CadastrarTurma,
                2 => ListarTurmas,
                3 => EditarTurma,
                4 => RemoverTurma,
                5 => () =>
                {
                    Console.WriteLine("\nVoltando ao menu principal...");
                    Environment.Exit(0);
                }
                ,
                _ => () => Console.WriteLine("Opção inválida!")
            };

            acao();
        }
    }

    private static void CadastrarTurma()
    {
        Turma turma = new Turma();

        Console.WriteLine("\n====== Cadastrar Turma ======");

        Console.Write("Nome da Turma: ");
        turma.Nome = Console.ReadLine();

        Console.Write("Professor responsável: ");
        //turma.Professor = Console.ReadLine();

        Console.Write("Disciplina: ");
        // turma.Disciplina = Console.ReadLine(); Falta adicionar a Disciplina

        

    }
    
    private static void ListarTurmas()
    {
        
    }

     private static void EditarTurma()
    {
        
    }

    private static void RemoverTurma()
    {
        
    }

}