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
    /// Interaktionslogik für Zeitbuchungen.xaml
    /// </summary>
    public partial class Zeitbuchungen : Page
    {
        public Zeitbuchungen()
        {
            InitializeComponent();
        }
        private void Kunden_Click5(object sender, RoutedEventArgs e)
        {
            Kundeninformation kundeninformation5 = new Kundeninformation();
            NavigationService.Navigate(kundeninformation5);

        }

        private void Mitarbeiter_Click5(object sender, RoutedEventArgs e)
        {
            Mitarbeiter mitarbeiter5 = new Mitarbeiter();
            NavigationService.Navigate(mitarbeiter5);
        }

        private void Terminkalender_Click5(object sender, RoutedEventArgs e)
        {
            Terminplaner terminplaner5 = new Terminplaner();
            NavigationService.Navigate(terminplaner5);
        }

        private void Kurspläne_Click5(object sender, RoutedEventArgs e)
        {
            Kurspläne kurspläne5 = new Kurspläne();
            NavigationService.Navigate(kurspläne5);
        }
    }
}
