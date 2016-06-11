using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademiaProjekt
{
    interface IMerge
    {
        string Merging();
    }
     public abstract class Shape
    {
        public float Area { get; set; }
        public string Name { get; set; }

        public abstract void CalculateArea();
    }
}
