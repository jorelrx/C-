using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Aluno : IComparable
    {
        public string Nome { set; get; }
        public string Matricula { set; get; }
        public int CompareTo(object a)
        {
            Aluno aa = a as Aluno;
            return this.Nome.CompareTo(aa.Nome);
        }
    }
}
