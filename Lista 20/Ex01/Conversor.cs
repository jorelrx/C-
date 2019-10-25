using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Conversor
    {
        private int num;
        private Stack<int> pilha = new Stack<int>();
        public void SetNum(int num)
        {
            this.num = num;
        }
        public string Binario()
        {
            string binario = "";
            while (num > 0)
            {
                pilha.Push(num % 2);
                num /= 2;
            }
            while (pilha.Count > 0) binario += pilha.Pop().ToString();
            return binario;
        }
    }
}
