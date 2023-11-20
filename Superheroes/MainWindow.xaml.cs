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

namespace Superheroes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        List<Superheroe> ejemplos = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();
            NombreS.DataContext = ejemplos.ToArray()[contador];
            img.DataContext = ejemplos.ToArray()[contador];
            UpdateDisplayText();
        }

        private void UpdateDisplayText()
        {
            contadorS.Text = $"{contador+1}/{ejemplos.Count}";
        }

        private void anterior(object sender, RoutedEventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                    UpdateDisplayText();
            }
        }

        private void siguiente(object sender, RoutedEventArgs e)
        {
            if (contador >1)
            {
                contador++;
                UpdateDisplayText();
            }
        }
    }
}
