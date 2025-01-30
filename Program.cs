
class GSE
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("====== Sistema Escolar ======");
            Console.WriteLine("1. Gerenciamento de Alunos");
            Console.WriteLine("2. Gerenciamento de Turmas");
            Console.WriteLine("3. Gerenciamento de Disciplinas");
            Console.WriteLine("4. Geração de Relatorio");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            int option = int.Parse(Console.ReadLine());

            // Utilizar 


            Action acao = option switch
            {
                1 => GerAlunos,
                2 => () => { /* Lógica do case 2 */ }
                ,
                3 => () => { /* Lógica do case 3 */ }
                ,
                4 => () => { /* Lógica do case 4 */ }
                ,
                5 => () =>
                {
                    Console.WriteLine("\n Saindo...");
                    Environment.Exit(0); // Sai do programa imediatamente
                }
                ,
                _ => () => Console.WriteLine("Opção inválida!")
            };

            acao(); // Executa a ação correspondente
        }
    }


    private static void GerAlunos()
    {
        Alunos alunos = new Alunos();
        Alunos.GerAlunos();
    }

    private static void GerTurmas()
    {
        Turmas turmas = new Turmas();
        Turmas.GerTurmas();
    }



}