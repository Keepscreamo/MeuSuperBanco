using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco
{
    internal class ContaBanco
    {
        public string Numero { get; set; }
        public string Dono { get; set; }
        public decimal Saldo 
        { 
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes)
                {
                    saldo += item.Valor;
                }
                return saldo;
                        }

        }

        public static int numeroConta = 1234567890;

        private List<Transacao> todasTransacoes = new List<Transacao>();

        public ContaBanco(string nome, decimal valor)
        {
                this.Dono = nome;
         

            numeroConta++;

            this.Numero = numeroConta.ToString();
            Depositar (valor, DateTime.Now, "Saltado Inicial");
           }

        public void Depositar (decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não é possivel depositar esse valor");
            }
            Transacao trans = new Transacao(valor, data, obs);
            todasTransacoes.Add(trans);
        }

        public void Sacar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não é possivel sacar esse valor");
            }

            if (Saldo - valor <= 0 )
            {
                throw new ArgumentOutOfRangeException("Operação inválida, seu saldo ficará negativo");
            }
            Transacao trans = new Transacao(-valor, data, obs);
            todasTransacoes.Add(trans);
        }
    }
}
