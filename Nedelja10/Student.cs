using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja10
{
    public class Student : OsobaKojaSeSkoluje
    {
        private int godinaUpisa;
        private int broj;
        private int[] ocene;

        private static int brojac = 0;


        public Student(string ime, string prezime, int godinaUpisa, int[] ocene) : base(ime, prezime)
        {
            if (ocene.Length != 8)
                throw new Izuzetak("Potrebno je 8 ocena.");

            for (int i = 0; i < ocene.Length; i++)
            {
                if (ocene[i] > 10 || ocene[i] < 5)
                    throw new Izuzetak("Ocena mora biti u opsegu od 5 do 10");
            }

            this.ocene = new int[8];

            for (int i = 0; i < ocene.Length; i++)
            {
                this.ocene[i] = ocene[i];
            }

            if (godinaUpisa > DateTime.Now.Year)
                throw new Izuzetak("Godina ne moze da bude u buducnosti.");

            if (godinaUpisa < 2005)
                throw new Izuzetak("Nedozvoljena vrednost za datum.");

            this.godinaUpisa = godinaUpisa;
            broj = ++Student.brojac;
        }

        public override double Prosek => ocene.Average();

        public override string Identifikator => $"{broj}/{godinaUpisa}";
    }
}
