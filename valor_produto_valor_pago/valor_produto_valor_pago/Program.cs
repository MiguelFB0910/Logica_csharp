using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valor_produto_valor_pago
{
    internal class Program
    {/* faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento*/

        static void Main(string[] args)
        {

            double valorp, total, desconto;
            string pag;

            Console.WriteLine("Digite o valor do produto: ");
            valorp = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a forma de pagamento(Dinheiro,Pix,Credito,2x,3x): ");
             pag = Console.ReadLine();

            
            if(pag == "Dinheiro" && pag == "Pix")
            {
                desconto = valorp * 0.15;
                total = valorp - desconto;
                Console.WriteLine("Você recebeu  15% de desconto,o valor a ser pago é de: " + total);
            }
            if (pag =="Credito")
            {
                desconto = valorp * 0.10;
                total = valorp - desconto;
                Console.WriteLine("Você recebeu 10% de desconto,o valor a ser pago é de: " + total);
            }
            if(pag == "2x")
            {
                Console.WriteLine("Total de:" + valorp);

            }
            if (pag == "3x")
            {
                total = valorp * 1.10;

                Console.WriteLine("Seu produto recebeu um juros de 10%,total a ser pago é de: " + total);
            }




















        }
    }
}
