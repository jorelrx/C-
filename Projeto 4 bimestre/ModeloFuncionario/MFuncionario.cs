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
        public bool admin { get; set; }
        public MFuncionario(string nome, string senha, string email) : base(nome, senha, email) { }
    }
}
