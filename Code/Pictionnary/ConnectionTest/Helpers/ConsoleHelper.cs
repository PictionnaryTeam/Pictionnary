using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest.Helpers
{
    public class ConsoleHelper
    {
        private static string _lastLine = "";

        /// <summary>
        /// Write the specified text.
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="text">Text.</param>
        public static void Write(String text)
        {
            //write in console with date time

            if (_lastLine == text)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            }

            Console.WriteLine(DateTime.Now.ToString("T") + " > " + text);
            _lastLine = text;
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
            _lastLine = text;
            Console.ResetColor();
        }
    }
}
