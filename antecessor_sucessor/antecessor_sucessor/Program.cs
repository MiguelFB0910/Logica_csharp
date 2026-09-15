using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antecessor_sucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, menor, maior;
            Console.WriteLine("Escolha um numero: ");
            num1 = int.Parse(Console.ReadLine());
            maior = num1 + 1;
            menor = num1 - 1;
            Console.WriteLine("O antecessor do seu numero é: " + menor);
            Console.WriteLine("\nO sucessor de seu numero é: " + maior);







        }
    }
}
