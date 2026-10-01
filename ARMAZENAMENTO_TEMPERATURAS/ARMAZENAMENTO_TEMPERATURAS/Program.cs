using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMAZENAMENTO_TEMPERATURAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] Dias = { "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado", "Domingo" };
            
            int[] Temperaturas = new int[7];

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int j = 0; j < 7; j++)
            {
                Console.Write($"Digite a temperatura de {Dias[j]}: ");
                Temperaturas[j] = int.Parse(Console.ReadLine());
            }

            int indiceMaisQuente = 0;
            int indiceMaisFrio = 0;

            for (int j = 1; j < 7; j++)
            {
                if (Temperaturas[j] > Temperaturas[indiceMaisQuente])
                {
                    indiceMaisQuente = j;
                }

                if (Temperaturas[j] < Temperaturas[indiceMaisFrio])
                {
                    indiceMaisFrio = j;
                }
            }
            Console.ResetColor();
 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("RESULTADOS DA SEMANA ");
            Console.WriteLine($"\nO dia mais quente foi {Dias[indiceMaisQuente]} com {Temperaturas[indiceMaisQuente]}°C.");
            Console.WriteLine($"\nO dia mais frio foi {Dias[indiceMaisFrio]} com {Temperaturas[indiceMaisFrio]}°C.");

            Console.WriteLine("\n----------------------------------------->");
            Console.WriteLine("\nPressione Qualquer Botão Para Sair Do Sistema");
            Console.ReadKey();



        }
    }
}