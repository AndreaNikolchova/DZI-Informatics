using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._24
{
    public class Planet : SkyObject
    {
        public Star Star { get; set; }
        public Planet(int mass, int diameter, Star star) : base(mass, diameter)
        {
            this.Star = star;
        }
    }
}
