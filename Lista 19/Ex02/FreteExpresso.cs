using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class FreteExpresso : Frete
    {
        decimal seguro;
        public FreteExpresso(double d, double p, decimal s) : base(d, p)
        {
            seguro = s;
        }
        public override double CalcFrete()
        {
            return 0.01 * GetDistancia() * GetPeso() * 2 + 1 / 100 * decimal.ToDouble(seguro);
        }
        public override string ToString()
        {
            return $"Distancia = {GetDistancia()} \nPeso = {GetPeso()} \nSeguro = {seguro} \nPreço do frete = {CalcFrete()}";
        }
    }
}
