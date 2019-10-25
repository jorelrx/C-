using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Cliente
    {
        private string nome, cpf;
        private decimal limite;
        private List<Cliente> soc = new List<Cliente>();
        public decimal LimTotal { set; get; }
        public string GetNome()
        {
            return nome;
        }
        public decimal GetLimite()
        {
            return limite;
        }
        public Cliente(string n, string c, decimal i)
        {
            nome = n;
            cpf = c;
            limite = i;
        }
        public void Inserir(Cliente c)
        {
            soc.Add(c);
        }
        public void Excluir(Cliente c)
        {
            soc.Remove(c);
        }
    }
}
