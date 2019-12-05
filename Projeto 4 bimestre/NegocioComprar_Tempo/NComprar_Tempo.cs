using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloComprar_Tempo;
using PersistenciaComprar_Tempo;
using NegocioProgram;
using ModeloCliente;

namespace NegocioComprar_Tempo
{
    public class NComprar_Tempo
    {
        PComprar_Tempo p = new PComprar_Tempo();
        public void PermitirCompra(MComprar_Tempo compra)
        {
            List<MComprar_Tempo> listCompras = p.OpenCompras();
            foreach (MComprar_Tempo mCompra in listCompras) if (mCompra.Id == compra.Id) mCompra.SituacaoCompra = true;
            NProgram pr = new NProgram();
            List<MCliente> clientes = pr.ListarClientes();
            foreach (MCliente c in clientes)
                if (c.Id == compra.IdCliente) c.Tempo = compra.ValorCompra / 2;
            p.SaveCompras(listCompras);
        }

        public List<MComprar_Tempo> ListarCompras()
        {
            List<MComprar_Tempo> list = p.OpenCompras();
            return list;
        }

        public void SaveCompras(List<MComprar_Tempo> compra)
        {
            p.SaveCompras(compra);
        }
    }
}
