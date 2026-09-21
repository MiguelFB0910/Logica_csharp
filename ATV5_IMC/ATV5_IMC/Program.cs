using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV5_IMC
{
    internal class Program
    {/*faça um algoritmo que calcule o IMC(indice de masssa corporal) de uma pessoa,leia o seu peso e sua altura
      * e imprima na tela sua condição de acordo com a tabela abaixo
      * formula do imc = peso / (altura)²
      * tabela condiçoes IMC
      * 
      *Abaixo de 18,5 = abaixo do peso
      *entre de 18,6 e 24,9 = peso ideal(parabens)
      *entre 25,0 e 29,9 = levemente acima do peso
      *Entre 30,0 e 34,9 = obesidade grau 1
      *entre 35,0 e 39,9 obesidade grau 2(severa)
      *maior ou igual a 40 = obesidade grau 3 (morbida)
      */ 
     
        static void Main(string[] args)
        {

            double peso, altura, total;


            Console.WriteLine("Digite aqui seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui sua altura: ");
            altura = double.Parse(Console.ReadLine());

            total = peso / (altura/altura);


            if (total < 18.5){
                Console.WriteLine("Abaixo do peso.");
            }
            if(total >= 18.6 && total <= 24.9)
            {
                Console.WriteLine("Peso Ideal(Parabéns!).");
            }
            if (total >= 25.0 && total <= 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
            }
            if(total >= 30.0 && total <= 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            if (total >= 35.0 && total <= 39.9)
            {
                Console.WriteLine("Obesidade grau II(severa)");
            }
            if(total >= 40)
            {
                Console.WriteLine("Obesidade grau III(mórbida)");
            }














        }
    }
}
