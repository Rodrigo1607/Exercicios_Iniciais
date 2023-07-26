using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string acao = "";
            string nome="", rg="", email="", telefone="" ;
            string caminho = "usuario.txt";

            Console.WriteLine("sssssssssssssssssssss");
            Console.WriteLine("G - Gravar ssssssssss");
            Console.WriteLine("L - Ler sssssssssssss");
            Console.WriteLine("S - Sair ssssssssssss");
            Console.WriteLine("sssssssssssssssssssss");
            Console.WriteLine("sssssssssssssssssssss");
            Console.Write("Digite uma opção: ");

            acao = Console.ReadLine().ToUpper();


            while (acao!="S")
            {
                if (acao == "G")
                {
                    Console.Write("Informe seu nome: ");
                        nome = Console.ReadLine();
                    Console.Write("Informe seu email: ");
                        email = Console.ReadLine();
                    Console.Write("Informe seu Telefone: ");
                        telefone = Console.ReadLine();
                    Console.Write("Informe seu RG: ");
                        rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine("Nome: " + nome);
                    sw.WriteLine("E-mail: " + email);
                    sw.WriteLine("Telefone: " + telefone);
                    sw.WriteLine("RG: " + rg);
                    sw.WriteLine("----------------------");

                    sw.Close();

                } else if(acao == "L")
                {
                    StreamReader sr = new StreamReader(caminho);
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                        sr.Close();
                }

                Console.WriteLine();
                Console.WriteLine("Digite uma tecla para continuar......");
                Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("sssssssssssssssssssss");
                    Console.WriteLine("G - Gravar ssssssssss");
                    Console.WriteLine("L - Ler sssssssssssss");
                    Console.WriteLine("S - Sair ssssssssssss");
                    Console.WriteLine("sssssssssssssssssssss");
                    Console.WriteLine("sssssssssssssssssssss");
                    Console.WriteLine("Digite uma opção: ");

                    acao = Console.ReadLine().ToUpper();


            }

        }
    }
}
