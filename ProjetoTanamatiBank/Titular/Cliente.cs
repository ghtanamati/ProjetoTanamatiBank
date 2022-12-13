using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTanamatiBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string Nome, string Cpf, string Profissao)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Profissao = Profissao;
        }
    }
}
