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

namespace Practica5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Dialog_Click(object sender, RoutedEventArgs e)
        {
            DialogButton dialog = new DialogButton();
            dialog.ShowDialog();
        }

        private void btn_Repeat_Click(object sender, RoutedEventArgs e)
        {
            RepeatButton repeat = new RepeatButton();
            repeat.Show();
        }

        private void btnRadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButtons radio = new RadioButtons();
            radio.Show();
        }

        private void btn_CheckBoxes_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxes checkBoxes = new CheckBoxes();
            checkBoxes.Show();
        }
    }
}
