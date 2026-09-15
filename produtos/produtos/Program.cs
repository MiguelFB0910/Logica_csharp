using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fabricante, categoria;
            int codigo, estoque;
            double preco, total;

            Console.WriteLine("Digite o código: ");
            codigo=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine("Digite categoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("Digite o preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());
            total = preco * estoque;// *vezes / dividir + soma - subtração
                Console.WriteLine("O valor total em estoque é " + total);










        }
    }
}
