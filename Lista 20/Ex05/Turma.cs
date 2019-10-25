using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Turma : IComparable
    {
        private string semestre, disciplina;
        private List<Aluno> lista = new List<Aluno>();
        public int NumAl { set; get; }
        public Turma(string s, string d)
        {
            semestre = s; disciplina = d;
        }
        public void AdicionarAluno(Aluno a)
        {
            lista.Add(a);
        }
        public Aluno[] Listar()
        {
            int k = 0;
            Aluno[] a = new Aluno[lista.Count];
            foreach (Aluno aa in lista) a[k++] = aa;
            Array.Sort(a);
            return a;
        }
        public int CompareTo(object t)
        {
            Turma tu = t as Turma;
            if (this.semestre.CompareTo(tu.semestre) == 0) return this.disciplina.CompareTo(tu.disciplina);
            return this.semestre.CompareTo(tu.semestre);
        }
    }
}
