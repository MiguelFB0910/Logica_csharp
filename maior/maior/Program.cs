using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero: ");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quinto numero: ");
            n5= double.Parse(Console.ReadLine());
            if(n1 > n2 & n1 > n3 & n1 > n4 & n1 > n5)
            {
                Console.WriteLine("O maior numero é " + n1);
            }
            if (n2 > n1 & n2 > n3 & n2 > n4 & n2 > n5)
            {
                Console.WriteLine("O maior numero é " + n2);
            }
            if (n3 > n1 & n3 > n2 & n3 > n4 & n3 > n5)
            {
                Console.WriteLine("O maior numero é " + n3);
            }
            if (n4 > n1 & n4 > n2 & n4 > n3 & n1 > n5)
            {
                Console.WriteLine("O maior numero é " + n4);
            }
            if (n5 > n1 & n5 > n2 & n5 > n3 & n5 > n4)
            {
                Console.WriteLine("O maior numero é " + n5);
            }
            else {
                Console.WriteLine("\nTodos são iguais!");
            }













        }
    }
}
