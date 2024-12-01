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

namespace Practica5
{
    /// <summary>
    /// Lógica de interacción para DialogButton.xaml
    /// </summary>
    public partial class DialogButton : Window
    {
        public DialogButton()
        {
            InitializeComponent();
        }

        private void btn_dialog_ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }
    }
}
