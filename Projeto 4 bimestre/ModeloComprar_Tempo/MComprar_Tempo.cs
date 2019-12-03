using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloComprar_Tempo
{
    public class MComprar_Tempo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorCompra { get; set; }
        public bool SituacaoCompra { get; set; }
        public MComprar_Tempo(int id, string nome, double valorCompra)
        {
            Id = id;
            Nome = nome;
            ValorCompra = valorCompra;
        }
        public MComprar_Tempo() { }
        public override string ToString()
        {
            return $"Id do cliente: {Id}\nNome do cliente: {Nome}\nValor da compra: {ValorCompra}";
        }
    }
}
