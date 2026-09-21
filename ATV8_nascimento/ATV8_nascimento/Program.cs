using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV8_nascimento
{
    internal class Program
    {/* 8. faça um algoritmo que leia o ano em que uma pessoa nasceu,imprima na tela quantos anos,meses e dias essa pessoa ja viveu.
      * leve em consideração o ano com 365 dias e o mes com 30 dias.(ex: 5 anos, 2 meses e 15 dias de vida)*/

        static void Main(string[] args)
        {
            int ano, mes, dia, a, m, d, anof, diaf, mesf;
            Console.WriteLine("Data atual: 21/09/2026");
            d = 21;
            m = 09;
            a = 2026;
            Console.WriteLine("Digite seu ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu mês de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu dia de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            diaf = d - dia;
            mesf = mes - m;
            anof = a - ano;
            Console.WriteLine("Você tem " + anof +" Anos de vida, " + mesf + " Meses de vida; " + diaf +" Dias de vida");
            
            















        }
    }
}
