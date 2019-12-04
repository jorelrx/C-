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
        public void PermitirCompra(MComprar_Tempo compra)
        {
            compra.SituacaoCompra = true;
            NProgram p = new NProgram();
                foreach (MCliente c in p.ListarClientes()) if (c.Id == compra.IdCliente)
        }

        public List<MComprar_Tempo> ListarCompras()
        {
            PComprar_Tempo p = new PComprar_Tempo();
            List<MComprar_Tempo> list = p.OpenCompras();
            return list;
        }
    }
}
