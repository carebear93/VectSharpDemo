using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectSharp;
using VectSharp.SVG;

namespace VectSharpDemo.Services
{
    public class PathFigures
    {
        public dynamic DrawPathFigures(Page page)
        {
            // Source: https://giorgiobianchini.com/VectSharp/arbitrary_shapes.html
            Graphics graphics = page.Graphics;

            // Create a new GraphicsPath.
            GraphicsPath full = new GraphicsPath();

            // Add the first (outer) triangle. Note that this is drawn in clockwise order.
            full.MoveTo(10, 90).LineTo(50, 10).LineTo(90, 90).Close();

            // Add the second (inner) triangle. Note that this is also drawn in clockwise
            // order; thus, the path will be completely filled.
            full.MoveTo(30, 70).LineTo(50, 30).LineTo(70, 70).Close();

            // Fill and stroke the path.
            graphics.FillPath(full, Colours.Green);
            graphics.StrokePath(full, Colours.Black, lineWidth: 2);

            // Translate the axes so the two figures do not overlap.
            graphics.Translate(100, 0);

            // Create a new GraphicsPath.
            GraphicsPath hole = new GraphicsPath();

            // Add the first (outer) triangle. Same code as above.
            hole.MoveTo(10, 90).LineTo(50, 10).LineTo(90, 90).Close();

            // Add the second (inner) triangle. In this case, the triangle is drawn in
            // counter-clockwise order and, thus, the path has a hole in the middle.
            hole.MoveTo(30, 70).LineTo(70, 70).LineTo(50, 30).Close();

            // Fill and stroke the path.
            graphics.FillPath(hole, Colours.Green);
            graphics.StrokePath(hole, Colours.Black, lineWidth: 2);

            page.SaveAsSVG("PathFigures.svg");
            return page;
        }
    }
}
