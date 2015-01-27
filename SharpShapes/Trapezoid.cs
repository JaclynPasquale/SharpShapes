using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Shape
    {
        public Trapezoid(int base1, int base2, int altitude)
        {
            if (base1 <= 0 || base2 <= 0 || altitude <= 0)
            {
                throw new ArgumentException();
            }
            this.base1 = base1;
            this.base2 = base2;
            this.altitude = altitude;
        }
    }
}
