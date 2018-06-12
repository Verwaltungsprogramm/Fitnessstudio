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
    /// Interaktionslogik für Mitarbeiter.xaml
    /// </summary>
    public partial class Mitarbeiter : Page
    {
        public Mitarbeiter()
        {
            InitializeComponent();
        }
        private void Kunden_Click2(object sender, RoutedEventArgs e)
        {
            Kundeninformation kundeninformation2 = new Kundeninformation();
            NavigationService.Navigate(kundeninformation2);

        }

        private void Terminkalender_Click2(object sender, RoutedEventArgs e)
        {
            Terminplaner terminplaner2 = new Terminplaner();
            NavigationService.Navigate(terminplaner2);
        }

        private void Kurspläne_Click2(object sender, RoutedEventArgs e)
        {
            Kurspläne kurspläne2 = new Kurspläne();
            NavigationService.Navigate(kurspläne2);
        }

        private void Zeitbuchungen_Click2(object sender, RoutedEventArgs e)
        {
            Zeitbuchungen zeitbuchungen2 = new Zeitbuchungen();
            NavigationService.Navigate(zeitbuchungen2);
        }
    }
}
