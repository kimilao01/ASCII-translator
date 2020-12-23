using System;

namespace ascii_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter somthing: ");
                string word = Console.ReadLine();
                foreach (char c in word)
                {
                    Console.Write(Convert.ToInt32(c) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
