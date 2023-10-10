using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectSharpDemo.Services;

namespace VectSharpDemo.Interface
{
    public class Handle
    {
        public static void InterfaceHandle()
        {
            TUI.DrawInterface();
            
            string userInput = Console.ReadLine();

            // while loop to keep program active after function complete
            

            // if userInput is not 1, 2 or 3 send error message and try again
            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("Please enter a valid option!");
                InterfaceHandle();
            }
            else
            {
                ProcessRequest.ProcessUserRequestAsync(userInput);
            }
        }
    }
}
