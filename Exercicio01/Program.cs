using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
           
         int NumeroDigitado;

         Console.Write("Insira um Número: ");

         NumeroDigitado = Convert.ToInt32(Console.ReadLine()); // Lê e converte para inteiro

            if (NumeroDigitado % 2 == 0)
            {
                Console.WriteLine("É Par");
            }
            else
            { 
                Console.WriteLine("É Ímpar");
            }

         Console.WriteLine(NumeroDigitado.ToString());
            
         Console.ReadKey();
                   


        }
    }
}
