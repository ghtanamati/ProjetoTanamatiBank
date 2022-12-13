using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTanamatiBank.Titular;

namespace ProjetoTanamatiBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public int NumAgencia
        {
            get { return this.NumAgencia; }
            set
            {
                if(value > 0)
                {
                    this.NumAgencia = value;
                }
            }
        }

        public string CCorrente { get; set; }

        private double saldo = 0;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            this.saldo = saldo + valor;
            Console.WriteLine($"\n{this.Titular} depositou R$ {valor}\nSaldo pós depósito: R$ {saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine($"\nSaldo insuficiente\nO seu saldo é: R$ {saldo}");
            }
            else if (valor <= saldo)
            {
                this.saldo = saldo - valor;
                Console.WriteLine($"\n{this.Titular} sacou R$ {valor}\nSaldo pós saque: R$ {saldo}");
            }
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (valor > saldo)
            {
                Console.WriteLine($"\nSaldo insuficiente\nO seu saldo é: R$ {saldo}");
            }
            else if (valor <= saldo)
            {
                this.saldo = saldo - valor;
                destino.saldo = saldo + valor;
                Console.WriteLine($"\n{this.Titular} trasferiu R$ {valor} para {destino.Titular}\nSaldo pós trasferência: R$ {saldo}");
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int NumAgencia, string CCorrente)
        {
            this.NumAgencia = NumAgencia; //"Obrigamos" o desenvolvedor/usuário a definir Agência
            this.CCorrente = CCorrente; // e Conta Corrente na criação do objeto.
        }
    }
}
