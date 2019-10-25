using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class CompFab : IComparer<Veiculo>
    {
        public int Compare(Veiculo x, Veiculo y)
        {
            if (x.GetFabricante().CompareTo(y.GetFabricante()) != 0) return x.GetFabricante().CompareTo(y.GetFabricante());
            else return x.GetModelo().CompareTo(y.GetModelo());
        }
    }

    class CompMod : IComparer<Veiculo>
    {
        public int Compare(Veiculo x, Veiculo y)
        {
            if (x.GetModelo().CompareTo(y.GetModelo()) != 0) return x.GetModelo().CompareTo(y.GetModelo());
            else return x.GetPreco().CompareTo(y.GetPreco());
        }
    }
}
