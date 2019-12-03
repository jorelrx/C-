using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloCliente;
using ModeloUsuario;
using ModeloComprar_Tempo;
using PersistenciaComprar_Tempo;

namespace NegocioCliente
{
    public class NCliente
    {
        public void ComprarTempo(MComprar_Tempo compra)
        {
            MCliente c = new MCliente();
            PComprar_Tempo p = new PComprar_Tempo();
            List<MComprar_Tempo> cs = p.OpenCompras();
            cs.Add(compra);
            p.SaveCompras(cs);
        }

        public List<MComprar_Tempo> ListarCompras(MCliente c) //extrato de compras
        {
            List<MComprar_Tempo> list = new List<MComprar_Tempo>();
            PComprar_Tempo p = new PComprar_Tempo();
            foreach (MComprar_Tempo compra in p.OpenCompras()) if (compra.Id == c.Id) list.Add(compra);
            return list;
        }
    }
}
