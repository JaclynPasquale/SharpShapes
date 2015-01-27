using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Shape
    {
        public decimal LongBase { get; private set; }
        public decimal ShortBase { get; private set; }
        public decimal Height { get; private set; }
        public decimal AcuteAngle { get; set; }
        public decimal ObtuseAngle { get; set; }

        public Trapezoid(int longBase, int shortBase, int height)
        {
            if (height <= 0 || shortBase <= 0 || longBase <= 0 || shortBase >= longBase)
            {
                throw new ArgumentException();
            }

            this.LongBase = longBase;
            this.ShortBase = shortBase;
            this.Height = height;

            decimal wingLength = WingLength();
            this.AcuteAngle = Decimal.Round((decimal)(Math.Atan((double)(height / wingLength)) * (180.0 / Math.PI)), 2);

            this.ObtuseAngle = 180 - AcuteAngle;
        }

        private decimal WingLength()
        {
            return (LongBase - ShortBase) / 2;
        }


        public override int SidesCount
        {
            get { return 4; }
        }

        public override decimal Area()
        {
            return (LongBase + ShortBase) / 2 * Height;
           
        }
        public override decimal Perimeter()
        {
            double squares = (double)(WingLength() * WingLength() + Height * Height);
            decimal legLength = Decimal.Round((decimal)Math.Sqrt(squares), 2);
            return LongBase + ShortBase + 2 * legLength;
        }
        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            this.LongBase = LongBase * percent / 100;
            this.ShortBase = ShortBase * percent / 100;
            this.Height = Height * percent / 100;
        }

       
    }
}
