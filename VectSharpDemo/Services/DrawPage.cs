﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectSharp;
using VectSharp.SVG;

namespace VectSharpDemo.Services
{
    public class DrawPage
    {
        public static dynamic CreatePage()
        {
            Page page = new Page(1000, 1000);
            return page;
        }
    }
}
