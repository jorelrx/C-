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
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public double ValorCompra { get; set; }
        public bool SituacaoCompra { get; set; }
        public MComprar_Tempo(int id, string nome, double valorCompra)
        {
            IdCliente = id;
            Nome = nome;
            ValorCompra = valorCompra;
        }
        public MComprar_Tempo() { }
        public override string ToString()
        {
            string sit;
            if (SituacaoCompra == false) sit = "Em aberto";
            else sit = "Finalizado";
            return $"Id da compra: {Id}\nId do cliente: {IdCliente}\nNome do cliente: {Nome}\nValor da compra: {ValorCompra}\nSituação de compra: {sit}";
        }
    }
}
