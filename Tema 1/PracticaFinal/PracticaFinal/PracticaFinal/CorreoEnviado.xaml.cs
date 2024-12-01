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

namespace PracticaFinal
{
    /// <summary>
    /// Lógica de interacción para CorreoEnviado.xaml
    /// </summary>
    public partial class CorreoEnviado : Window
    {
        private Window ventanaRecuperar;

        public CorreoEnviado(Window recuperar)
        {
            InitializeComponent();
            ventanaRecuperar = recuperar;
        }

        private void BtnCorreoEnviado_Click(object sender, RoutedEventArgs e)
        {

            MainWindow newMainWindows = new MainWindow();
            newMainWindows.Show();
            ventanaRecuperar.Close();
            this.Close();
        }
    }
}
