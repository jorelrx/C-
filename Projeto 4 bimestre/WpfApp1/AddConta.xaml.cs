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
using ModeloCliente;
using NegocioProgram;
using ModeloFuncionario;

namespace WpfApp1
{
    public partial class AddConta : Window
    {
        public AddConta(string tA)
        {
            InitializeComponent();
            if (tA == "Funcionario")
            {
                funcionario.Visibility = Visibility.Hidden;
                administrador.Visibility = Visibility.Hidden;
            }
        }
        NProgram p = new NProgram();
        private void Button_NewAccount(object sender, RoutedEventArgs e)
        {
            if (cliente.IsChecked == true)
            {
                MCliente c = new MCliente(nomeConta.Text, senhaConta.Text, emailConta.Text);
                p.InserirCliente(c);
                MessageBox.Show("Conta criada com sucesso");
                this.Close();
            }
            else if (funcionario.IsChecked == true)
            {
                MFuncionario c = new MFuncionario(nomeConta.Text, senhaConta.Text, emailConta.Text, false);
                p.InserirFuncionario(c);
                MessageBox.Show("Conta criada com sucesso");
                this.Close();
            }
            else if (administrador.IsChecked == true)
            {
                MFuncionario c = new MFuncionario(nomeConta.Text, senhaConta.Text, emailConta.Text, true);
                p.InserirFuncionario(c);
                MessageBox.Show("Conta criada com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados incorretos, por favor inserir corretamente!");
            }
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
