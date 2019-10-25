using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class CompararNome : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            return x.GetNome().CompareTo(y.GetNome());
        }
    }

    class CompararLimite : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            return x.GetLimite().CompareTo(y.GetLimite());
        }
    }
}
