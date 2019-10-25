using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Grupo
    {
        private string descricao;
        private int k;
        private Contato[] contatos = new Contato[10];
        public Grupo(string d) { descricao = d; }
        public void Adicionar(Contato c)
        {
            contatos[k++] = c;
        }
        public void Excluir(Contato c)
        {
            int ia = Array.IndexOf(contatos, c);
            if (ia != -1)
            {
                for (int i = ia + 1; i < k; i++)
                {
                    contatos[i - 1] = contatos[i];
                }
                contatos[contatos.Length - 1] = null;
                k--;
            }
        }
        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[k];
            Array.Copy(contatos, c, k);
            return c;
        }
        public override string ToString()
        {
            return $"Descrição: {descricao}\nNúmero de contatos: {k}";
        }
    }
}
