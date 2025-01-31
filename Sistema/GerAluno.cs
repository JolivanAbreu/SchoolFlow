class Alunos()
{
    private static List<Aluno> listaAlunos = new List<Aluno>();
    public static void GerAlunos()
    {
        while (true)
        {
            Console.WriteLine("\n====== Gerenciamento de Alunos ======");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Listar Alunos");
            Console.WriteLine("3. Editar Aluno");
            Console.WriteLine("4. Remover Aluno");
            Console.WriteLine("5. Voltar");

            Console.Write("Informe uma opção: ");
            int OptionAl;


            if (!int.TryParse(Console.ReadLine(), out OptionAl))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

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
                Console.WriteLine("\nVoltando ao menu principal...");
                break;
            }
            else if (OptionAl == 6)
            {
                Console.WriteLine("\nSaindo do sistema...");
                Environment.Exit(0);
            }
        }

    }

    private static void CadastrarAluno()
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("\n====== Cadastrar Aluno ======");

        aluno.Matricula = aluno.GerarMatricula(); // Gera a matrícula automaticamente
        Console.WriteLine($"Matrícula: {aluno.Matricula}"); // Exibe a matrícula gerada automaticamente

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        aluno.Idade = int.Parse(Console.ReadLine());

        Console.Write("Nota 1: ");
        aluno.Nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        aluno.Nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3: ");
        aluno.Nota3 = double.Parse(Console.ReadLine());

        listaAlunos.Add(aluno);

        Console.WriteLine("\n✅ Cadastro realizado com sucesso!\n");

        return;
    }

    private static void ListarAlunos()
    {

        if (listaAlunos.Count == 0)
        {
            Console.WriteLine("\n Não há alunos cadastrados.\n");
            return;
        }
        else
        {
            Console.WriteLine("\n===== Lista de Alunos ======");
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"\n Matricula: {aluno.Matricula} \n Nome: {aluno.Nome} \n Nota 1: {aluno.Idade} \n Nota 1: {aluno.Nota1} \n Nota 2: {aluno.Nota2} \n Nota 3: {aluno.Nota3}");
            }
        }

    }

    private static void RemoverAluno()
    {

        if (listaAlunos.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para remover.");
        }

        Console.Write("\n===== Exclução de Alunos =====");

        Console.Write("\nDigite a matricula do aluno: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\nNúmero de inválido!");
            Console.Write("\n Informe uma matrícula valida: ");
        }

        Aluno aluno = listaAlunos.Find(a => a.Matricula == matricula);

        if (aluno == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        listaAlunos.Remove(aluno);
        Console.WriteLine("\n✅ Aluno removido com sucesso!");
    }

    private static void EditarAluno()
    {
        if (listaAlunos.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para editar.");
            return;
        }

        Console.Write("\n===== Edição de Alunos ======");
        Console.Write("\nDigite a matricula do aluno: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\nNúmero de inválido!");
            Console.Write("\n Informe uma matrícula valida: ");
        }

        Aluno aluno = listaAlunos.Find(a => a.Matricula == matricula);

        if (aluno == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        Console.Write($"\n Aluno encontrado: {aluno.Nome}");
        Console.WriteLine("\n 1. Informações do Aluno");
        Console.WriteLine("2. Notas do Aluno");
        Console.Write("\n O que deseja alterar: ");
        int edit = int.Parse(Console.ReadLine());

        switch (edit)
        {
            case 1:
                Console.WriteLine("\n Informações");
                Console.Write("1. Nome");
                Console.Write("\n 2. Idade");
                Console.Write("\n Escolha uma opção: ");
                int opcaoInfo = int.Parse(Console.ReadLine());

                if (opcaoInfo == 1)
                {
                    Console.WriteLine("Informe o novo nome: ");
                    string novoNome = Console.ReadLine();

                    aluno.Nome = novoNome;
                    Console.WriteLine("\n✅ Alterado com sucesso!");
                }
                else if (opcaoInfo == 2)
                {
                    Console.WriteLine("Informe a nova idade: ");
                    int novaIdade = int.Parse(Console.ReadLine());
                    aluno.Idade = novaIdade;
                    Console.WriteLine("\n✅ Alterado com sucesso!");
                }
                break;

            case 2:
                Console.WriteLine("\n Notas");
                Console.Write("1. Nota 1");
                Console.Write("\n 2. Nota 2");
                Console.Write("\n 3. Nota 3");
                Console.Write("\n Escolha uma opção: ");
                int opcaoNota = int.Parse(Console.ReadLine());

                if (opcaoNota == 1)
                {
                    Console.WriteLine("Informe a nova nota 1: ");
                    double novaNota1 = double.Parse(Console.ReadLine());
                    aluno.Nota1 = novaNota1;
                    Console.WriteLine("\n✅ Alterado com sucesso!");
                }
                else if (opcaoNota == 2)
                {
                    Console.WriteLine("Informe a nova nota 2: ");
                    double novaNota2 = double.Parse(Console.ReadLine());
                    aluno.Nota2 = novaNota2;
                    Console.WriteLine("\n✅ Alterado com sucesso!");
                }
                break;
        }
    }
}