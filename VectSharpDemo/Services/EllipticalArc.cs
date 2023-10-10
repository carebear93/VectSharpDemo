using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectSharp;
using VectSharp.SVG;

namespace VectSharpDemo.Services
{
    public class EllipticalArc
    {
        public dynamic DrawEllipticalArc(Page page) 
        {
            Graphics graphics = page.Graphics;

            // Create the GraphicsPath object.
            GraphicsPath path = new GraphicsPath();

            // Starting point.
            Point p0 = new Point(20, 30);

            // End point.
            Point p1 = new Point(80, 70);

            // Radius of the first semi-axis.
            double radiusX = 40;

            // Radius of the second semi-axis.
            double radiusY = 35;

            // Orientation of the ellipse.
            double axisAngle = 0;

            // Large arc flag.
            bool largeArc = false;

            // Arc direction.
            bool clockwise = false;

            // Move to the starting point and add the arc to the path.
            path.MoveTo(p0).EllipticalArc(radiusX, radiusY, axisAngle, largeArc, clockwise, p1);

            // Fill and stroke.
            graphics.FillPath(path, Colours.Green);
            graphics.StrokePath(path, Colours.Black, lineWidth: 2);

            page.SaveAsSVG("EllipticalArc.svg");

            return page;
        }
    }
}
