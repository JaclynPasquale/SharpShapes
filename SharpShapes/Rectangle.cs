using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace SharpShapes
{
    public class Rectangle : Quadrilateral
    {

        private decimal width;
        public decimal Width
        {
            get { return this.width; }
        }

        private decimal height;
        public decimal Height
        {
            get { return this.height; }
        }

        

        public Rectangle(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            this.width = width;
            this.height = height;
        }

        public override decimal Area()
        {
            return Height * Width;
        }

        public override decimal Perimeter()
        {
            return (Height * 2) + (Width * 2);
        }

        public override void Scale(int percent)
        {
            if (percent <= 0 )
            {
                throw new ArgumentException();
            }
            this.width = width * percent / 100;
            this.height = height * percent / 100;

        }
        public override void DrawOnto(System.Windows.Controls.Canvas ShapeCanvas, int x, int y)
        {
            int squareSide = (int)Width;

            SolidColorBrush mediaFillColor = new SolidColorBrush();
            mediaFillColor.Color = System.Windows.Media.Color.FromArgb(FillColor.A, FillColor.R, FillColor.G, FillColor.B);

            SolidColorBrush mediaBorderColor = new SolidColorBrush();
            mediaBorderColor.Color = System.Windows.Media.Color.FromArgb(BorderColor.A, BorderColor.R, BorderColor.B, BorderColor.G);

            System.Windows.Shapes.Polygon mySquare = new System.Windows.Shapes.Polygon();

            mySquare.Stroke = mediaBorderColor;
            mySquare.Fill = mediaFillColor;
            mySquare.StrokeThickness = 2;
           
            System.Windows.Point Point1 = new System.Windows.Point(x, y);
            System.Windows.Point Point2 = new System.Windows.Point(x + (double)Width, y);
            System.Windows.Point Point3 = new System.Windows.Point(x + (double)Width, y + (double)Height);
            System.Windows.Point Point4 = new System.Windows.Point(x, y + (double)Height);
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