using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OsobaKojaSeSkoluje[] niz = new OsobaKojaSeSkoluje[10];
                int[] ocene1 = { 4, 5, 2, 4, 5, 2 };
                int[] ocene2 = { 5, 5, 6, 9, 10, 10, 10, 7 };
                niz[0] = new Ucenik("Pera", "Detlic", "B", ocene1);
                niz[1] = new Student("Patak", "Daca", 2017, ocene2);
                
                for(int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] != null)
                        Console.WriteLine(niz[i]);
                }
                
            }
            catch (Izuzetak e)
            {

                Console.Write(e.Message);
            }
            
            
        }
    }
}
