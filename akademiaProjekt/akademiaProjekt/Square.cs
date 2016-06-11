using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademiaProjekt
{
    class Square : Shape, IMerge
    {
        public int A { get; set; }
        public int B { get; set; }

        public Square()
        {
            Name = "Kwadrat";
        }

        public override void CalculateArea()
        {
            Area =  A * B;
        }
        public string Merging()
        {
            return Name + " " + Area;
        }
    }
}
