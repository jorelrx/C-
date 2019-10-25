using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Frete
    {
        private double distancia, peso;
        public Frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }
        public double GetDistancia() { return distancia; }
        public double GetPeso() { return peso; }
        public virtual double CalcFrete()
        {
            return 0.01 * peso * distancia;
        }
        public override string ToString()
        {
            return $"Distancia = {distancia} \nPeso = {peso} \nPreço do frete = {CalcFrete()}";
        }
    }
}
