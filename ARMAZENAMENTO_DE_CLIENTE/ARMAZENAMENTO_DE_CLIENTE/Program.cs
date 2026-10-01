using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMAZENAMENTO_DE_CLIENTE
{
    internal class Program
    {
        /* Desenvolva um programa que armazene o historico de 10 clientes e mostre o total gasto por cada cliente*/
        static void Main(string[] args)
        {
            Console.Clear();

            string[] Clientes = new string[10];
            int[] Gasto = new int[10];
            int totalGeral = 0;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < Clientes.Length; i++)
            {
                Console.Clear();
                Console.Write($"Nome do Cliente {i + 1}: ");
                Clientes[i] = Console.ReadLine();

                Console.Write($"Qual o Gasto do(a) {Clientes[i]}: R$ ");
                Gasto[i] = int.Parse(Console.ReadLine());

                totalGeral += Gasto[i];
                Console.WriteLine(); 
            }
            Console.ResetColor();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
        
            Console.WriteLine("=== HISTÓRICO DE GASTO DOS CLIENTES ===");

            for (int i = 0; i < Clientes.Length; i++)
            {
                Console.WriteLine("\n===================================>");
                Console.WriteLine("Cliente: " + Clientes[i]);
                Console.WriteLine("Gasto Do Cliente: R$ " + Gasto[i]);
                Console.WriteLine("===================================>");
            }

            
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"TOTAL GERAL GASTO POR TODOS: R$ {totalGeral}");
            Console.WriteLine("-----------------------------------");

         
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}