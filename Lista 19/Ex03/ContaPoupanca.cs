using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaPoupanca : ContaCorrente
    {
        public ContaPoupanca(string t, string n) : base(t, n) { }
        public void Render(double juros)
        {
            saldo += juros / 100 * RetornarSaldo();
        }
    }
}
