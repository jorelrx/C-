using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloUsuario
{
    public class MUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public MUsuario(string nome, string senha, string email)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id = {Id}\nNome = {Nome}\nSenha = {Senha}\nEmail = {Email}";
        }
    }
}
