using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja10
{
    public class Izuzetak : Exception
    {
        public Izuzetak() : base()
        {

        }

        public Izuzetak(string message) : base(message)
        {

        }

    }
}
