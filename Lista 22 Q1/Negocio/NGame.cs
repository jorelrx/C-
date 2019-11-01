using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Modelo;

namespace Negocio
{
    public class NGame
    {
        private List<MGame> list = new List<MGame>();
        PGame p;
        public List<MGame> Select()
        {
            PGame p = new PGame();
            return p.Open().OrderBy(c => c.Nome).ToList();
        }

        public void Insert(MGame c)
        {
            PGame p = new PGame();
            List<MGame> cs = p.Open();
            int m = 0;
            foreach (MGame x in cs) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);
            p.Save(cs);
        }
        public void Update(MGame c)
        {
            PGame p = new PGame();
            List<MGame> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.Save(cs);
        }
        public void Delete(MGame c)
        {
            PGame p = new PGame();
            List<MGame> cs = p.Open();
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
