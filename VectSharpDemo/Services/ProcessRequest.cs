using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VectSharpDemo.Examples;
using VectSharpDemo.Services;

namespace VectSharpDemo.Services
{
    public class ProcessRequest
    {
        public static void ProcessUserRequest(string userInput)
        {
            var page = DrawPage.CreatePage();

            // TODO: Check if file name exists, save with an incremented file number
            // TODO: Just fix filename don't know why I did it like this I was rushing
            Random rnd = new Random();
            int fileNumber = rnd.Next(1, 99999);
            string fileName = $"Output{fileNumber}";

            switch (userInput)
            {
                case "1":
                    var bezierCurve = BezierCurve.DrawBezierCurve(page);
                    SaveFile.Save(bezierCurve, fileName);
                    Console.WriteLine($"SVG saved with the name {fileName} in VectSharpDemo//bin//Debug//net6.0");
                    break;
                case "2":
                    var ellipticalArc = EllipticalArc.DrawEllipticalArc(page);
                    SaveFile.Save(ellipticalArc, fileName);
                    Console.WriteLine($"SVG saved with the name {fileName} in VectSharpDemo//bin//Debug//net6.0");
                break;
                case "3":
                    var pathFigures = PathFigures.DrawPathFigures(page);
                    SaveFile.Save(pathFigures, fileName);
                    Console.WriteLine($"SVG saved with the name {fileName} in VectSharpDemo//bin//Debug//net6.0");
                break;
            }
        }
    }
}
