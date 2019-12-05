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
            pr.SaveClientes(clientes);
        }

        public void AdicionarTempo(MCliente c, double valor)
        {

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

        public void ComprarTempo(MComprar_Tempo compra)
        {
            MCliente c = new MCliente();
            List<MComprar_Tempo> cs = p.OpenCompras();
            compra.Id = SetId();
            cs.Add(compra);
            p.SaveCompras(cs);
        }

        public int SetId()
        {
            int IdComprar = 0;
            List<MComprar_Tempo> c = ListarCompras();
            foreach (MComprar_Tempo comprar in c) if (comprar.Id >= IdComprar) IdComprar = comprar.Id;
            IdComprar++;
            return IdComprar;
        }

        public List<MComprar_Tempo> ListarMinhasCompras(MCliente c)
        {
            List<MComprar_Tempo> list = new List<MComprar_Tempo>();
            foreach (MComprar_Tempo compra in p.OpenCompras()) if (compra.IdCliente == c.Id) list.Add(compra);
            return list;
        }
    }
}
