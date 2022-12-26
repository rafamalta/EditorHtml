using System.Text.RegularExpressions;

namespace EditorHTML
{
    internal class Visualizador
    {
        public static void Mostrar(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------");
            Substituir(texto);
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.Exibir();
        }

        public static void Substituir(string texto)
        {
            var negrito = new Regex(@"<\s*negrito[^>]*>(.*?)<\s*/\s*negrito>");
            Console.WriteLine(negrito);
        }
    }
}
