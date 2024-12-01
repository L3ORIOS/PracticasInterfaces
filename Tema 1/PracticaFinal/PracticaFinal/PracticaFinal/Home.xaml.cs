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
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Fecha { get; set; }
        public string? ComidaFavorita { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Sexo { get; set; }
        public string? Comunicaciones { get; set; }


        public Home()
        {
            InitializeComponent();
            Loaded += Window_Loaded;
        }

        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
           
                // Asignar valores a los campos de texto al cargar el diálogo
                TextNombre.Text = Nombre;
                TextApellido.Text = Apellido;
                TextFecha.Text = Fecha;
                TextComida.Text = ComidaFavorita;
                TextEmail.Text = Email;
                TextPassword.Text = Password;
                TextSexo.Text = Sexo;
                TextComunicaciones.Text = Comunicaciones;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow newMainWindow = new MainWindow();
            newMainWindow.Show();
            this.Close();
        }
    }
}
