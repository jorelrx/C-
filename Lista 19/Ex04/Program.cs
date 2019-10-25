using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Construtora c = new Construtora();
            int op;
            do
            {
                Console.WriteLine("1: Inserir\n2: Listar funcionarios\n3: Listar engenheiros\n4: Listar morotistas\n0: Sair");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 1)
                {
                    Console.WriteLine("1: Engenheiro\n2: Motorista\n3: Funcionario");
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.Write("Nome:");
                        string nome = Console.ReadLine();
                        Console.Write("E-mail:");
                        string email = Console.ReadLine();
                        Console.Write("Telefone:");
                        string fone = Console.ReadLine();
                        Console.Write("CREA:");
                        string crea = Console.ReadLine();
                        Engenheiro e = new Engenheiro(nome, email, fone, crea);
                        c.Inserir(e);
                    }
                    if (opcao == 2)
                    {
                        Console.Write("Nome:");
                        string nome = Console.ReadLine();
                        Console.Write("E-mail:");
                        string email = Console.ReadLine();
                        Console.Write("Telefone:");
                        string fone = Console.ReadLine();
                        Console.Write("CNH:");
                        string cnh = Console.ReadLine();
                        Motorista e = new Motorista(nome, email, fone, cnh);
                        c.Inserir(e);
                    }
                    if (opcao == 3)
                    {
                        Console.Write("Nome:");
                        string nome = Console.ReadLine();
                        Console.Write("E-mail:");
                        string email = Console.ReadLine();
                        Console.Write("Telefone:");
                        string fone = Console.ReadLine();
                        Funcionario e = new Funcionario(nome, email, fone);
                        c.Inserir(e);
                    }
                }
                if (op == 2)
                {
                    foreach (Funcionario f in c.Funcionarios())
                    {
                        Console.WriteLine(f);
                        Console.WriteLine();
                    }
                }
                if (op == 3)
                {
                    foreach (Funcionario f in c.Engenheiros())
                    {
                        Console.WriteLine(f);
                        Console.WriteLine();
                    }
                }
                if (op == 4)
                {
                    foreach (Funcionario f in c.Motoristas())
                    {
                        Console.WriteLine(f);
                        Console.WriteLine();
                    }
                }
            } while (op != 0);
        }
    }
}
