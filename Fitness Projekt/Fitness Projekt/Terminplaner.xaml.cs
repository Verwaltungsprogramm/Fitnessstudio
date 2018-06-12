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

namespace Fitness_Projekt
{
    /// <summary>
    /// Interaktionslogik für Terminplaner.xaml
    /// </summary>
    public partial class Terminplaner : Page
    {
        public Terminplaner()
        {
            InitializeComponent();
        }
        private void Kunden_Click3(object sender, RoutedEventArgs e)
        {
            Kundeninformation kundeninformation3 = new Kundeninformation();
            NavigationService.Navigate(kundeninformation3);

        }

        private void Mitarbeiter_Click3(object sender, RoutedEventArgs e)
        {
            Mitarbeiter mitarbeiter3 = new Mitarbeiter();
            NavigationService.Navigate(mitarbeiter3);
        }

        private void Kurspläne_Click3(object sender, RoutedEventArgs e)
        {
            Kurspläne kurspläne3 = new Kurspläne();
            NavigationService.Navigate(kurspläne3);
        }

        private void Zeitbuchungen_Click3(object sender, RoutedEventArgs e)
        {
            Zeitbuchungen zeitbuchungen3 = new Zeitbuchungen();
            NavigationService.Navigate(zeitbuchungen3);
        }
    }
}
