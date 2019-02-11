using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Helpers
{
    public class ConsoleHelper
    {
        /// <summary>
        /// Write the specified text.
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="text">Text.</param>
        public static void Write(String text)
        {
            //write in console with date time
            Debug.WriteLine(DateTime.Now.ToString("T") + " > " + text);
        }


        /// <summary>
        /// Write the specified error
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="text">Text.</param>
        public static void WriteError(String text)
        {
            //write in console with date time
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DateTime.Now.ToString("T") + " > " + text);
            Console.ResetColor();
        }
    }
}
