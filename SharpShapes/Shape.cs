using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        public virtual int SidesCount { get; }

        
        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>the area of the shape</returns>
        public abstract decimal Area();

        /// <summary>
        /// Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>the perimeter of the shape</returns>
        public abstract int Perimeter();

        /// <summary>
        /// scales the shape in size.
        /// </summary>
        /// <param name="percent"> the percentage by which to scale the shape</param>
        public abstract void scale(int percent);

    }
}
