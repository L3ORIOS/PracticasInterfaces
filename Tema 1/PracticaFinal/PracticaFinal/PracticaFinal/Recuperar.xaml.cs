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
using System.Text.RegularExpressions;


namespace PracticaFinal
{
    /// <summary>
    /// Lógica de interacción para Recuperar.xaml
    /// </summary>
    /// 

    
    public partial class Recuperar : Window
    {

        //public static CorreoEnviado correoConfirmado = new CorreoEnviado();

        public Recuperar()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.LeftButton == MouseButtonState.Pressed)
            //{
            //    DragMove();
            //}
        }

        private void btn_Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow newMainWindow = new MainWindow();
            newMainWindow.Show();
            this.Close();
        }

        private void TextBoxRecuperar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string email = TextBoxRecuperar.Text;
            bool isValid = IsValidEmail(email);

            // Mostrar u ocultar mensaje de error
            ErrorText.Visibility = isValid ? Visibility.Collapsed : Visibility.Visible;

            // Habilitar o deshabilitar el botón de envío
            BtnRecuperar.IsEnabled = isValid;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Expresión regular para validar un email, se agrega using System.Text.RegularExpressions;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void BtnRecuperar_Click(object sender, RoutedEventArgs e)
        {
            CorreoEnviado newCorreoEnviado = new CorreoEnviado(this);
            newCorreoEnviado.Show();

    
           


        }
    }
}
