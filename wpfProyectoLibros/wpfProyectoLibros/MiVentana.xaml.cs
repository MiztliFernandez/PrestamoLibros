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

namespace wpfProyectoLibros
{
    /// <summary>
    /// Lógica de interacción para MiVentana.xaml
    /// </summary>
    public partial class MiVentana : Window
    {
        public MiVentana()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Exito!!", "Tu proceso de prestamo ha sido correcto, podras recoger tu libro");
        }
    }
}
