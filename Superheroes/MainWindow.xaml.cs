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

namespace superheroes
{
    public partial class MainWindow : Window
    {
        private List<Superheroe> listaSuperheroes;
        public MainWindow()
        {
            InitializeComponent();
            listaSuperheroes = Superheroe.GetSamples();
            superheroeDockPanel.DataContext = listaSuperheroes.FirstOrDefault();
            actualPosition.Text = "1";
            totalPositions.Text = listaSuperheroes.Count.ToString();
        }

        private void leftImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (int.TryParse(actualPosition.Text, out int index))
            {
                index--;
                if (index == 0)
                {
                    index = listaSuperheroes.Count;
                }
                superheroeDockPanel.DataContext = listaSuperheroes[index - 1];
                actualPosition.Text = index.ToString();
            }
        }

        private void rightImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (int.TryParse(actualPosition.Text, out int index))
            {
                index++;
                if (index > 3)
                {
                    index = 1;
                }
                superheroeDockPanel.DataContext = listaSuperheroes[index - 1];
                actualPosition.Text = index.ToString();
            }
        }


    }
}
