using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMAZENAMENTO_FRUTAS
{
    internal class Program
    {// implemente um sistema que armazene as quantidades de 5 tipos de frutas em 3 cestas e calcule
     // o total de frutas de cada tipo.
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Armazenamento de Frutas");
            Console.ResetColor();


            string[] Frutas = {"Bacate", "Laranja", "Maçã","Pera","Uva",};
            int[] Cesta1 = new int[5];
            int[] Cesta2 = new int[5];
            int[] Cesta3 = new int[5];
            int[] totais = new int[5];

            Console.WriteLine("\n--- Digite as quantidades para a CESTA 1 ---");
            for (int i = 0; i < Frutas.Length; i++)
            {
                Console.Write($"Quantidade de {Frutas[i]}: ");
                Cesta1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n--- Digite as quantidades para a CESTA 2 ---");
            for (int i = 0; i < Frutas.Length; i++)
            {
                Console.Write($"Quantidade de {Frutas[i]}: ");
                Cesta2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n--- Digite as quantidades para a CESTA 3 ---");
            for (int i = 0; i < Frutas.Length; i++)
            {
                Console.Write($"Quantidade de {Frutas[i]}: ");
                Cesta3[i] = int.Parse(Console.ReadLine());
            }




            Console.Clear();


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nLISTAGEM DE FRUTAS EM CESTAS");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < Frutas.Length; i++)
            {

                Console.WriteLine("\nFruta: " + Frutas[i]);
                Console.WriteLine("\nTotal Dessa Fruta Na Primeira Cesta: " + Cesta1[i]);
                Console.WriteLine("\nTotal Dessa Fruta Na Segunda Cesta: " + Cesta2[i]);
                Console.WriteLine("\nTotal Dessa Fruta Na Terceira Cesta: " + Cesta3[i]);
                Console.WriteLine("\n----------------------------------->");
            }
            Console.WriteLine("Pressione Qualquer Botão Para Sair: ");
            Console.ReadKey();









        }
    }
}
