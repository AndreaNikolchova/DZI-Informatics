using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._24
{
    public class Star : SkyObject
    {
        public string Type { get; set; }
        public Star(int mass, int diameter, string type) : base(mass, diameter)
        {
            this.Type = type;
        }
    }
}
