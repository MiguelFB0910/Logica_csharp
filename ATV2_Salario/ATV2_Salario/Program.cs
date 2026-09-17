using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2_Salario
{/*2- faça um algoritmo que leia o valor do slaario minimo e o valor do slaario de um usuario
  * calcule quantos salarios minimos esse usuario ganha e imprima na tela o resultado.(base para o salario
  * minimo 1.518,00*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double salm, salp, calc;

            Console.WriteLine("Digite o valor do salário minimo atualmente: ");
            salm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salário atual: ");
            salp = double.Parse(Console.ReadLine());

            calc = salp / salm;


            Console.WriteLine("Você recebe " + calc + " Salarios minimos.");













        }
    }
}
