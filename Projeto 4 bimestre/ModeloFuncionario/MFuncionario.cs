using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloUsuario;

namespace ModeloFuncionario
{
    public class MFuncionario : MUsuario
    {
        public bool Admin { get; set; }
        public MFuncionario(string nome, string senha, string email, bool typeAccount) : base(nome, senha, email)
        {
            Admin = typeAccount;
        }
        public MFuncionario() { }
        public bool GetAdmin() => Admin;
    }
}
