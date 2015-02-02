using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

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

        public override void DrawOnto(System.Windows.Controls.Canvas ShapeCanvas, int x, int y)
        {
     
            SolidColorBrush mediaFillColor = new SolidColorBrush();
            mediaFillColor.Color = System.Windows.Media.Color.FromArgb(FillColor.A, FillColor.R, FillColor.G, FillColor.B);

            SolidColorBrush mediaBorderColor = new SolidColorBrush();
            mediaBorderColor.Color = System.Windows.Media.Color.FromArgb(BorderColor.A, BorderColor.R, BorderColor.B, BorderColor.G);

            System.Windows.Shapes.Polygon mySquare = new System.Windows.Shapes.Polygon();

            mySquare.Stroke = mediaBorderColor;
            mySquare.Fill = mediaFillColor;
            mySquare.StrokeThickness = 2;

            

            System.Windows.Point Point1 = new System.Windows.Point(x + (double)WingLength(), y);
            System.Windows.Point Point2 = new System.Windows.Point(x, y + (double)Height);
            System.Windows.Point Point3 = new System.Windows.Point(x + (double)LongBase, y + (double)Height);
            System.Windows.Point Point4 = new System.Windows.Point(x + (double)WingLength() + (double)ShortBase, y );
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            mySquare.Points = myPointCollection;
            ShapeCanvas.Children.Add(mySquare);
        }

       
    }
}
