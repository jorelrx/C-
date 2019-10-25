using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Pilha<T>
    {
        private Queue<T> pilha1 = new Queue<T>();
        private Queue<T> pilha2 = new Queue<T>();
        public int Count()
        {
            if (pilha1.Count > 0) return pilha1.Count;
            return pilha2.Count;
        }
        public T Top()
        {
            while (Count() > 1)
                pilha2.Enqueue(pilha1.Dequeue());
            T f = pilha1.Peek();
            pilha1.Enqueue(pilha2.Dequeue());
            return f;
        }
        public T Pop()
        {
            while (Count() > 1)
                pilha2.Enqueue(pilha1.Dequeue());
            T f = pilha1.Peek();
            pilha1.Enqueue(pilha2.Dequeue());
            return f;
        }
        public void Push(T obj)
        {
            pilha1.Enqueue(obj);
        }
    }
}
