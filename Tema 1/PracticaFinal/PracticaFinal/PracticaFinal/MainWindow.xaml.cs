using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PracticaFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static Recuperar ventanaRecuperar = new Recuperar();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Método que permite mover la ventana cuando se hace clic y arrastra con el botón izquierdo del ratón
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Verifica si el botón izquierdo del ratón está presionado
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Llama al método DragMove() para permitir mover la ventana arrastrándola
                DragMove();
            }
        }

        // Método que se ejecuta al hacer clic en el botón de cerrar (cerrar ventana)
        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            // Finaliza la aplicación cerrando todas las ventanas abiertas
            Application.Current.Shutdown();
        }

        // Método que se ejecuta al hacer clic en el botón de minimizar (minimizar ventana)
        private void btn_Minimizar_Click(object sender, RoutedEventArgs e)
        {
            // Cambia el estado de la ventana a minimizada
            WindowState = WindowState.Minimized;
        }

        private void LabelRecuperar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Recuperar newRecuperar = new Recuperar();
            newRecuperar.Show();
            this.Close();
        }

        //Cuando cambia el texto se validan todos los campos
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateLogin();
        }

        private void TextPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ValidateLogin();
        }

        // Método para validar los campos de inicio de sesión (correo electrónico y contraseña)
        private void ValidateLogin()
        {
            // Obtengo los valores ingresados en los campos de texto para email y contraseña
            string email = TextBoxEmail.Text;
            string password = TextPasswordBox.Password;

            // Valido el email y la contraseña utilizando los métodos correspondientes
            bool isEmailValid = IsValidEmail(email);
            bool isPasswordValid = IsValidPassword(password);

            // Muestro u oculto el mensaje de error para el campos dependiendo de su validez
            ErrorTextEmail.Visibility = isEmailValid ? Visibility.Collapsed : Visibility.Visible;
            ErrorTextPassword.Visibility = isPasswordValid ? Visibility.Collapsed : Visibility.Visible;

            // Habilito el botón de inicio de sesión solo si ambos campos son válidos
            BtnLogin.IsEnabled = isEmailValid && isPasswordValid;
        }

        private void TextBoxNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateForm();
        }

        private void TextBoxApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateForm();
        }

        private void TextBoxEmailReistro_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateForm();
        }

        private void PasswordBoxRegistro_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ValidateForm();
        }

        private void DatePickerFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ValidateForm();
        }

        private void ComboBoxComida_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            // Obtengo los valores ingresados en los campos
            string nombre = TextBoxNombre.Text;
            string apellido = TextBoxApellido.Text;
            string email = TextBoxEmailRegistro.Text;
            string password = PasswordBoxRegistro.Password;
            DateTime? fechaSeleccionada = DatePickerFecha.SelectedDate;
            bool isComboBoxSelected = ComboBoxComida.SelectedItem != null;

            // Valido
            bool isNombreValid = IsValidField(nombre);
            bool isApellidoValid = IsValidField(apellido);
            bool isEmailValid = IsValidEmail(email);
            bool isPasswordValid = IsValidPassword(password);
            bool isFechaValid = fechaSeleccionada.HasValue;
            bool isComboBoxValid = isComboBoxSelected;

            // Muestro u oculto el mensaje de error para el campos dependiendo de su validez
            ErrorTextBlockNombre.Visibility = isNombreValid ? Visibility.Collapsed : Visibility.Visible;
            ErrorTextBlockApellido.Visibility = isApellidoValid ? Visibility.Collapsed : Visibility.Visible;
            ErrorTextBlockEmail.Visibility = isEmailValid ? Visibility.Collapsed : Visibility.Visible;
            ErrorPasswordbox.Visibility = isPasswordValid ? Visibility.Collapsed : Visibility.Visible;
            ErrorDate.Visibility = isFechaValid ? Visibility.Collapsed : Visibility.Visible;
            ErrorComobox.Visibility = isComboBoxValid ? Visibility.Collapsed : Visibility.Visible;

            // Habilito el botón de inicio de sesión solo si ambos campos son válidos
            BtnSingin.IsEnabled = isNombreValid && isApellidoValid && isEmailValid && isPasswordValid && isFechaValid && isComboBoxValid;

        }

        //Función para validar que los campos nombre y apellido no esten en blanco
        public bool IsValidField(string field) {

            //Si no es nula regreso false
            if (string.IsNullOrWhiteSpace(field))
                return false;

            //Si al menos tiene 3 letras el campo es valido
            return field.Length > 2 ? true : false;
        }

        public bool IsValidEmail(string email) {

            //Si no es nula regreso false
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Expresión regular para validar un email, se agrega using System.Text.RegularExpressions;
            //Explicación del patter al final del documento.
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email,pattern);
        }

        public bool IsValidPassword(string password)
        {
            //Si no es nula regreso false
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Verificar que la contraseña tenga al menos una letra mayúscula, una minúscula y un número
            //Explicación del patter al final del documento.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$";
            return Regex.IsMatch(password, pattern);
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = TextBoxEmail.Text;
            string password = TextPasswordBox.Password;

            Home newHome = new Home() { Email = email, Password = password };

            newHome.Show();
            this.Show();
        }

        private void BtnSingin_Click(object sender, RoutedEventArgs e)
        {
            // Obtener valores de los campos
            string nombre = TextBoxNombre.Text;
            string apellido = TextBoxApellido.Text;
            string fecha = DatePickerFecha.SelectedDate.HasValue ? DatePickerFecha.SelectedDate.Value.ToShortDateString() : string.Empty;
            string? comidaFavorita = ComboBoxComida.SelectedItem != null ? ((ComboBoxItem)ComboBoxComida.SelectedItem).Content.ToString() : string.Empty;
            string email = TextBoxEmailRegistro.Text;
            string password = PasswordBoxRegistro.Password;
            string sexo = sexMujer.IsChecked == true ? "Mujer" :
              sexHombre.IsChecked == true ? "Hombre" : "Indeterminado";

            List<string> comunicaciones = new List<string>();
            if (CheckBoxNewsletters.IsChecked == true) comunicaciones.Add("Newsletters");
            if (CheckBoxDocumentos.IsChecked == true) comunicaciones.Add("Documentos");

            // Combina los valores en un solo string
            string comunicacionesSeleccionadas = comunicaciones.Count > 0
                ? string.Join(", ", comunicaciones)
                : "Ninguna";


            // Crear el diálogo y pasar los datos
            Home dialog = new Home
            {
                Nombre = nombre,
                Apellido = apellido,
                Fecha = fecha,
                ComidaFavorita = comidaFavorita,
                Email = email,
                Password = password,
                Sexo = sexo,
                Comunicaciones = comunicacionesSeleccionadas
            };

            // Mostrar el diálogo
            dialog.ShowDialog();
        }
    }
}

//  string patternEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

//            ^:
//
//              Indica el inicio de la cadena. Esto asegura que la validación comience desde el principio.

//          [^@\s] +:
//
//              Es un conjunto y significa:
//                  [^...]: Cualquier carácter que no esté dentro de los corchetes.
//                  @: Excluye el carácter @.
//                  \s: Excluye cualquier espacio en blanco(como espacios, tabulaciones, etc.).
//              El signo +:
//                  Indica uno o más caracteres que cumplan con el conjunto definido.
//              En este caso, captura la parte antes del símbolo @ (el nombre del usuario en el correo).

//          @:
//
//              Verifica que haya un símbolo arroba(@) presente en la cadena. Esto es obligatorio en cualquier dirección de correo electrónico.

//          [^@\s] +:
//
//              Similar al anterior:
//                  Captura la parte después del @, que corresponde al nombre de dominio.
//              Por ejemplo, en correo @example.com, aquí se validaría example.

//          \.:
//
//              Representa un punto literal(.).
//                  Se debe escribir como \. porque el punto tiene un significado especial en las expresiones regulares(cualquier carácter).La barra invertida lo escapa para que sea tratado como un carácter literal.

//          [^@\s]+:
//
//              Valida la extensión del dominio, como.com, .org, .net, etc.
//              Acepta uno o más caracteres después del punto, pero excluye caracteres no válidos como espacios o un segundo @.

//          $:
//
//              Indica el final de la cadena. Esto asegura que no haya caracteres adicionales después de la extensión del dominio.



//  string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$";

//          ^:
//
//              Marca el inicio de la cadena. Esto asegura que la validación comience desde el principio.

//          (?=.*[a-z]):
//
//              (?= ...): Asegura que lo que está dentro del paréntesis existe en la cadena, sin consumir caracteres.
//              .*: Cualquier cantidad(incluido cero) de caracteres, antes de encontrar:
//              [a-z]: Al menos una letra minúscula.
//
//                  Ejemplo válido: "abc123", "Hello1".

//          (?=.*[A - Z]):
//
//               Verifica que la cadena contenga:
//              .*: Cualquier cantidad de caracteres, antes de encontrar:
//              [A-Z]: Al menos una letra mayúscula.
//
//                  Ejemplo válido: "Abc123", "PASSWORD1".

//          (?=.*\d):
//
//              Verifica que la cadena contenga:
//              .*: Cualquier cantidad de caracteres, antes de encontrar:
//              \d: Al menos un dígito(equivalente a [0-9]).
//
//              Ejemplo válido: "Abc1", "Passw0rd".

//          .+:
//
//              Verifica que la cadena contenga al menos un carácter (de cualquier tipo).
//              Esto asegura que no se acepte una cadena vacía.

//          $:
//
//              Marca el final de la cadena. Esto asegura que toda la contraseña sea evaluada y no haya caracteres adicionales fuera de los requisitos.
