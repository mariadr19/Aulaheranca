using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaherança
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial conta = new ContaEspecial();
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Consultar Limite");
                Console.WriteLine("2 - Aumentar Limite");
                Console.WriteLine("3 - Diminuir Limite");
                Console.WriteLine("4 - Depositar");
                Console.WriteLine("5 - Sacar");
                Console.WriteLine("6 - Ver Saldo");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        conta.ConsultaLimite();
                        break;
                    case "2":
                        Console.Write("Informe o valor para aumentar o limite: ");
                        double valorAumentar = Convert.ToDouble(Console.ReadLine());
                        conta.AumentaLimite(valorAumentar);
                        break;
                    case "3":
                        Console.Write("Informe o valor para diminuir o limite: ");
                        double valorDiminuir = Convert.ToDouble(Console.ReadLine());
                        conta.DiminuiLimite(valorDiminuir);
                        break;
                    case "4":
                        Console.Write("Informe o valor para depósito: ");
                        double valorDepositar = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valorDepositar);
                        break;
                    case "5":
                        Console.Write("Informe o valor para saque: ");
                        double valorSacar = Convert.ToDouble(Console.ReadLine());
                        conta.Sacar(valorSacar);
                        break;
                    case "6":
                        conta.VerSaldo();
                        break;
                    case "7":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            Console.WriteLine("Operação finalizada.");
        }
    }
}