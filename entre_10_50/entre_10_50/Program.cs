using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entre_10_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite seu numero: ");
            n1 = double.Parse(Console.ReadLine());
            if( n1 >= 10 & n1 <= 50)
            {
                Console.WriteLine("Seu numero esta entre 10 e 50");
            }
            else
            {
                Console.WriteLine("Seu numero não esta entre 10 e 50 ");
            }















        }
    }
}
