using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Shape
    {
        private decimal base1;
        public decimal Base1
        {
            get { return this.base1; }
        }
        private decimal base2;
        public decimal Base2
        {
            get { return this.base2; }
        }
        private decimal altitude;
        public decimal Altitude
        {
            get { return this.altitude;  }
        }

        public object AcuteAngle { get ; set; }
        public object ObtuseAngle { get; set; }
     
        public override int SidesCount
        {
            get { return 4; }

        }


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

        public override decimal Area()
        {
            throw new NotImplementedException();
        }
        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }
        public override void Scale(int percent)
        {
            throw new NotImplementedException();
        }

       
    }
}
