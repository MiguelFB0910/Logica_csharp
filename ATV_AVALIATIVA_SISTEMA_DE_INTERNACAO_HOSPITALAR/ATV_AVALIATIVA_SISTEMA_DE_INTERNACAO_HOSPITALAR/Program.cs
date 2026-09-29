using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.AccessControl;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ATV_AVALIATIVA_SISTEMA_DE_INTERNACAO_HOSPITALAR
{
    internal class Program
    {

        public static string status = "", CPF = "", continuar = "s", NomePaciente = "", statusleito = "";
        public static int listarint = 0, transferidos = 0, altas = 0, totalLeitos = 0, totalmedicos = 0, totalpacientes = 0, leito = 0;
        public static bool EstaOcupado
            ;
        static void Main(string[] args)
        {
            int opcao = 8;

            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██║
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("---------------------------->");
                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Cadastrar Médico");
                Console.WriteLine("3 - Cadastrar Leito");
                Console.WriteLine("4 - Registrar Internação (Admissão)");
                Console.WriteLine("5 - Dar Alta Hospitalar");
                Console.WriteLine("6 - Listar Pacientes Internados");
                Console.WriteLine("7 - Exibir Relatorio Geral do Hospital");
                Console.WriteLine("0 - Sair do Programa");
                Console.WriteLine("---------------------------->");

                Console.WriteLine("Digite aqui uma das opções: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 8;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        FUNCAO_PACIENTE();
                       

                        break;
                    case 2:
                        Console.Clear();
                        CADASTRO_MEDICO();
                        totalmedicos++;

                        break;
                    case 3:
                        Console.Clear();
                        Funcao_Leito();


                        break;
                    case 4:
                        Console.Clear();
                        REGISTRAR_INTERNACAO();

                        break;
                    case 5:
                        Console.Clear();
                        DAR_ALTA();

                        break;
                    case 6:
                        Console.Clear();
                        LISTAR_PACIENTES_INTERNADOS();

                        break;
                    case 7:
                        Console.Clear();
                        EXIBIR_RELATORIO_GERAL();

                        break;
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SAINDO DO PROGRAMA EM 5 SEGUNDOS...");
                        Thread.Sleep(5000);
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Opção invalida! Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // 1 - CADASTRAR PACIENTE
        static void FUNCAO_PACIENTE()
        {
            string alergias, fone, TipoSanguineo;
            int id;
            DateTime DataNascimento;

            continuar = "s";
            while (continuar.ToLower() == "s")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                totalpacientes++;
                Console.WriteLine("---------------------------------------->");
                Console.WriteLine("\nIdentificador unico: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNome Completo do paciente: ");
                NomePaciente = Console.ReadLine();//AQUI DA O NOME DO PACIENTE PRA SER MOSTRADO POSTERIORMENTE
                Console.WriteLine("\nRegistro do paciente (CPF): ");
                CPF = Console.ReadLine();
                Console.WriteLine("\nData de nascimento (dd/MM/yyyy): ");
                DataNascimento = DateTime.Parse(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));
                Console.WriteLine("\nTipo sanguineo Ex: A+,O-,AB+,etc: ");
                TipoSanguineo = Console.ReadLine();
                Console.WriteLine("\nDescrição de alergias medicamentos/alimentares: ");
                alergias = Console.ReadLine();
                Console.WriteLine("\nNumero de telefone do responsavel: ");
                fone = Console.ReadLine();
                Console.WriteLine("---------------------------------------->");
                Console.WriteLine("\nCadastro realizado com sucesso!\nInformações Cadastradas Foram:");
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("\nNome do Paciente: " + NomePaciente);
                Console.WriteLine("\nCPF: " + CPF);
                Console.WriteLine("\nData de nascimento: " + DataNascimento);
                Console.WriteLine("\nTipo Sanguineo: " + TipoSanguineo);
                Console.WriteLine("\nDescrição(alergias em geral e medicamentos): " + alergias);
                Console.WriteLine("\nTelefone do Responsavel: " + fone);
                Console.WriteLine("---------------------------------------->");
                Console.WriteLine("\nDeseja cadastrar outro paciente? (s/n): ");
                continuar = Console.ReadLine();
            }
        }

        // 2 - CADASTRO MÉDICO
        static void CADASTRO_MEDICO()
        {
            int id;
            string nome, crm, especialidade, fone;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░░██████╗
████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗██╔════╝
██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║╚█████╗░
██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║░╚═══██╗
██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░╚═════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\nIdentificador Único: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNome Completo do(a) Profissional: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nRegistro do Conselho Regional de Medicina (CRM): ");
            crm = Console.ReadLine();
            Console.WriteLine("\nEspecialidade (Ex: Cardiologista, UTI, Cirurgia Geral): ");
            especialidade = Console.ReadLine();
            Console.WriteLine("\nTelefone de Contato Rápido: ");
            fone = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------->");
            Console.WriteLine("\nCadastro Concluído com êxito!");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CRM: " + crm);
            Console.WriteLine("Especialidade(s): " + especialidade);
            Console.WriteLine("Meio de Contato (Fone): " + fone);
            Console.WriteLine("\n-------------------------------------->");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }



        //3 FUNCAO LEITO
        static void Funcao_Leito()

        {
            string NumeroQuarto, Tipo;

            int id;



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░  ██╗░░░░░███████╗██╗████████╗░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗  ██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║  ██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║  ██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝  ███████╗███████╗██║░░░██║░░░╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░  ╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCadastre o leito!");

            while (continuar.ToLower() == "s")
            {

                Console.WriteLine("\nNúmero ou identificador do leito: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNúmero ou código do quarto/ala: ");
                NumeroQuarto = Console.ReadLine();
                Console.WriteLine("\nEx: Enfermeira, Apartamento, UTI: ");
                Tipo = Console.ReadLine();
                Console.WriteLine("\nStatus de ocupação (true = Ocupado /false = Livre");
                EstaOcupado = bool.Parse(Console.ReadLine());

                Console.WriteLine("\n-------------------------------------->");
                Console.WriteLine("\nCadastro Concluido com êxito\nAs Informações Cadastradas foram:");
                Console.WriteLine("\nID do leito: " + id);
                Console.WriteLine("\nNúmero/código quarto: " + NumeroQuarto);
                Console.WriteLine("\nDepartamento: " + Tipo);
                string resultado = "";
                if (EstaOcupado == true)
                {

                    resultado = "Ocupado!!";
                    leito++;
                }
                else
                {
                    resultado = "Livre!";
                    leito--;

                }
                Console.WriteLine("\nStatus de ocupação: " + resultado);
                Console.WriteLine("\n-------------------------------------->");
                Console.WriteLine("\nDeseja cadastrar outro leito ? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();
            }


        }







            // 4 - REGISTRAR INTERNAÇÃO
            static void REGISTRAR_INTERNACAO()
            {
                int pacienteld, medicores, leitold;
                DateTime dataentrada, dataalta;
                string diagentrada, cpf;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Digite o Cadastro de Pessoa Física (CPF): ");
                cpf = Console.ReadLine();
                if (cpf != CPF)
                {
                    Console.WriteLine("O CPF Inserido Não é Valido,Voltando ao Menu Principal em 5 Segundos!");
                    Thread.Sleep(5000);
                    return;
                }

                Console.WriteLine("\nCódigo do Paciente: ");
                pacienteld = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do Médico Responsável: ");
                medicores = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do Leito Alocado: ");
                leitold = int.Parse(Console.ReadLine());

                Console.WriteLine("\nData e hora de Admissão (dd/MM/yyyy HH:mm): ");
                dataentrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));

                Console.WriteLine("\nData e Hora da Alta : ");
                string entradaAlta = Console.ReadLine();
                dataalta = DateTime.ParseExact(entradaAlta, "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));
                Console.WriteLine("\nMotivo de Admissão: ");
                diagentrada = Console.ReadLine();
                Console.WriteLine("\nStatus Atual (Internado / Alta / Transferido): ");
                status = Console.ReadLine();

                if (status == "Internado")
                {
                    listarint++;
                }
                else if (status == "Alta")
            {
         
                altas++;
                }
                else if (status == "Transferido")
                {
   
                transferidos++;
                }

                Console.WriteLine("\n---------------------------------------->");
                Console.WriteLine("Cadastro Concluído com Sucesso!");
                Console.WriteLine("CPF: " + cpf);
                Console.WriteLine("Código Paciente: " + pacienteld);
                Console.WriteLine("Código Médico: " + medicores);
                Console.WriteLine("Código Leito: " + leitold);
                Console.WriteLine("Status Atual: " + status);
                Console.WriteLine("\n---------------------------------------->");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

            // 5 - DAR ALTA 
            static void DAR_ALTA()
            {
                string cpfpaciente;

                Console.Clear();
                Console.WriteLine(@"
░█████╗░██╗░░░░░████████╗░█████╗░  ██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██╔══██╗██║░░░░░╚══██╔══╝██╔══██╗  ██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░░░░░░░██║░░░███████║  ███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░░░░░░░██║░░░██╔══██║  ██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║███████╗░░░██║░░░██║░░██║  ██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");

                Console.WriteLine("CPF do(a) Paciente: ");
                cpfpaciente = Console.ReadLine();

                if (cpfpaciente == CPF)
                {
                    Console.WriteLine("\nStatus atual do paciente: " + status);

                    if (status == "Internado")
                    {
                        Console.WriteLine("\nO paciente estava Internado e recebeu alta com sucesso!");
                        status = "Alta";

                        if (listarint > 0)
                        {
                            listarint--;
                        }

                        altas++;
                    }
                    else if (status == "Alta")
                    {
                        Console.WriteLine("\nAviso: Este paciente já recebeu alta anteriormente!");
                    }
                    else if (status == "Transferido")
                    {
                        Console.WriteLine("\nAviso: Este paciente foi transferido!");
                    }
                    else
                    {
                        Console.WriteLine("\nStatus desconhecido.");
                    }
                }
                else
                {
                    Console.WriteLine("\nCPF não encontrado!");
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

            // 6 - LISTAR PACIENTES INTERNADOS
            static void LISTAR_PACIENTES_INTERNADOS()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░██████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║██████╔╝
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║██╔══██╗
███████╗██║██████╔╝░░░██║░░░██║░░██║██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░██████╗░░█████╗░░██████╗
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔════╝
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░██║██║░░██║╚█████╗░
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██║██║░░██║░╚═══██╗
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═════╝░");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("---------------------------------->");
                Console.WriteLine("Total de pacientes atualmente internados: " + listarint);

                if (CPF != "")
                {
                    Console.WriteLine("CPF do último paciente registrado: " + CPF);
                }

                Console.WriteLine("---------------------------------->");
                Console.WriteLine("\nPressione Qualquer Tecla para Voltar ao Menu Inicial:");
                Console.ReadKey();

            }

            // 7 - RELATÓRIO GERAL DO HOSPITAL
            static void EXIBIR_RELATORIO_GERAL()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(@"
██████╗░███████╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░██╗░█████╗░  ░██████╗░███████╗██████╗░░█████╗░██╗░░░░░
██╔══██╗██╔════╝██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗  ██╔════╝░██╔════╝██╔══██╗██╔══██╗██║░░░░░
██████╔╝█████╗░░██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝██║██║░░██║  ██║░░██╗░█████╗░░██████╔╝███████║██║░░░░░
██╔══██╗██╔══╝░░██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗██║██║░░██║  ██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░░░░
██║░░██║███████╗███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║██║╚█████╔╝  ╚██████╔╝███████╗██║░░██║██║░░██║███████╗
╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░  ░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n-------------------------------------------->");
                Console.WriteLine("\nTotal de Leitos Cadastrados: " + leito);
                Console.WriteLine("\nPacientes Atualmente Internados: " + listarint);
                Console.WriteLine("\nTotal de Altas Registradas: " + altas);
                Console.WriteLine("\nTotal de Transferências: " + transferidos);
                Console.WriteLine("\nTotal de Medicos: " + totalmedicos);
                Console.WriteLine("\nTotal de Pacientes: " + totalpacientes);
        
            Console.WriteLine("\n-------------------------------------------->");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();

            }
        }
    }
