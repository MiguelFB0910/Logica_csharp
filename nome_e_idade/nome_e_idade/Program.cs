using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nome_e_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;//variavel cadeia = string
            int idade;//variavel inteiro = int

            Console.WriteLine("Digite seu nome: ");//escreva = console.writeline()
            nome= Console.ReadLine();//leia
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());//converte o que digitar para inteiro
            Console.WriteLine("Parabéns " + nome + " Você acabou de ganhar uma Coca-Cola!");
            Console.WriteLine("\nVocê possui " + idade + " anos, beba mais água");

        }
    }
}
