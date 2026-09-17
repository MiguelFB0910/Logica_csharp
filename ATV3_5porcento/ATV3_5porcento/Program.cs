using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV3_5porcento
{
    internal class Program
    {/*3- faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%*/
        static void Main(string[] args)
        {
            double v, a, t;
            Console.WriteLine("Digite um valor qualquer: ");
            v = double.Parse(Console.ReadLine());
            a = v * 0.05;
            t = v + a;

            Console.WriteLine("Seu valor recebeu um aumento de 5%, seu valor atual é: " + t);











        }
    }
}
