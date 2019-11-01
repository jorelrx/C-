using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Autor;

namespace PersistenciaAutor
{
    public class PAutor
    {
        private string arquivo = "Livro.xml";
        public List<MAutor> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MAutor>));
            StreamReader f = null;
            List<MAutor> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<MAutor>;
            }
            catch
            {
                cs = new List<MAutor>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Save(List<MAutor> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MAutor>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
