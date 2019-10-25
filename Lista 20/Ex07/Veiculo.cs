using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Veiculo
    {
        private string fabricante, placa, modelo;
        private decimal preco;
        private bool vendido;
        private int ano;
        public Veiculo(string p, string f, string m, int a, decimal pr)
        {
            placa = p;
            fabricante = f;
            modelo = m;
            if (a > 0) ano = a;
            if (pr > 0) preco = pr;
        }
        public bool GetVendidos()
        {
            return vendido;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public string GetFabricante()
        {
            return fabricante;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public string GetPlaca()
        {
            return placa;
        }
        public void Vender()
        {
            vendido = true;
        }
    }
}
