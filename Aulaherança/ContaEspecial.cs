using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaherança
{
    public class ContaEspecial : ContaCorrente
    {
        private double limite = 900;

        public double Limite
        {
            get => limite;
            set => limite = value;
        }

        public void ConsultaLimite()
        {
            Console.WriteLine("O Limite Atual é {0}", Limite);
        }

        public void DiminuiLimite(double valor)
        {
            if (valor > 0 && valor <= Limite)
            {
                Limite -= valor;
                Console.WriteLine("Limite diminuído. Novo limite: {0}", Limite);
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        public void AumentaLimite(double valor)
        {
            if (valor > 0)
            {
                Limite += valor;
                Console.WriteLine("Limite aumentado. Novo limite: {0}", Limite);
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
