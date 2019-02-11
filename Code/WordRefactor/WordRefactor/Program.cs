using System;

namespace WordRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "Léa",
                "  Orches5tre",
                "test   ",
                "!Salut COMMent c'est La Vie!!! <3",
                "007PAN!", ".-,+\"'^*%&/()==?`!£",
                "çéàüüöÉÀÔ",
                "Hey! Cette phrase, longue, est une expérience !! ",
                "·--· ·· -·-· − ·· --- -· -· ·- ·-· -·-- "
            };

            Console.SetWindowSize(150, 50);
            Console.SetBufferSize(150, 50);

            foreach (string word in words)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"");

                Console.ResetColor();
                Console.Write(word);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  =>  ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"");

                Console.ResetColor();
                Console.Write(word.RefactorText());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\"\n");
            }

            Console.ReadLine();
        }
    }
}


