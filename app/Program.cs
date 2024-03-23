using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        class program
        {
            static void Main(string[] args)
            {
                double num1, num2, total;
                string nome;
                Console.Write("Insira seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Olá " + nome + ", seja bem-vindo!!");
                Console.ReadKey();

                Console.Write("Digite um número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.ReadLine();
                Console.Write("Digite outro número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.ReadLine();

                total = num1 + num2;
                Console.WriteLine("Somando " + num1 + " com " + num2 + " o resultado será: " + total);
                Console.ReadKey();

                Console.Write("É isso, obrigado :)")
                Console.Write("Feito por Marcos, Michel e Pedro" )



            }
        }
    }

}
    