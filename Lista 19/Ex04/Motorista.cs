using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Motorista : Funcionario
    {
        private string cnh;
        public Motorista(string n, string e, string f, string c) : base(n, e, f)
        {
            cnh = c;
        }
        public string GetCNH() { return cnh; }
        public override string ToString()
        {
            return $"Nome: {GetNome()}\nE-mail: {GetEmail()}\nFone: {GetFone()}\nCNH: {cnh}";
        }
    }
}
