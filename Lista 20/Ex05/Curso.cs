using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Curso
    {
        private string descricao;
        private List<Turma> lista = new List<Turma>();
        public Curso(string d)
        {
            descricao = d;
        }
        public void AdicionarTurma(Turma t)
        {
            lista.Add(t);
        }
        public Turma[] Listar()
        {
            int k = 0;
            Turma[] t = new Turma[lista.Count];
            foreach (Turma x in lista) t[k++] = x;
            Array.Sort(t);
            return t;
        }
    }
}
