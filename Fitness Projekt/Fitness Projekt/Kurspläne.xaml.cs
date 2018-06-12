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
    /// Interaktionslogik für Kurspläne.xaml
    /// </summary>
    public partial class Kurspläne : Page
    {
        public Kurspläne()
        {
            InitializeComponent();
        }
        private void Kunden_Click4(object sender, RoutedEventArgs e)
        {
            Kundeninformation kundeninformation4 = new Kundeninformation();
            NavigationService.Navigate(kundeninformation4);

        }

        private void Mitarbeiter_Click4(object sender, RoutedEventArgs e)
        {
            Mitarbeiter mitarbeiter4 = new Mitarbeiter();
            NavigationService.Navigate(mitarbeiter4);
        }

        private void Terminkalender_Click4(object sender, RoutedEventArgs e)
        {
            Terminplaner terminplaner4 = new Terminplaner();
            NavigationService.Navigate(terminplaner4);
        }

        private void Zeitbuchungen_Click4(object sender, RoutedEventArgs e)
        {
            Zeitbuchungen zeitbuchungen4 = new Zeitbuchungen();
            NavigationService.Navigate(zeitbuchungen4);
        }
    }
}
