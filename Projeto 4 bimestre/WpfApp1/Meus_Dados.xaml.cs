using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NegocioProgram;
using ModeloCliente;
using ModeloFuncionario;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para Meus_Dados.xaml
    /// </summary>
    public partial class Meus_Dados : Window
    {
        public Meus_Dados()
        {
            InitializeComponent();
        }
        NProgram p = new NProgram();
        private void Button_Fechar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Alterar_Dados(object sender, RoutedEventArgs e)
        {
            if (TypeAccount.Text == "Administrador" || TypeAccount.Text == "Funcionario")
            {
                List<MFuncionario> list = p.ListarFuncionario();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == int.Parse(IdAccount.Text))
                    {
                        MFuncionario newF = new MFuncionario(nomeConta.Text, senhaConta.Text, emailConta.Text, list[i].Admin);
                        newF.SetId(list[i].Id);
                        p.UpdateFuncionario(newF);
                        MessageBox.Show("Dados alterados com sucesso");
                        this.Close();
                    }
                }
            }
            else if (TypeAccount.Text == "Cliente")
            {
                List<MCliente> list = p.ListarClientes();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == int.Parse(IdAccount.Text))
                    {
                        double tempo = list[i].Tempo;
                        MCliente newC = new MCliente(nomeConta.Text, senhaConta.Text, emailConta.Text);
                        newC.SetId(list[i].Id);
                        p.UpdateCliente(newC);
                        p.InserirTempo(newC, list[i].Tempo);
                        MessageBox.Show("Dados alterados com sucesso");
                        this.Close();
                    }
                }
            }
        }
    }
}
