using ModeloFuncionario;
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

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para Tela_Funcionario.xaml
    /// </summary>
    public partial class Tela_Funcionario : Window
    {
        public Tela_Funcionario()
        {
            InitializeComponent();
        }
        NProgram p = new NProgram();
        private void Button_Sair(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Meus_Dados Md = new Meus_Dados();
            foreach (MFuncionario f in p.ListarFuncionario())
                if (f.Id == int.Parse(TypeAccount.Text))
                {
                    Md.TypeAccount.Text = "Funcionario";
                    Md.IdAccount.Text = f.Id.ToString();
                    Md.nomeConta.Text = f.Nome.ToString();
                    Md.emailConta.Text = f.Email.ToString();
                    Md.senhaConta.Text = f.Senha.ToString();
                }
            Md.Show();
        }
    }
}
