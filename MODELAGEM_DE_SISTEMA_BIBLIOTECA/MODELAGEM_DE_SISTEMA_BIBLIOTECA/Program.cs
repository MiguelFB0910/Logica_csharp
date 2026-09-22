using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MODELAGEM_DE_SISTEMA_BIBLIOTECA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 6;


            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"

░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░██████╗░███████╗░██████╗████████╗░█████╗░░█████╗░  ██████╗░███████╗
██╔════╝░██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░██╗░█████╗░░╚█████╗░░░░██║░░░███████║██║░░██║  ██║░░██║█████╗░░
██║░░╚██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██║  ██║░░██║██╔══╝░░
╚██████╔╝███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░
██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Cadastrar Jogo");
                Console.WriteLine("3 - Cadastrar Cliente");
                Console.WriteLine("4 - Cadastrar Fornecedor");
                Console.WriteLine("5 - Regitrar Empréstimo");
                Console.WriteLine("0 - Sair do Sistema de Gestão de Biblioteca");
                Console.WriteLine("------------------------------>");


                opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcao)
                {

                    case 1:
                        CADASTRO_LIVRO();

                        break;
                    case 2:
                        CADASTRO_JOGO();

                        break;
                    case 3:
                        CADASTRO_CLIENTE();

                        break;
                    case 4:
                        CADASTRO_FORNECEDOR();

                        break;
                    case 5:
                        REGISTRAR_EMPRESTIMO();


                        break;
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        Console.ResetColor();
                        break;


                }
            }

        }


        static void CADASTRO_LIVRO()
        {

            int id, anopubli, qtdestoque;
            string titulo, autor, isbn, genero;//ISBN = Codigo de identificação internacional

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nIdentificador único(id): ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTitulo da Obra: ");
            titulo = Console.ReadLine();
            Console.WriteLine("\nAutor da Obra: ");
            autor = Console.ReadLine();
            Console.WriteLine("\nCódigo de identificação internacional(ISBN): ");
            isbn = Console.ReadLine();
            Console.WriteLine("\nAno de publicação(Lançamento): ");
            anopubli = int.Parse(Console.ReadLine());
            Console.WriteLine("\nGenero: ");
            genero = Console.ReadLine();
            Console.WriteLine("\nTotal de cópias em estoque:");
            qtdestoque = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------->");
            Console.WriteLine("\n" + id + " ;Identificador unico(id) do livro");
            Console.WriteLine("\n" + "Titulo da Obra: " + titulo);
            Console.WriteLine("\nAutor da Obra: " + autor);
            Console.WriteLine("\nISBN: " + isbn);
            Console.WriteLine("\nAno de publicação: " + anopubli);
            Console.WriteLine("\nGenero: " + genero);
            Console.WriteLine("\nQuantidade em estoque: " + qtdestoque);
            Console.WriteLine("\n-------------------------------->");
            Console.WriteLine("\nCadastro concluido com êxito!\nAguarde 5 segundos.");
            Thread.Sleep(5000);




           
            int opcao = 3;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("\n------------------------------>");
                Console.WriteLine("\n1 - Voltar ao menu inicial");
                Console.WriteLine("\n0 - Sair do Sistema");
                Console.WriteLine("\n------------------------------>");


                opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcao)
                {

                    case 1:

                        return;

                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        Console.ResetColor();
                        break;
                }
            }
        }
        static void CADASTRO_JOGO()
        {
            int id, faixaet, numminjog, nummaxjog, quantidadex;
            string nome, categoria;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██╗  ░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗╚═╝  ░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║░░░  ░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║░░░  ██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝██╗  ╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═╝  ░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░

██████╗░███████╗  ████████╗░█████╗░██████╗░██╗░░░██╗██╗░░░░░███████╗██╗██████╗░░█████╗░
██╔══██╗██╔════╝  ╚══██╔══╝██╔══██╗██╔══██╗██║░░░██║██║░░░░░██╔════╝██║██╔══██╗██╔══██╗
██║░░██║█████╗░░  ░░░██║░░░███████║██████╦╝██║░░░██║██║░░░░░█████╗░░██║██████╔╝██║░░██║
██║░░██║██╔══╝░░  ░░░██║░░░██╔══██║██╔══██╗██║░░░██║██║░░░░░██╔══╝░░██║██╔══██╗██║░░██║
██████╔╝███████╗  ░░░██║░░░██║░░██║██████╦╝╚██████╔╝███████╗███████╗██║██║░░██║╚█████╔╝
╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚═════╝░╚══════╝╚══════╝╚═╝╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nIdentificador único(id): ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNome do jogo: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nCategoria(Educativo/competitivo): ");
            categoria = Console.ReadLine();
            Console.WriteLine("\nFaixa etaria(Livre a 18+): ");
            faixaet = int.Parse(Console.ReadLine());
            Console.WriteLine("\nQuantidade Minima de participantes: ");
            numminjog = int.Parse(Console.ReadLine());
            Console.WriteLine("\nQuantidade Maxima de participantes: ");
            nummaxjog = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTotal em estoque: ");
            quantidadex = int.Parse(Console.ReadLine());
            Console.WriteLine("\n----------------------------------->");
            Console.WriteLine("\nInformações Inseridas de cadastro");
            Console.WriteLine("\n" + "Numero de identificação " + id);
            Console.WriteLine("\n" + "Nome Cadastrado " + nome);
            Console.WriteLine("\n" + "Categoria do jogo " + categoria);
            Console.WriteLine("\n" + "Faixa etaria recomendada " + faixaet);
            Console.WriteLine("\n" + numminjog + " ;Numero minimos de jogadores e " + nummaxjog + " ;Numero maximo de jogadores");
            Console.WriteLine("\n" + "Quantidade de exemplares do jogo em estoque " + quantidadex);
            Console.WriteLine("\n------------------------------------>");
            Console.WriteLine("\nCadastro concluido com êxito!\nAguarde 5 segundos.");
            Thread.Sleep(5000);





            int opcao = 3;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("\n------------------------------>");
                Console.WriteLine("\n1 - Voltar ao menu inicial");
                Console.WriteLine("\n0 - Sair do Sistema");
                Console.WriteLine("\n------------------------------>");


                opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcao)
                {

                    case 1:

                        return;

                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        Console.ResetColor();
                        break;
                }
            }


        }

        static void CADASTRO_CLIENTE()
        {
            int id;
            string nome, cpf, telefone, email;
            bool situacao;
            DateTime datanascimento;


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIdentificador unico(id): ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNome completo do(a) usuario(a): ");
            nome = Console.ReadLine();
            Console.WriteLine("\nCertificado de pessoa fisica(CPF): ");
            cpf = Console.ReadLine();
            Console.WriteLine("\nNumero de contato: ");
            telefone = Console.ReadLine();
            Console.WriteLine("\nEndereço de E-mail: ");
            email = Console.ReadLine();
            Console.WriteLine("\nData de nascimento (DD/MM/AAAA): ");
            datanascimento = DateTime.Parse(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));
            Console.WriteLine("\nSituação de Cadastro: ");
            situacao = bool.Parse(Console.ReadLine());
            Console.WriteLine("\n---------------------------------->");
            Console.WriteLine("\nIdentificador unico: " + id);
            Console.WriteLine("\nNome do(a) usuario(a): " + nome);
            Console.WriteLine("\nCertificado de pessoa fisica: " + cpf);
            Console.WriteLine("\nNumero de contato: " + telefone);
            Console.WriteLine("\nEndereço de E-mail: " + email);
            Console.WriteLine("\nData de nascimento: " + datanascimento);
            Console.WriteLine("\nSituação de cadastro: " + situacao);
            Console.WriteLine("------------------------------------>");
            Console.WriteLine("\nCadastro concluido com êxito!\nAguarde 5 segundos.");
            Thread.Sleep(5000);





            int opcao = 3;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("\n------------------------------>");
                Console.WriteLine("\n1 - Voltar ao menu inicial");
                Console.WriteLine("\n0 - Sair do Sistema");
                Console.WriteLine("\n------------------------------>");


                opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcao)
                {

                    case 1:

                        return;

                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        Console.ResetColor();
                        break;
                }
            }












        }
        static void CADASTRO_FORNECEDOR()
        {
            int id;
            string rsocial, cnpj, telefone, email, endereço;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nIdentificador unico(id): ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nRazão social(Nome juridico da empresa/editora): ");
            rsocial = Console.ReadLine();
            Console.WriteLine("\nRegistro nacional(CNPJ): ");
            cnpj = Console.ReadLine();
            Console.WriteLine("\nContato da empresa(Telefone): ");
            telefone = Console.ReadLine();
            Console.WriteLine("\nE-mail de contato comercial: ");
            email = Console.ReadLine();
            Console.WriteLine("\nLogradouro e cidade(Endereço): ");
            endereço = Console.ReadLine();
            Console.WriteLine("\n------------------------------>");
            Console.WriteLine("\nIdentificador Unico: " + id);
            Console.WriteLine("\nRazão social: " + rsocial);
            Console.WriteLine("\nCNPJ: " + cnpj);
            Console.WriteLine("\nContato da empresa: " + telefone);
            Console.WriteLine("\nEndereço de e-mail corporativo: " + email);
            Console.WriteLine("\nEndereço da empresa: " + endereço);
            Console.WriteLine("\n------------------------------>");
            Console.WriteLine("\nCadastro concluido com êxito!\nAguarde 5 segundos.");
            Thread.Sleep(5000);





            int opcao = 3;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("\n------------------------------>");
                Console.WriteLine("\n1 - Voltar ao menu inicial");
                Console.WriteLine("\n0 - Sair do Sistema");
                Console.WriteLine("\n------------------------------>");


                opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcao)
                {

                    case 1:

                        return;

                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        Console.ResetColor();
                        break;
                }
            }




        }
        static void REGISTRAR_EMPRESTIMO()
        {

            int id, clienteld, itemld;
            bool devolvido;
            string tipoitem;
            DateTime dataemprestimo, datadevolucaoprevista;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░╚█████╗░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██╔══██╗██╔══╝░░░╚═══██╗██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
██║░░██║███████╗██████╔╝╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
█████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nIdentificador unico: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCódigo do cliente associado: ");
            clienteld = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTipo de item(livro/jogo): ");
            tipoitem = Console.ReadLine();
            Console.WriteLine("\nCodigo do item(livro/jogo): ");
            itemld = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a data e hora de emprestimo(DD/MM/AAAA HH:MM): ");
            // Exemplo de entrada do usuário: 25/12/2000 14:30
            dataemprestimo = DateTime.Parse(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));
            Console.WriteLine("\nDigite a data e hora limite de devolução(DD/MM/AAAA HH:MM): ");
            // Exemplo de entrada do usuário: 25/12/2000 14:30
            datadevolucaoprevista = DateTime.Parse(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));
            Console.WriteLine("\nStatus de devolução(false = não entregue|true = entregue): ");
            devolvido = bool.Parse(Console.ReadLine());
            Console.WriteLine("\n-------------------------------------->");
            Console.WriteLine("\nIdentificador unico " + id);
            Console.WriteLine("\nCodigo de cliente associado " + clienteld);
            Console.WriteLine("\nTipo de item: " + tipoitem);
            Console.WriteLine("\nCodigo de item: " + itemld);
            Console.WriteLine("\nData de emprestimo: " + dataemprestimo);
            Console.WriteLine("\nData de devolução prevista: " + datadevolucaoprevista);
            Console.WriteLine("\n-------------------------------------->");
            Console.WriteLine("\nCadastro concluido com êxito!\nAguarde 5 segundos.");
            Thread.Sleep(5000);





            int opcao = 3;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("\n------------------------------>");
                Console.WriteLine("\n1 - Voltar ao menu inicial");  
                Console.WriteLine("\n0 - Sair do Sistema");
                Console.WriteLine("\n------------------------------>");


                opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcao)
                {

                    case 1:

                        return;

                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        Console.ResetColor();
                        break;
                }
            }

                /*

                   1.Criação da Solução: Crie um projeto do tipo.

                   2.Criação de Funções: Adicione um arquivo separado para cada classe(Livro, Jogo, Cliente, Fornecedor, Empréstimo).

                   3.Em cada função deverá ter AO MENOS UM dos recursos aplicados como: IF, ELSE, FOR, SWITCH, WHILE.

                 */
            }




























        }
    }


