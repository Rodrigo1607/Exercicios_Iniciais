using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nome;

            Console.Write("Digite o nome: ");
            Nome = Console.ReadLine();

            //Console.WriteLine(string.Format("Nome : (0)", Nome));
           // Console.WriteLine("Nome: " + Nome);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Nome);


            Console.ReadKey();
        }
    }
}
