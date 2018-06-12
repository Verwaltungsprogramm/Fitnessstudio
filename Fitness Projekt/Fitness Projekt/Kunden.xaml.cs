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
    /// Interaktionslogik für Kunden.xaml
    /// </summary>
    public partial class Kunden : Page
    {
        public Kunden()
        {
            InitializeComponent();
        }

        private void Kunden_Click(object sender, RoutedEventArgs e)
        {
            Kundeninformation kundeninformation = new Kundeninformation();
            NavigationService.Navigate(kundeninformation);
          
        }

        private void Mitarbeiter_Click(object sender, RoutedEventArgs e)
        {
            Mitarbeiter mitarbeiter = new Mitarbeiter();
            NavigationService.Navigate(mitarbeiter);
        }

        private void Terminkalender_Click(object sender, RoutedEventArgs e)
        {
            Terminplaner terminplaner = new Terminplaner();
            NavigationService.Navigate(terminplaner);
        }

        private void Kurspläne_Click(object sender, RoutedEventArgs e)
        {
            Kurspläne kurspläne = new Kurspläne();
            NavigationService.Navigate(kurspläne);
        }

        private void Zeitbuchungen_Click(object sender, RoutedEventArgs e)
        {
            Zeitbuchungen zeitbuchungen = new Zeitbuchungen();
            NavigationService.Navigate(zeitbuchungen);
        }
    }
}
