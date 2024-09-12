using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaherança
{
    public class ContaCorrente
    {
        private string numeroConta;
        private string titularConta;
        private double saldo;

        public string NumeroConta { get => numeroConta; set => numeroConta = value; }
        public string TitularConta { get => titularConta; set => titularConta = value; }
        public double Saldo { get => saldo; }

        public void Depositar(double _saldo)
        {
            if (_saldo > 0)
            {
                saldo += _saldo;
                Console.WriteLine("Depósito realizado com sucesso. Saldo atual: {0}", saldo);
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public void Sacar(double _saldo)
        {
            if (_saldo > 0 && _saldo <= saldo)
            {
                saldo -= _saldo;
                Console.WriteLine("Saque realizado com sucesso. Saldo atual: {0}", saldo);
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
        public void VerSaldo()
        {
            Console.WriteLine("Saldo atual: {0}", saldo);
        }
    }

}

