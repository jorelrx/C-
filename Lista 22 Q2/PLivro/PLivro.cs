using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Livro;

namespace Persistencia
{
    public class PLivro
    {
        private string arquivo = "Livro.xml";
        public List<MLivro> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MLivro>));
            StreamReader f = null;
            List<MLivro> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<MLivro>;
            }
            catch
            {
                cs = new List<MLivro>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Save(List<MLivro> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MLivro>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
