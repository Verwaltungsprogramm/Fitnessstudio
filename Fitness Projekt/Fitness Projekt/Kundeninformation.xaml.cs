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
    /// Interaktionslogik für Kundeninformation.xaml
    /// </summary>
    public partial class Kundeninformation : Page
    {
        public Kundeninformation()
        {
            InitializeComponent();
        }

        private void Mitarbeiter_Click1(object sender, RoutedEventArgs e)
        {
            Mitarbeiter mitarbeiter1 = new Mitarbeiter();
            NavigationService.Navigate(mitarbeiter1);
        }

        private void Terminkalender_Click1(object sender, RoutedEventArgs e)
        {
            Terminplaner terminplaner1 = new Terminplaner();
            NavigationService.Navigate(terminplaner1);
        }

        private void Kurspläne_Click1(object sender, RoutedEventArgs e)
        {
            Kurspläne kurspläne1 = new Kurspläne();
            NavigationService.Navigate(kurspläne1);
        }

        private void Zeitbuchungen_Click1(object sender, RoutedEventArgs e)
        {
            Zeitbuchungen zeitbuchungen1 = new Zeitbuchungen();
            NavigationService.Navigate(zeitbuchungen1);
        }
    }
}
