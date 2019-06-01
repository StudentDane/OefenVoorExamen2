using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Verkiezing.Lib.Entities;
using Verkiezing.Lib.Services;

namespace ListBoxenEnCollections.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeheerKandidaat beheerKandidaat;
        Kandidaat huidigeKandidaat;
        
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            beheerKandidaat = new BeheerKandidaat();
            KoppelKandidaten();
            KoppelStemmen();
            txtNaam.Focus();
        }

        void KoppelKandidaten()
        {
            lstKandidaten.ItemsSource = beheerKandidaat.Kandidaten;
            lstKandidaten.Items.Refresh();
        }

        private void LstKandidaten_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstKandidaten.SelectedItem != null)
            {
                huidigeKandidaat = (Kandidaat)lstKandidaten.SelectedItem;
                beheerKandidaat.VoegStemmenToe(huidigeKandidaat);
                KoppelStemmen();
                lstKandidaten.SelectedItem = null;
            }
        }

        void KoppelStemmen()
        {
            lstStemmen.Items.Clear();
            foreach (Kandidaat kandidaat in beheerKandidaat.Kandidaten)
            {
                lstStemmen.Items.Add(kandidaat.AantalStemmen);
            }
            lstStemmen.Items.Refresh();
        }

        /*void KoppelKleuren()
        {
            SolidColorBrush kleur = new SolidColorBrush();
            foreach (Kandidaat kandidaat in beheerKandidaat.Kandidaten)
            {
                //Convert Brush to SolidColorBrush?
                kleur = kandidaat.Kleur;
                lstKandidaten.Items.
            }
            lstKandidaten.Items.Refresh();
        }*/

        void KandidaatToevoegen()
        {
            string naam = "", partij = "";
            if (txtNaam != null && txtPartij != null)
            {
                naam = txtNaam.Text;
                partij = txtPartij.Text;
                beheerKandidaat.VoegKandidaatToe(naam, partij, Brushes.White);
                KoppelKandidaten();
                KoppelStemmen();
            } 
            else
            {
                lblFeedback.Content = "Het toevoegen is niet gelukt! Probeer opnieuw";
            }
        }

        private void BtnBevestig_Click(object sender, RoutedEventArgs e)
        {
            KandidaatToevoegen();
        }
    }
}
