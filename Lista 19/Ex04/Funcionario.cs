using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Funcionario
    {
        private string nome, email, fone;
        public Funcionario(string nome, string email, string fone)
        {
            this.nome = nome;
            this.email = email;
            this.fone = fone;
        }
        public string GetNome() { return nome; }
        public string GetEmail() { return email; }
        public string GetFone() { return fone; }
        public override string ToString()
        {
            return $"Nome: {nome}\nE-mail: {email}\nFone: {fone}";
        }
    }
}
