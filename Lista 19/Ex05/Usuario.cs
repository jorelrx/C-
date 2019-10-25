using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Usuario : Contato
    {
        private Contato[] contatos = new Contato[10];
        private Grupo[] grupos = new Grupo[10];
        private int k1 = 0, k2 = 0;
        public Usuario(string n, string f) : base(n, f) { }
        public void InserirContato(Contato c) { contatos[k1++] = c; }
        public void InserirGrupo(Grupo g) { grupos[k2++] = g; }
        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[k1];
            Array.Copy(contatos, c, k1);
            return c;
        }
        public Grupo[] ListarGrupos()
        {
            Grupo[] g = new Grupo[k2];
            Array.Copy(grupos, g, k2);
            return g;
        }
        public override string ToString()
        {
            return $"Nome: {base.nome}\nTelefone: {base.fone}\nNumero de contato: {k1}\nNumero de grupos: {k2}";
        }
    }
}
