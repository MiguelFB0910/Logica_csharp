using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV4_booleanos
{
    internal class Program
    {/* faça um algoritmo que leia dois valroes booleanos(logicos) e determine se ambos são verdadeiro
      * ou falso.*/
        static void Main(string[] args)
        {
            bool v1, v2;
            bool valores;

            Console.WriteLine("Digite o primeiro valor(false ou true): ");
            v1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor(false ou true): ");
            v2 = bool.Parse(Console.ReadLine());
            valores = v1 && v2;

            if (v1 == v2) 
            {
                valores = true;
                Console.WriteLine("Seus valores são Verdadeiros!");
            }
            else
            {
                valores = false;
                Console.WriteLine("Seus valores são falsos!");
            }






        }
    }
}
