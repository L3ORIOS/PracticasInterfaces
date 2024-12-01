using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Windows.Xps.Packaging;

namespace Practica6_1._3._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadXpsDocument("Practica6-1.3.5_RiosSuarez_LeobardoSalvador.xps");

        }
        private void LoadXpsDocument(string fileName)
        {

            // Usa Path.Combine para obtener la ruta completa en el directorio de salida
            //Archivo gurado en Practica6-1.3.5\bin\Debug\net6.0-windows\Practica6-1.3.5_RiosSuarez_LeobardoSalvador.xps
            string fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);


            if (File.Exists(fullPath))
            {
                XpsDocument xpsDocument = new XpsDocument(fullPath, FileAccess.Read);
                documentViewer.Document = xpsDocument.GetFixedDocumentSequence();
            }
            else
            {
                MessageBox.Show("No se encontró el archivo XPS.");
            }
        }
    }
}
