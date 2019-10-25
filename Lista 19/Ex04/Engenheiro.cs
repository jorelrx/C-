using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Engenheiro : Funcionario
    {
        private string crea;
        public Engenheiro(string n, string e, string f, string c) : base(n, e, f)
        {
            crea = c;
        }
        public string GetCrea() { return crea; }
        public override string ToString()
        {
            return $"Nome: {GetNome()}\nE-mail: {GetEmail()}\nFone: {GetFone()}\nCREA: {crea}";
        }
    }
}
