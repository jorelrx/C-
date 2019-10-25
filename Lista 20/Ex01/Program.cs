using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para converter para binario");
            Conversor c = new Conversor();
            int num = int.Parse(Console.ReadLine());
            c.SetNum(num);
            Console.WriteLine(c.Binario());
            Console.ReadKey();
        }
    }
}
