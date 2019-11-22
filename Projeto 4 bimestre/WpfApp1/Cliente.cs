using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cliente : Usuario
    {
        private double tempo;
        public Cliente(string n, string s, string e) : base(n, s, e) { }

    }
}
