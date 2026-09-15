using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            string nome;



            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quarta nota: ");
            n4 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("O nome do alune é " + nome + " e a media dele é " + media);










        }
    }
}
