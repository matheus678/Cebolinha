using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase para saber a tradução em cebolês");
            string cebola = Console.ReadLine();
            Console.WriteLine( cebola .Replace("r", "l"));
        }
    }
}
