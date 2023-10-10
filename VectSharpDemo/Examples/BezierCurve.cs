using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectSharp;
using VectSharp.SVG;

namespace VectSharpDemo.Examples
{
    public class BezierCurve
    {
        public static dynamic DrawBezierCurve(Page page)
        {
            // Source: https://giorgiobianchini.com/VectSharp/arbitrary_shapes.html
            Graphics graphics = page.Graphics;

            // Create the GraphicsPath object.
            GraphicsPath path = new GraphicsPath();

            // Start point.
            Point p0 = new Point(20, 30);

            // Control point 1.
            Point p1 = new Point(50, 20);

            // Control point 2.
            Point p2 = new Point(80, 40);

            // End point.
            Point p3 = new Point(80, 70);

            // Add the Bézier segment to the path.
            path.MoveTo(p0).CubicBezierTo(p1, p2, p3);

            // Fill the path.
            graphics.FillPath(path, Colours.Green);

            // Stroke the path.
            graphics.StrokePath(path, Colours.Black, lineWidth: 2);

            page.SaveAsSVG("Bezier.svg");

            return page;
        }
    }
}
