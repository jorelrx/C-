using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autor;
using PersistenciaAutor;

namespace NegocioAutor
{
    public class NAutor
    {
        private List<MAutor> l = new List<MAutor>();
        private PAutor p;

        public List<MAutor> Select()
        {
            PAutor p = new PAutor();
            return p.Open().OrderBy(c => c.Nome).ToList();
        }

        public void Insert(MAutor c)
        {
            PAutor p = new PAutor();
            List<MAutor> cs = p.Open();
            int m = 0;
            foreach (MAutor x in cs) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);
            p.Save(cs);
        }
        public void Update(MAutor c)
        {
            PAutor p = new PAutor();
            List<MAutor> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.Save(cs);
        }
        public void Delete(MAutor c)
        {
            PAutor p = new PAutor();
            List<MAutor> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.Save(cs);
        }
    }
}
