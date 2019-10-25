using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome e depois o telefone");
            Usuario u = new Usuario(Console.ReadLine(), Console.ReadLine());
            int opcao = 0;
            do
            {
                Console.WriteLine("1: Inserir contato.\n2: Inserir grupo.\n3: Listar contatos.\n4: Listar grupos.\n5: Adicionar contato em grupo.\n0: Sair.");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcao == 1)
                {
                    Console.WriteLine("Nome e telefone");
                    Contato c = new Contato(Console.ReadLine(), Console.ReadLine());
                    u.InserirContato(c);
                }
                if (opcao == 2)
                {
                    Console.WriteLine("Descrição do grupo");
                    Grupo g = new Grupo(Console.ReadLine());
                    u.InserirGrupo(g);
                }
                if (opcao == 3)
                {
                    foreach (Contato c in u.ListarContatos()) Console.WriteLine(c);
                }
                if (opcao == 4)
                {
                    int k = 0;
                    foreach (Grupo g in u.ListarGrupos())
                    {
                        Console.WriteLine("Grupo:" + k++);
                        Console.WriteLine(g);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Dejese mostrar os contatos de algum grupo?\n1: Sim.\n2: Não.");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.WriteLine("Em qual grupo deseja detalhar?");
                        int grupo = int.Parse(Console.ReadLine());
                        foreach (Contato c in u.ListarGrupos()[grupo].ListarContatos())
                        {
                            int k1 = 0;
                            Console.WriteLine(k1++);
                            Console.WriteLine(c);
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("Pressione qualquer.");
                    Console.ReadKey();
                }
                if (opcao == 5)
                {
                    Console.WriteLine("1: Adicionar ou 2: excluir");
                    int op = int.Parse(Console.ReadLine());
                    foreach (Grupo g in u.ListarGrupos()) Console.WriteLine(g);
                    Console.WriteLine("Qual grupo dejesa alterar?");
                    int grupo = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        int k = 0;
                        Console.WriteLine("Qual contato deseja adicionar ao grupo?");
                        foreach (Contato c in u.ListarContatos())
                        {
                            Console.WriteLine("Contato: " + k++);
                            Console.WriteLine(c);
                        }
                        int contato = int.Parse(Console.ReadLine());
                        u.ListarGrupos()[grupo].Adicionar(u.ListarContatos()[contato]);
                        Console.WriteLine("Contato adicionado com sucesso, pressione qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                    if (op == 2)
                    {
                        int k = 0;
                        Console.WriteLine("Qual contato deseja remover do grupo?");
                        foreach (Contato c in u.ListarGrupos()[grupo].ListarContatos())
                        {
                            Console.WriteLine("Contato: " + k++);
                            Console.WriteLine(c);
                        }
                        int contato = int.Parse(Console.ReadLine());
                        u.ListarGrupos()[grupo].Excluir(u.ListarContatos()[contato]);
                        Console.WriteLine("Contato removido com sucesso, pressione qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                }
            } while (opcao != 0);
        }
    }
}
