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

        private void Button_LoginSenha(object sender, RoutedEventArgs e) // Botão pra carregar segunda tela de login;
        {
            Login_Senha login_Senha = new Login_Senha();
            login_Senha.Show();
            this.Close();
        }

        private void Voltar_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
