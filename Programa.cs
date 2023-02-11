using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaCorrente 
{
    class Program
    {
        public static void CabecalhoInicial()
        {
            Console.WriteLine("______  BEM VINDO  _______");
            Console.WriteLine("Vamos lá!! Este programa cria e realiza operações em contas bancarias");
            Console.WriteLine("Toda conta bancaria começa com saldo = 0\nE tem um ID de Conta Gerado aleatoriamente");
        }

        public static ContaCorrente CriarNovaConta()
        {
            Console.WriteLine("\nCriando uma nova conta");
            Console.Write("Digite o Nome do Correntista: ");
            string _nome = Console.ReadLine();
            return new ContaCorrente(_nome);
        }

        static void Main(string[] args)
        {

            int option;

            CabecalhoInicial();

            ContaCorrente c1 = CriarNovaConta();

            c1.ImprimeConta();

            do
            {
                Console.WriteLine("\nDigite a opção desejada");
                Console.WriteLine("1 - Imprimir todas informações");
                Console.WriteLine("2 - Realizar Saque");
                Console.WriteLine("3 - Realizar Deposito");
                Console.WriteLine("4 - Imprimir Saldo");
                Console.WriteLine("5 - Sair");

                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        c1.ImprimeConta();
                        break;

                    case 2:
                        Console.Write("Digite o valor do saque R$: ");
                        double.TryParse(Console.ReadLine(), out double _valorSaque);
                        c1.RealizarSaque(_valorSaque);
                        break;

                    case 3:
                        Console.Write("Digite o valor do deposito R$: ");
                        double.TryParse(Console.ReadLine(), out double _valorDeposito);
                        c1.RealizarDeposito(_valorDeposito);
                        break;

                    case 4:
                        Console.WriteLine("Saldo: " + c1.GetSaldo().ToString("C", CultureInfo.CurrentCulture));
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o Sistema...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção Invalida\nDigite Novamente");
                        break;
                }

            } while (option != 5);

            c1.ImprimeConta();

            Console.Read();

        }
    }
}
