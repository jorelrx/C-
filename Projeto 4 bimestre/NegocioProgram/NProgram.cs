using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloUsuario;
using ModeloCliente;
using ModeloFuncionario;
using PersistenciaProgram;
using PersistenciaComprar_Tempo;
using ModeloComprar_Tempo;

namespace NegocioProgram
{
    public class NProgram
    {
        public void InserirTempo(MCliente c, double tempo)
        {
            PProgram p = new PProgram();
            List<MCliente> list = ListarClientes();
            foreach (MCliente cliente in list)
                if (c.Id == cliente.Id)
                {
                    cliente.Tempo = tempo;
                }
            p.SaveCliente(list);
        }



        /* --------------------------------------------------------------------------------------------------------------- */

        public List<MUsuario> AllAccount()
        {
            PProgram p = new PProgram();
            List<MUsuario> list = new List<MUsuario>();

            foreach (MUsuario u in p.OpenFuncionario()) list.Add(u);
            foreach (MUsuario u in p.OpenCliente()) list.Add(u);

            return list;
        }

        /* --------------------------------------------------------------------------------------------------------------- */

        public List<MUsuario> ListarContas()
        {
            PProgram p = new PProgram();
            return p.OpenContas();
        }/*
        public void InserirConta(MUsuario c)
        {
            PProgram p = new PProgram();
            List<MUsuario> cs = p.OpenContas();
            int m = 0;
            foreach (MUsuario x in cs) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);

            p.SaveContas(cs);
        }
        public void UpdateConta(MUsuario c)
        {
            PProgram p = new PProgram();
            List<MUsuario> cs = p.OpenContas();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.SaveContas(cs);
        }
        public void DeleteConta(MUsuario c)
        {
            PProgram p = new PProgram();
            List<MUsuario> cs = p.OpenContas();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.SaveContas(cs);
        }*/

        public List<MCliente> ListarClientes()
        {
            PProgram p = new PProgram();
            return p.OpenCliente();
        }

        public void InserirCliente(MCliente c)
        {
            PProgram p = new PProgram();
            List<MCliente> cs = p.OpenCliente();                  
            int m = 0;
            foreach (MUsuario x in AllAccount()) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);
            p.SaveCliente(cs);
        }

        public void UpdateCliente(MCliente c)
        {
            PProgram p = new PProgram();
            List<MCliente> cs = p.OpenCliente();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.SaveCliente(cs);
        }

        public void DeleteCliente(MCliente c)
        {
            PProgram p = new PProgram();
            List<MCliente> cs = p.OpenCliente();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.SaveCliente(cs);
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public List<MFuncionario> ListarFuncionario()
        {
            PProgram p = new PProgram();
            return p.OpenFuncionario();
        }
        public void InserirFuncionario(MFuncionario c)
        {
            PProgram p = new PProgram();
            List<MFuncionario> cs = p.OpenFuncionario();
            int m = 0;
            foreach (MUsuario x in AllAccount()) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);
            p.SaveFuncionario(cs);
        }
        public void UpdateFuncionario(MFuncionario c)
        {
            PProgram p = new PProgram();
            List<MFuncionario> cs = p.OpenFuncionario();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.SaveFuncionario(cs);
        }
        public void DeleteFuncionario(MFuncionario c)
        {
            PProgram p = new PProgram();
            List<MFuncionario> cs = p.OpenFuncionario();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.SaveFuncionario(cs);
        }
    }
}
