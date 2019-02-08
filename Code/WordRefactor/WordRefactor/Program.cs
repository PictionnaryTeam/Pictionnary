using System;

namespace WordRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Léa", "  Orches5tre", "test   ", "!Salut COMMent c'est La Vie!!! <3","007PAN!", ".-,+\"'^*%&/()==?`!£", "çéàüüöÉÀÔ" };

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
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}


