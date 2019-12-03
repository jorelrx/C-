using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModeloUsuario;
using ModeloCliente;
using ModeloFuncionario;

namespace PersistenciaProgram
{
    public class PProgram
    {
        private string contas = "Contas.xml";
        private string clientes = "Clientes.xml";
        private string funcionarios = "Funcionarios.xml";
        public List<MUsuario> OpenContas()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MUsuario>));
            StreamReader f = null;
            List<MUsuario> cs = null;
            try
            {
                f = new StreamReader(funcionarios, Encoding.Default);
                cs = x.Deserialize(f) as List<MUsuario>;
            }
            catch
            {
                cs = new List<MUsuario>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }







        public List<MCliente> OpenCliente()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MCliente>));
            StreamReader f = null;
            List<MCliente> cs = null;
            try
            {
                f = new StreamReader(clientes, Encoding.Default);
                cs = x.Deserialize(f) as List<MCliente>;
            }
            catch
            {
                cs = new List<MCliente>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void SaveCliente(List<MCliente> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MCliente>));
            StreamWriter f = new StreamWriter(clientes, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }

        public List<MFuncionario> OpenFuncionario()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MFuncionario>));
            StreamReader f = null;
            List<MFuncionario> cs = null;
            try
            {
                f = new StreamReader(funcionarios, Encoding.Default);
                cs = x.Deserialize(f) as List<MFuncionario>;
            }
            catch
            {
                cs = new List<MFuncionario>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }

        public void SaveFuncionario(List<MFuncionario> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MFuncionario>));
            StreamWriter f = new StreamWriter(funcionarios, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
