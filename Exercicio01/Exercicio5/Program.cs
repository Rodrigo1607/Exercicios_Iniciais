using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine(); // passagem por parâmetro

            //Console.ReadKey();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(string.Format("Menu nome é: {0}", nome));

            Console.ReadKey();
        }
    }
}
