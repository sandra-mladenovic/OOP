using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja10
{
    public abstract class OsobaKojaSeSkoluje : Osoba
    {
        public OsobaKojaSeSkoluje(string ime, string prezime) : base(ime, prezime)
        {
        }

        public abstract double Prosek { get; }
        public abstract string Identifikator { get; }

        public override string ToString()
        {
            return $"{Identifikator}, {Prosek}, " + base.ToString();
        }
    }
}
