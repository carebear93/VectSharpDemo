using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectSharp;
using VectSharp.SVG;

namespace VectSharpDemo.Services
{
    public class SaveFile
    {
        public static void Save(Page page, string fileName)
        {
            Document doc = new Document();

            doc.Pages.Add(page);

            doc.Pages.Last().SaveAsSVG(@$"{fileName}.svg");
        }
    }
}
