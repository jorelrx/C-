using System.Collections.Generic;
using System.Linq;
using Livro;
using Persistencia;

namespace NLivro
{
    public class NLivro
    {
        private List<MLivro> l = new List<MLivro>();
        private PLivro p;

        public List<MLivro> Select()
        {
            PLivro p = new PLivro();
            return p.Open().OrderBy(c => c.Nome).ToList();
        }

        public void Insert(MLivro c)
        {
            PLivro p = new PLivro();
            List<MLivro> cs = p.Open();
            int m = 0;
            foreach (MLivro x in cs) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);
            p.Save(cs);
        }
        public void Update(MLivro c)
        {
            PLivro p = new PLivro();
            List<MLivro> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.Save(cs);
        }
        public void Delete(MLivro c)
        {
            PLivro p = new PLivro();
            List<MLivro> cs = p.Open();
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
