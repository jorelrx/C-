using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Program
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public bool Verificar(string nome)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.GetNome() == nome) return true;
                else return false;
            }
            return false;
        }
        public void InserirConta(Usuario newConta)
        {
            usuarios.Add(newConta);
        }
    }
}
