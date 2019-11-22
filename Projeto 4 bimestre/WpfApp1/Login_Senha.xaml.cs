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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para Login_Senha.xam
    /// </summary>
    public partial class Login_Senha : Page
    {
        public Login_Senha()
        {
            InitializeComponent();
        }

        private void Button_LoginSenha(object sender, RoutedEventArgs e)
        {
            this.Content = new Page_Cliente();
        }
    }
}
