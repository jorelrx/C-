using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: frete normal, 2: frete com seguro");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Qual a distancia e o peso?");
                Frete f = new Frete(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("Qual a distancia, peso e o valor do seguro?");
                FreteExpresso f = new FreteExpresso(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), decimal.Parse(Console.ReadLine()));
                Console.WriteLine(f);
            }
            Console.WriteLine("Pressione qualquer tecla.");
            Console.ReadKey();
        }
    }
}
