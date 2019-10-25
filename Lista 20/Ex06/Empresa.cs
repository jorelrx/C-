using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Empresa
    {
        private List<Cliente> lista = new List<Cliente>();
        public void Inserir(Cliente c)
        {
            lista.Add(c);
        }
        public void Excluir(Cliente c)
        {
            lista.Remove(c);
        }
        public void Socios(Cliente x, Cliente y)
        {
            x.Inserir(y);
            y.Inserir(x);
        }
        public List<Cliente> ListarNome()
        {
            List<Cliente> l = lista;
            l.Sort(new CompararNome());
            return l;
        }
        public List<Cliente> ListarLimite()
        {
            List<Cliente> l = lista;
            l.Sort(new CompararLimite());
            return l;
        }
        public List<Cliente> ListarNaoSocio()
        {
            List<Cliente> l = new List<Cliente>();
            foreach (Cliente x in lista)
                if (x.GetLimite() == x.LimTotal)
                    l.Add(x);
            return l;
        }
    }
}
