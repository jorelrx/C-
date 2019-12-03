using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModeloComprar_Tempo;

namespace PersistenciaComprar_Tempo
{
    public class PComprar_Tempo
    {
        private string compras = "Comprar_Tempo.xml";
        public List<MComprar_Tempo> OpenCompras()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MComprar_Tempo>));
            StreamReader f = null;
            List<MComprar_Tempo> cs = null;
            try
            {
                f = new StreamReader(compras, Encoding.Default);
                cs = x.Deserialize(f) as List<MComprar_Tempo>;
            }
            catch
            {
                cs = new List<MComprar_Tempo>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void SaveCompras(List<MComprar_Tempo> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MComprar_Tempo>));
            StreamWriter f = new StreamWriter(compras, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
