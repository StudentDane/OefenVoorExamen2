using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Verkiezing.Lib.Entities;

namespace Verkiezing.Lib.Services
{
    public class BeheerKandidaat
    {
        public List<Kandidaat> Kandidaten { get; set; }
        //public string FoutMelding { get; private set; }

        public BeheerKandidaat()
        {
            Kandidaten = new List<Kandidaat>();
            MaakKandidaten();
            //FoutMelding = "Het toevoegen is niet gelukt! Probeer opnieuw";
        }

        public void VoegKandidaatToe(string naam, string partij, Brush kleur)
        {
            Kandidaat kandidaat = null;
            kandidaat = new Kandidaat(naam, partij, kleur);
            Kandidaten.Add(kandidaat);
        }

        private void MaakKandidaten()
        {
            Kandidaat kandidaat = null;
            kandidaat = new Kandidaat("Fart De Bever", "N.VA", Brushes.Yellow);
            Kandidaten.Add(kandidaat);
            kandidaat = new Kandidaat("Kristof Kalfo", "Groen", Brushes.Green);
            Kandidaten.Add(kandidaat);
            kandidaat = new Kandidaat("Stom van Grieken", "Vlaams Behang", Brushes.Pink);
            Kandidaten.Add(kandidaat);
            kandidaat = new Kandidaat("Gwendotrien Trutten", "Gesloten.Vld", Brushes.Blue);
            Kandidaten.Add(kandidaat);
        }

        public void VoegStemmenToe(Kandidaat huidigeKandidaat)
        {
            foreach (Kandidaat kandidaat in Kandidaten)
            {
                if (huidigeKandidaat == kandidaat)
                {
                    kandidaat.AantalStemmen++;
                }
            }
        }
    }
}
