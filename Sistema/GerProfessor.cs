class Professor()
{
    public static void GerProfessor()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("====== Gerenciamento de Professores ======");
            Console.WriteLine("1. Cadastrar Professor");
            Console.WriteLine("2. Listar Professores");
            Console.WriteLine("3. Editar Professor");
            Console.WriteLine("4. Remover Professor");
            Console.WriteLine("5. Voltar");

            Console.Write("Informe uma opção: ");
            int OptionProf;

            if (!int.TryParse(Console.ReadLine(), out OptionProf))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionProf switch
            {
                1 => CadastrarProfessor,
                2 => ListarProfessores,
                3 => EditarProfessor,
                4 => RemoverProfessor,
                5 => () =>
                {
                    Console.WriteLine("\nVoltando ao menu principal...");
                    Environment.Exit(0); // Sai do programa
                }
                ,
                _ => () => Console.WriteLine("Opção inválida. Tente novamente.")
            };

            acao();
        }

    }

    private static void CadastrarProfessor()
    {
        throw new NotImplementedException();
    }

    private static void ListarProfessores()
    {
        throw new NotImplementedException();
    }

    private static void EditarProfessor()
    {
        throw new NotImplementedException();
    }

    private static void RemoverProfessor()
    {
        throw new NotImplementedException();
    }
}