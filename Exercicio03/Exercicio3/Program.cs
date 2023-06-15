using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args) // Método 
        {
            double Num1, Num2, Resultado = 0;
            char Operacao;

            Console.WriteLine("Entre com a Operação:");
            Console.WriteLine("+ ADIÇÃO==============:");
            Console.WriteLine("- SUBTRAÇÃO===========:");
            Console.WriteLine("* MULTIPLICAÇÃO======:");
            Console.WriteLine("/ DIVISÃO=============:");
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.Write("Operação: ");
            char.TryParse(Console.ReadLine(), out Operacao);


            Console.WriteLine();
            Console.Write("Informe o primeiro Valor: ");
            double.TryParse(Console.ReadLine(), out Num1);
            Console.WriteLine();
            Console.Write("Informe o segundo Valor: ");
            double.TryParse(Console.ReadLine(), out Num2);

            Console.WriteLine();

            switch (Operacao) //verificar condição
            {
                case '+': 
                   Resultado = Adicao(Num1, Num2);
                    break;

                case '-':
                    Resultado = Subtracao(Num1, Num2);
                    break;

                case '*':
                    Resultado = Multiplicacao(Num1, Num2);
                    break;

                case '/':
                    Resultado = Divisao(Num1, Num2);
                 break;       

            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Resultado);
            Console.ReadKey();


         
        }
        //métodos
        private static Double Adicao (double Num1, double Num2)
         {
        return (Num1 + Num2);
         }
         private static Double Subtracao(double Num1, double Num2)
         {
        return (Num1 - Num2);
         }
        private static Double Multiplicacao(double Num1, double Num2)
        {
            return (Num1 * Num2);
        }
        private static Double Divisao(double Num1, double Num2)
        {
            if (Num2 != 0)
                return Num1 / Num2;
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return 0;
            }
        }
    }

   
}
