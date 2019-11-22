using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Usuario
    {
        private Program p = new Program();
        private int id;
        private string nome;
        private string senha;
        private string email;
        public string GetNome() => nome;
        public Usuario(string nome, string senha, string email)
        {
            this.nome = nome;
            this.senha = senha;
            this.email = email;
        }
        public bool Login(string nome)
        {
            return p.Verificar(nome);
        }
        public bool Logout()
        {
            return true;
        }
        public override string ToString()
        {
            return $"Id = {id}\nNome = {nome}\nSenha = {senha}\nE-mail = {email}";
        }
    }
}
