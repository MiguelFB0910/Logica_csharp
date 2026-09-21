using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ATV9_temperatura
{
    internal class Program
    {/* faça um algoritmo que leia uma temperatura em farenheit e calcule a temperatura correspondente em graus celsius.imprima na tela as duas temperaturas*/

        static void Main(string[] args)
        {
            int far, c;
            Console.WriteLine("Digite uma temperatura em farenheit: ");
            far = int.Parse(Console.ReadLine());

            c = (5 * (far - 32) / 9);

            Console.WriteLine("Sua temperatura em graus celsius é " + c);















        }
    }
}
