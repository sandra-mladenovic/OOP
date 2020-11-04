using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja10
{
    public class Ucenik : OsobaKojaSeSkoluje
    {
        private string oznakaOdeljenja;
        private int redniBrojUOdeljenju;
        private int[] ocene;

        private static int brojac = 0;


        public Ucenik(string ime, string prezime, string oznaka, int[] ocene) : base(ime, prezime)
        {
            if (ocene.Length != 6)
                throw new Izuzetak("Broj ocena za ucenika mora biti 6.");

            for(int i = 0; i < ocene.Length; i++)
            {
                if (ocene[i] > 5 || ocene[i] < 1)
                    throw new Izuzetak("Nedozvoljena vrednost za ocenu.");
            }

            if (oznaka == null)
                throw new Izuzetak("Oznaka ne mse biti null.");

            if (oznaka.Trim() == "")
                throw new Izuzetak("Oznaka ne sme biti prazna.");


            this.ocene = ocene;
            redniBrojUOdeljenju = ++Ucenik.brojac;

        }

        public override double Prosek => ocene.Average();

        public override string Identifikator => oznakaOdeljenja + redniBrojUOdeljenju;
    }
}
