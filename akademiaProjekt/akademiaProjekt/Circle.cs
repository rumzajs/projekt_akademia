using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademiaProjekt
{
    class Circle : Shape, IMerge
    {
        public int R { get; set; }
        private float pi = 3.14F;

        public Circle()
        {
            Name = "Koło";
        }

        public override void CalculateArea()
        {
            Area = pi * R * R;
        }
        public string Merging()
        {
            return Name + " " + Area;
        }
    }
}
