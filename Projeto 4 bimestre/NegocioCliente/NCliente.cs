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
            //int m = 0;
            //foreach (MComprar_Tempo x in cs) if (x.Id > m) m = x.Id;
            //compra.Id = c.Id;
            //compra.Nome = 
            cs.Add(compra);
            p.SaveCompras(cs);
        }

        public List<MComprar_Tempo> ListarCompras()
        {
            PComprar_Tempo p = new PComprar_Tempo();
            return p.OpenCompras();
        }
    }
}
