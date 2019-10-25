using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaCorrente
    {
        private string titular, numeroDaConta;
        protected double saldo;
        public ContaCorrente(string t, string n)
        {
            titular = t;
            numeroDaConta = n;
        }
        public void Depositar(double valor)
        {
            if (valor > 0) saldo += valor;
        }
        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public double RetornarSaldo() { return saldo; }
        public string RetornarTitular() { return titular; }
        public string RetornarNumeroDaConta() { return numeroDaConta; }
        public override string ToString()
        {
            return $"Titular: {titular} \nNumero da conta: {numeroDaConta} \nSaldo: {saldo}";
        }
    }
}
