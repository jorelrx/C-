using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloCliente;
using ModeloFuncionario;
using PersistenciaProgram;

namespace NegocioProgram
{
    public class NProgram
    {
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
            foreach (MCliente x in cs) if (x.Id > m) m = x.Id;
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
            foreach (MFuncionario x in cs) if (x.Id > m) m = x.Id;
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
