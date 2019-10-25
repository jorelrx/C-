using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Pilha<T>
    {
        private List<T> lista = new List<T>();
        private int k;

        public int Count()
        {
            return lista.Count;
        }

        public void Push(T obj)
        {
            lista.Insert(Count(), obj);
        }

        public T Top()
        {
            T t;
            t = lista[Count() - 1];
            return t;
        }

        public T Pop()
        {
            T t;
            t = lista[Count() - 1];
            lista.RemoveAt(Count() - 1);
            return t;
        }
    }
}
