namespace EditorHTML
{
    static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();
            // altera a cor do fundo
            Console.BackgroundColor = ConsoleColor.Blue;
            // altera a cor da fonte
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Testando as cores");

            CriarLinhaSuperior();
            CriarColunas();
            CriarLinhaInferior();
            EscreverOpcoes();

            var opcao = short.Parse(Console.ReadLine());
            ManipularMenuOpcoes(opcao);
        }

        public static void CriarLinhaSuperior()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.WriteLine();
        }

        public static void CriarColunas()
        {
            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+");
        }

        public static void CriarLinhaInferior()
        {
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.WriteLine();
        }

        public static void EscreverOpcoes()
        {
            // posiciona o cursor na coluna e linha informada no parâmetro
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void ManipularMenuOpcoes(short opcao)
        {
            switch (opcao)
            {
                case 1: Console.WriteLine("Criar"); break;
                case 2: Console.WriteLine("Editar"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Exibir(); break;
            }
        }
    }
}
