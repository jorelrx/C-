using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Loja
    {
        private string nome;
        private List<Veiculo> veiculos = new List<Veiculo>();
        public Loja(string n) { nome = n; }
        public void Inserir(Veiculo v)
        {
            veiculos.Add(v);
        }
        public void Excluir(Veiculo v)
        {
            veiculos.Remove(v);
        }
        public decimal CalcTotal()
        {
            decimal p = 0;
            foreach (Veiculo x in veiculos) if (x.GetVendidos() == false) p += x.GetPreco();
            return p;
        }
        public Veiculo BuscarPlaca(string p)
        {
            foreach (Veiculo x in veiculos) if (x.GetPlaca() == p) return x;
            return null;
        }
        public Veiculo[] BuscarValor(decimal buscValor)
        {
            List<Veiculo> d = new List<Veiculo>();
            foreach (Veiculo x in veiculos) if (x.GetVendidos() == false && x.GetPreco() <= buscValor) d.Add(x);
            Veiculo[] v = d.ToArray();
            return v;
        }
        public Veiculo[] ListarPorFabricante()
        {
            Veiculo[] v = veiculos.ToArray();
            Array.Sort(v, new CompFab());
            return v;
        }
        public Veiculo[] ListarPorModelo()
        {
            Veiculo[] v = veiculos.ToArray();
            Array.Sort(v, new CompMod());
            return v;
        }
    }
}
