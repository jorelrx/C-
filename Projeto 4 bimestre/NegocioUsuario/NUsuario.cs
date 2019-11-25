using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloUsuario;

namespace NegocioUsuario
{
    public class NUsuario
    {
        public bool Login()
        {
            return true;
        }

        public bool Logout()
        {
            MUsuario u = new MUsuario();
            return true;
        }
    }
}
