using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._24
{
    public class Satellite : SkyObject
    {
        public Planet Planet { get; set; }
        public Satellite(int mass, int diameter, Planet planet) : base(mass, diameter)
        {
            this.Planet = planet;
        }
    }
}
