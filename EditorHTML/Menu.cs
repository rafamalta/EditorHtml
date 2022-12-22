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
    }
}
