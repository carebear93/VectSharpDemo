using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectSharpDemo.Interface
{
    public class TUI
    {
        public static void DrawInterface()
        {
            string appTitle = "____   ____             __   _________.__                       ________                         \r\n\\   \\ /   /____   _____/  |_/   _____/|  |__ _____ _____________\\______ \\   ____   _____   ____  \r\n \\   Y   // __ \\_/ ___\\   __\\_____  \\ |  |  \\\\__  \\\\_  __ \\____ \\|    |  \\_/ __ \\ /     \\ /  _ \\ \r\n  \\     /\\  ___/\\  \\___|  | /        \\|   Y  \\/ __ \\|  | \\/  |_> >    `   \\  ___/|  Y Y  (  <_> )\r\n   \\___/  \\___  >\\___  >__|/_______  /|___|  (____  /__|  |   __/_______  /\\___  >__|_|  /\\____/ \r\n              \\/     \\/            \\/      \\/     \\/      |__|          \\/     \\/      \\/        ";

            string appMenu = "    ┌───────────────────────────────────────────────────┐\r\n    │                                                   │\r\n    │    Select a shape to draw!                        │\r\n    │                                                   │\r\n    │    1. Bezier Curve                                │\r\n    │                                                   │\r\n    │    2. Ellipitical Curve                            │\r\n    │                                                   │\r\n    │    3. Path Figures                                │\r\n    │                                                   │\r\n    │                                                   │\r\n    │                                                   │\r\n    │                                                   │\r\n    │                                                   │\r\n    │                                                   │\r\n    │                                                   │\r\n    └───────────────────────────────────────────────────┘";

            Console.WriteLine(appTitle);
            Console.WriteLine(appMenu);
        }
    }
}
