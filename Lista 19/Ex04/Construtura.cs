using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Construtora
    {
        private List<Funcionario> funcs = new List<Funcionario>();
        public void Inserir(Funcionario f)
        {
            funcs.Add(f);
        }
        public List<Funcionario> Funcionarios()
        {
            return funcs;
        }
        public List<Engenheiro> Engenheiros()
        {
            List<Engenheiro> eng = new List<Engenheiro>();
            foreach (Funcionario f in funcs)
            {
                if (f is Engenheiro)
                {
                    eng.Add(f as Engenheiro);
                }
            }
            return eng;
        }
        public List<Motorista> Motoristas()
        {
            List<Motorista> mot = new List<Motorista>();
            foreach (Funcionario f in funcs)
            {
                if (f is Motorista)
                {
                    mot.Add(f as Motorista);
                }
            }
            return mot;
        }
    }
}
