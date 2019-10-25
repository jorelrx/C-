using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial(string t, string n, double l) : base(t, n) { limite = l; }
        public override bool Sacar(double valor)
        {
            if (valor > 0 && RetornarSaldo() + limite >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Titular: {RetornarTitular()} \nNumero da conta: {RetornarNumeroDaConta()} \nSaldo: {RetornarSaldo()} \nLimite: {limite}";
        }
    }
}
