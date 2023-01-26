using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuSuperBanco.ContaBanco contaB = new ContaBanco("Diogo", 10000);
            Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");


            contaB.Depositar(1, DateTime.Now, "Recebi um pagamento");
            Console.WriteLine($"A conta está com {contaB.Saldo} Reais");

            contaB.Sacar(133000, DateTime.Now, "Pagamento de pix");
            Console.WriteLine($"A conta está com {contaB.Saldo} Reais");
        }
    }
}
