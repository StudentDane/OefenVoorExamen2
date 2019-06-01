using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Verkiezing.Lib.Entities
{
    public class Kandidaat
    {
        public string Naam { get; set; }
        public string Partij { get; set; }
        public Brush Kleur { get; set; }
        public int AantalStemmen { get; set; }


        public Kandidaat(string naam, string partij, Brush kleur, int stemmen = 0)
        {
            Naam = naam;
            Partij = partij;
            Kleur = kleur;
            AantalStemmen = stemmen;
        }

        public override string ToString()
        {
            string info;
            info = $"{Naam} bij ({Partij})";
            return info;
        }

    }
}
