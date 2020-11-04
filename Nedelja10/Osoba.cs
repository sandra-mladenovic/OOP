using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja10
{
    public abstract class Osoba
    {
        private string ime;
        private string prezime;

        public Osoba(string ime, string prezime)
        {
            if (ime == null || prezime == null)
                throw new Izuzetak("Ime i prezime ne smeju biti null.");

            if (ime.Length < 3 || prezime.Length < 3)
                throw new Izuzetak("Ime i prezime moraju imati bar 3 karaktera.");

            this.ime = ime;
            this.prezime = prezime;
        }

        public string Ime {
            get => this.ime;
            set {

                if(value == null)
                    throw new Izuzetak("Ime ne sme biti null.");
                if(value.Length < 3)
                    throw new Izuzetak("Ime mora imati bar 3 karaktera.");
            }
        }

        public string Prezime
        {
            get => this.prezime;
            set
            {

                if (value == null)
                    throw new Izuzetak("Prezime ne sme biti null.");
                if (value.Length < 3)
                    throw new Izuzetak("Prezime mora imati bar 3 karaktera.");
            }
        }

        public override string ToString()
        {
            return $"{ime} {prezime}";
        }
    }
}
