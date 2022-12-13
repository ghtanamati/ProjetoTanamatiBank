using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTanamatiBank.Contas;
using ProjetoTanamatiBank.Titular;

namespace ProjetoTanamatiBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteAlice = new Cliente("Alice", "147.617.978-88","Professora");

            ContaCorrente contaDaAlice = new ContaCorrente(1,"0001-X");

            ContaCorrente contaDoBob = new ContaCorrente(1, "0002-X");
            
            contaDoBob.Titular = new Cliente("Bob", "174.123.197-55", "Veterinário");
        }
    }
}