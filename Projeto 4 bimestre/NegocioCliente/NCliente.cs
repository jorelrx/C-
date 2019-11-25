using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloCliente;
using ModeloUsuario;

namespace NegocioCliente
{
    public class NCliente
    {
        public void AdicionarTempo(double tempo)
        {
            
        }
        
        public void AlterarDados(MUsuario x)
        {
            MCliente c = new MCliente();
            x.Nome = "jore";
        }
    }
}
