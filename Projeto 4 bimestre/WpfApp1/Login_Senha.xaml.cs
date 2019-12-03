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
using ModeloUsuario;
using ModeloFuncionario;
using ModeloCliente;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para Login_Senha.xaml
    /// </summary>
    public partial class Login_Senha : Window
    {
        public Login_Senha()
        {
            InitializeComponent();
        }

        private void Button_LoginSenha(object sender, RoutedEventArgs e) // Botão pra carregar segunda tela de pos login;
        {
            bool verificar = false;
            NProgram p = new NProgram();
            foreach (MCliente c in p.ListarClientes())
                if (c.Nome == buttonEmail.Content.ToString() && c.Senha == senhaUsuario.Text)
                {
                    Tela_Cliente posLogin = new Tela_Cliente();
                    posLogin.Show();
                    posLogin.IdAccount.Text = c.Id.ToString();
                    this.Close();
                    verificar = true;
                    break;
                }
            foreach (MFuncionario f in p.ListarFuncionario())
                if (f.Nome == buttonEmail.Content.ToString() && f.Senha == senhaUsuario.Text)
                {
                    if (f.Admin == true)
                    {
                        Tela_Administrador tA = new Tela_Administrador();
                        tA.Show();
                        tA.TypeAccount.Text = f.Id.ToString();
                        this.Close();
                        verificar = true;
                    }
                    else
                    {
                        Tela_Funcionario tF = new Tela_Funcionario();
                        tF.Show();
                        this.Close();
                        verificar = true;
                    }
                    break;
                }
            if (verificar != true) MessageBox.Show("Senha incorreta!\nTente novamente.");
        }

        private void Voltar_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
