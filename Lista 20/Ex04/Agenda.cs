using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ex04
{
    class Agenda
    {
        private string arquivo = "Contato.xml";
        private List<Contato> lista = new List<Contato>();
        public void Inserir(Contato c)
        {
            lista.Add(c);
        }
        public List<Contato> Listar()
        {
            return lista;
        }
        public List<Contato> Pesquisar(string pesq)
        {
            List<Contato> cd = new List<Contato>();
            foreach (Contato c in lista)
            {
                if (c.Nome.IndexOf(pesq) != -1) cd.Add(c);
            }
            return cd;
        }
        public void Abrir()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
            StreamReader f = null;
            List<Contato> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<Contato>;
            }
            catch
            {
                cs = new List<Contato>();
            }
            finally
            {
                if (f != null) f.Close();
            }
        }
        public void Salvar()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, lista);
            f.Close();
        }
    }
}
