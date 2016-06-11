using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademiaProjekt
{
    class Triangle : Shape, IMerge
    {
        public int A { get; set; }
        public int H { get; set; }

        public Triangle()
        {
            Name = "Trójkąt";
        }

        public override void CalculateArea()
        {
            Area = A * H / 2;
        }

        public string Merging()
        {
            return Name + " " + Area;
        }
    }
}
