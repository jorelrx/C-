using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe titular e depois número da conta");
            string titular = Console.ReadLine();
            string numero = Console.ReadLine();
            Console.WriteLine("Tipo da conta \n1: ContaCorrente\n2: Conta especial\n3: Conta poupança");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                int op = 0;
                ContaCorrente c = new ContaCorrente(titular, numero);
                do
                {
                    Console.WriteLine("1: Sacar\n2: Depositar\n3: Listar dados\n0: Sair");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (op == 1)
                    {
                        Console.Write("Informe valor de saque: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (c.Sacar(valor) == true)
                        {
                            c.Sacar(valor);
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                            Console.WriteLine("Saldo insuficiente");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 2)
                    {
                        Console.Write("Informe valor de deposito: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (valor > 0)
                        {
                            c.Depositar(valor);
                            Console.WriteLine("Daposito realizado com sucesso!");
                        }
                        else
                            Console.WriteLine("Valor incorreto");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 3)
                    {
                        Console.WriteLine(c);
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (op != 0);
            }
            if (opcao == 2)
            {
                Console.WriteLine("Informe o limite");
                double limite = double.Parse(Console.ReadLine());
                int op = 0;
                ContaEspecial c = new ContaEspecial(titular, numero, limite);
                do
                {
                    Console.WriteLine("1: Sacar\n2: Depositar\n3: Listar dados\n0: Sair");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Write("Informe valor de saque: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (c.Sacar(valor) == true)
                        {
                            c.Sacar(valor);
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                            Console.WriteLine("Saldo insuficiente");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 2)
                    {
                        Console.Write("Informe valor de deposito: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (valor > 0)
                        {
                            c.Depositar(valor);
                            Console.WriteLine("Daposito realizado com sucesso!");
                        }
                        else
                            Console.WriteLine("Valor incorreto");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 3)
                    {
                        Console.WriteLine(c);
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (op != 0);
            }
            if (opcao == 3)
            {
                double limite = double.Parse(Console.ReadLine());
                int op = 0;
                ContaPoupanca c = new ContaPoupanca(titular, numero);
                do
                {
                    Console.WriteLine("1: Sacar\n2: Depositar\n3: Listar dados\n4:Calcular juros \n0: Sair");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Write("Informe valor de saque: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (c.Sacar(valor) == true)
                        {
                            c.Sacar(valor);
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                            Console.WriteLine("Saldo insuficiente");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 2)
                    {
                        Console.Write("Informe valor de deposito: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (valor > 0)
                        {
                            c.Depositar(valor);
                            Console.WriteLine("Daposito realizado com sucesso!");
                        }
                        else
                            Console.WriteLine("Valor incorreto");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 3)
                    {
                        Console.WriteLine(c);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (op == 4)
                    {
                        Console.WriteLine("porcentagem: ");
                        c.Render(double.Parse(Console.ReadLine()));
                    }
                } while (op != 0);
            }
        }
    }
}
