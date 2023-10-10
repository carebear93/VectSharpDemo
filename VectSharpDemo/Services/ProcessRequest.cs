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
        public static async Task ProcessUserRequestAsync(string userInput)
        {
            var page = await DrawPage.CreatePage();

            // TODO: Check if file name exists, save with an incremented file number
            Random rnd = new Random();
            int fileNumber = rnd.Next(1, 99999);
            string fileName = $"Bezier Curve{fileNumber}";

            switch (userInput)
            {
                case "1":
                    var bezierCurve = await BezierCurve.DrawBezierCurve(page);
                    SaveFile.Save(bezierCurve, fileName);
                    Console.WriteLine($"SVG saved with the name {fileName} in ....");
                    break;
                case "2":
                    var ellipticalArc = await EllipticalArc.DrawEllipticalArc(page);
                    SaveFile.Save(ellipticalArc, fileName);
                    Console.WriteLine($"SVG saved with the name {fileName} in ....");
                break;
                case "3":
                    var pathFigures = await PathFigures.DrawPathFigures(page);
                    SaveFile.Save(pathFigures, fileName);
                    Console.WriteLine($"SVG saved with the name {fileName} in ....");
                break;
            }
        }
    }
}
