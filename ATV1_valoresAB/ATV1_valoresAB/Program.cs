using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATV1_valoresAB
{/* Faça um algoritimo que leia dois valores inteiros A e B, se os valores de A e B forem iguais
  * devera somar os dois valores.
  * caso contrario devera multiplicar A por B. ao final de qualquer um dos calculos deve-se atribuir o resultado
  * a uma variavel C e imprimir seu valor na tela.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, res;


            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            if (v1 == v2) 
            {
                res = v1 + v2;
            }
            else
            {
                res = v1 * v2;
            }
            Console.WriteLine("A resolução da equação é " + res);

          











        }
    }
}
