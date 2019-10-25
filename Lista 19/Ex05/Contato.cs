using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Contato
    {
        protected string nome, fone;
        public Contato(string n, string f)
        {
            nome = n;
            fone = f;
        }
        public override string ToString()
        {
            return $"Nome: {nome}\nFone: {fone}";
        }
    }
}
