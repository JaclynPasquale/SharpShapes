using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

namespace SharpShapes
{
    public abstract class Shape
    {
        //width, height, perimeter, border, color, fill color, number of sides, area.

        ///<summary>
        ///Specifies the color of the interior of the shape, when drawn.
        ///</summary>
        public Color FillColor { get; set; }

        /// <summary>
        /// the color of the border of the shape, when drawn.
        /// </summary>
        public Color BorderColor { get; set; }

        /// <summary>
        /// the number of sides of this shape.
        /// </summary>
        abstract public int SidesCount { get; }

        /// <summary>
        /// Creates a polygon representing this shape and adds it to the shapecanvas
        /// </summary>
        /// <param name="ShapeCanvas"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        abstract public void DrawOnto(Canvas ShapeCanvas, int x, int y);
     

        public Shape()
        {
            BorderColor = Color.Tomato;
            FillColor = Color.Bisque;
        }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>the area of the shape</returns>
        abstract public decimal Area();

        /// <summary>
        /// Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>the perimeter of the shape</returns>
        abstract public decimal Perimeter();

        /// <summary>
        /// scales the shape in size.
        /// </summary>
        /// <param name="percent"> the percentage by which to scale the shape</param>
        abstract public void Scale(int percent);

        
        

    }
}
