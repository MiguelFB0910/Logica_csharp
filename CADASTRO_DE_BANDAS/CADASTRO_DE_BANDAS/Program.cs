using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CADASTRO_DE_BANDAS
{
    internal class Program
    {/*
      * se / enquanto / para / caso
      * if / while / for / switch
      * Crie um sistema de cadastro de Álbuns de um artista /banda en qye sera possivel cadastrar um numero x de musicas
      * informadas pelo usuario. crie um menu de opções para isso.
      */
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.Clear();   // limpa tela
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" 1 - Cadastrar album da Banda");
                Console.WriteLine("\n 2 - Cadastrar album do Artista");//ano nome artista qtd album, qtd vendas
                Console.WriteLine("\n 3 - Cadastrar musicas do Album");//digitar a qtd musicas a cadastrar (nome musica duração premiação)
                Console.WriteLine("\n 4 - Sair do programa");
                Console.WriteLine("\n -----> ");


                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CADASTRO_BANDAS();
                        break;
                    case 2:
                        CADASTRO_ALBUM_ARTISTA();
                        break;
                    case 3:
                        CADASTRO_MUSICAS_DO_ALBUM();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" Saindo do Programa ");
                        Console.ResetColor();
                        break;
                }


            }
        }

        static void CADASTRO_BANDAS()
        {
            string nomebanda, nomealbum;
            int qtdmusicas;

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
            Console.ResetColor();



            Console.WriteLine("\nDigite o nome da Banda: ");
            nomebanda = Console.ReadLine();
            Console.WriteLine("\nDigite o nome do album: ");
            nomealbum = Console.ReadLine();
            Console.WriteLine("\nDigite o numero de Musicas: ");
            qtdmusicas = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCadastro realizado com êxito!");
            Console.WriteLine("\n" + nomebanda);
            Console.WriteLine("\n" + nomealbum);
            Console.WriteLine("\n" + qtdmusicas);
            Thread.Sleep(5000);
            
        }
        static void CADASTRO_ALBUM_ARTISTA()
        {
            string nomeart;
            int qtdalb, qtdvendas, anoalbum;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░██╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░██║██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ███████║██║░░░░░██████╦╝██║░░░██║██╔██╗██║╚█████╗░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚████║░╚═══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██║░░██║███████╗██████╦╝╚██████╔╝██║░╚███║██████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nDigite o ano do album: ");
            anoalbum = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o nome do artista: ");
            nomeart = Console.ReadLine();
            Console.WriteLine("\nDigite o numero de albuns: ");
            qtdalb = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o numero de vendas: ");
            qtdvendas = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCadastro realizado com êxito!");

            Console.WriteLine("\n" + anoalbum);
            Console.WriteLine("\n" + nomeart);
            Console.WriteLine("\n" + qtdalb);
            Console.WriteLine("\n" + qtdvendas);
            Thread.Sleep(8000);

        }

        static void CADASTRO_MUSICAS_DO_ALBUM()
        {
            string nomemus, nomealb;
            int qtdmusicas, contador = 0, duracao, prem;
           

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"


░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░░██████╗  ██████╗░░█████╗░
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔══██╗
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║╚█████╗░  ██║░░██║██║░░██║
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║░╚═══██╗  ██║░░██║██║░░██║
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║██████╔╝  ██████╔╝╚█████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░  ╚═════╝░░╚════╝░

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░██╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░██║
███████║██║░░░░░██████╦╝██║░░░██║██╔██╗██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚████║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚███║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░╚══╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nDigite o nome do album: ");
            nomealb = Console.ReadLine();
            Console.WriteLine("Digite a qauntidade de musicas a serem cadastradas nesse album: ");
            qtdmusicas = int.Parse(Console.ReadLine());

            for (contador = 0; contador <= qtdmusicas; contador++) {


                Console.WriteLine("\nDigite o nome da musica: ");
                nomemus = Console.ReadLine();
                Console.WriteLine("\nDigite a duração da musica em minutos: ");
                duracao = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o numero de premiações: ");
                prem = int.Parse(Console.ReadLine());
                Console.WriteLine("\nCadastro realizado com êxito!");

                Console.WriteLine("\n" + qtdmusicas);
                Console.WriteLine("\n" + nomemus);
                Console.WriteLine("\n" + duracao);
                Console.WriteLine("\n" + prem);
                Thread.Sleep(8000);

            }
            



        }







    }
}
