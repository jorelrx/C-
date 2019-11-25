using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloUsuario;

namespace ModeloCliente
{
    public class MCliente : MUsuario
    {
        public double Tempo { get; set; }
        public void Teste()
        {
            Nome = "joel";
        }
        public MCliente(string nome, string senha, string email) : base(nome, senha, email) { }
        
    }
}
