using LoginLibros.negocio;
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

namespace wpfProyectoLibros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginService login = new LoginService();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Password;

            if (login.check(username, password))
            {
                //salidaLabel.Content = "Usuario Logeado";
                MessageBox.Show("Exito!!", "Usuario Logeado");
                //VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                //ventanaPrincipal.Show();
                ElegirLibro elegirLibro = new ElegirLibro();
                this.Visibility = Visibility.Hidden;
                elegirLibro.Show();

                this.Hide();

                //this.Hide();
            }
            else
            {
                MessageBox.Show("Error de Login", "Usuario o Password Incorrecto");
                //salidaLabel.Content = "Usuario o Password Incorrectos";
            }
        }
    }
}
